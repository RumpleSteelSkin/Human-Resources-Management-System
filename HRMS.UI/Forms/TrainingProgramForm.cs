using FluentValidation.Results;
using HRMS.Business.Validators;
using HRMS.Entities.Models;
using HRMS.UI.Tools;
using Microsoft.EntityFrameworkCore;

namespace HRMS.UI.Forms
{
    public partial class TrainingProgramForm : Form
    {
        public TrainingProgramForm()
        {
            InitializeComponent();
        }
        #region GLOBALS
        private TrainingProgram? selectedTrainingProgram;
        #endregion
        #region METHODS
        private void GetAllTrainingProgramsToList()
        {
            try
            {
                FP.UpdateListBox(lstTrainingProgram, "ID", null!, FP.TrainingProgramService?.GetAll()!, LstTrainingProgram_SelectedIndexChanged!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }

        #endregion
        #region EVENTS
        private void TrainingProgramForm_Load(object sender, EventArgs e)
        {
            try
            {
                FP.UpdateListBox(lstEmployees, "ID", "Name", FP.EmployeeService?.GetAll()!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
            GetAllTrainingProgramsToList();
        }
        private void BtnTrainingProgramAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TrainingProgram trainingProgram = new()
                {
                    Name = txtTrainingProgramName.Text,
                    Description = txtTrainingProgramDescription.Text,
                    StartDate = dtTrainingProgramStartDate.Value,
                    EndDate = dtTrainingProgramEndDate.Value,
                    TrainerID = Guid.TryParse(lstEmployees.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir eğitmen seçiniz."),
                };
                ValidationResult result = new TrainingProgramValidator().Validate(trainingProgram);
                if (!result.IsValid)
                    throw new Exception(string.Join("\n", result.Errors));
                TrainingProgramSaveDialog dialogForm = new(trainingProgram.ID);
                DialogResult dialogResult = dialogForm.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    if (dialogForm.trainingProgramEmployees != null && dialogForm.trainingProgramEmployees.Count > 0)
                        trainingProgram.TrainingProgramEmployees = dialogForm.trainingProgramEmployees;
                    FP.TrainingProgramService?.Create(trainingProgram);
                }
                MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllTrainingProgramsToList();
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void LstTrainingProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstTrainingProgram.SelectedIndex != -1 && lstTrainingProgram.SelectedItem != null)
                {
                    selectedTrainingProgram = (TrainingProgram)lstTrainingProgram.SelectedItem;
                    txtTrainingProgramName.Text = selectedTrainingProgram.Name;
                    txtTrainingProgramDescription.Text = selectedTrainingProgram.Description;
                    dtTrainingProgramEndDate.Value = selectedTrainingProgram.EndDate;
                    dtTrainingProgramStartDate.Value = selectedTrainingProgram.StartDate;
                    lstEmployees.SelectedValue = selectedTrainingProgram.TrainerID;
                }
            }
            catch { }
        }
        private void TxtTrainingProgramSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FP.UpdateListBox(lstTrainingProgram, "ID", null!, FP.TrainingProgramService?.GetAll()?.Where(emp => emp.Name!.Contains(txtTrainingProgramSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
            }
            catch { }
        }
        private void TxtTrainerSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FP.UpdateListBox(lstEmployees, "ID", null!, FP.EmployeeService?.GetAll()?.Where(emp => emp.FullName!.Contains(txtTrainerSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
            }
            catch { }
        }
        private void LstTrainingProgram_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lstTrainingProgram.SelectedIndex != -1 && lstTrainingProgram.SelectedItem != null)
                {
                    string details = $"Eğitim Programının Ayrıntıları;\n";
                    Guid trainingProgramID = Guid.TryParse(lstTrainingProgram.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir eğitim programı seçiniz.");
                    TrainingProgram selectedTrainingProgram = (TrainingProgram)lstTrainingProgram.SelectedItem;
                    if (selectedTrainingProgram != null)
                    {

                        details += $"Eğitim Adı: {selectedTrainingProgram.Name}\nEğitim Açıklaması: {selectedTrainingProgram.Description}\nEğitmen:{selectedTrainingProgram.Trainer?.FullName}\nEğitim Başlangıç Tarihi:{selectedTrainingProgram.StartDate}\nEğitim Bitiş Tarihi:{selectedTrainingProgram.EndDate}\n\nEğitime Katılanlar;\n";
                    }
                    var result = FP.ADBContext?.TrainingProgramEmployee
                        .Where(tpe => tpe.TrainingProgramID == trainingProgramID)
                        .Include(tpe => tpe.TrainingProgram)
                        .ThenInclude(tp => tp!.Trainer)
                        .Include(tpe => tpe.Employee)
                        .Select(tpe => new
                        {
                            EmployeeName = tpe.Employee!.FirstName + " " + tpe.Employee.LastName
                        })
                        .OrderBy(tpe => tpe.EmployeeName)
                        .ToList();
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            details += $"{item.EmployeeName}\n";
                        }
                    }
                    MessageBox.Show(details, "Detaylar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }
        private void BtnTrainingProgramUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTrainingProgram.SelectedIndex != -1 && lstTrainingProgram.SelectedItem != null)
                {
                    selectedTrainingProgram = (TrainingProgram)lstTrainingProgram.SelectedItem;

                    DialogResult dr = MessageBox.Show($"{selectedTrainingProgram.Name} isimli eğitim programını güncellemek istediğinize emin misiniz?", "Eğitim Programı Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (selectedTrainingProgram != null)
                        {
                            selectedTrainingProgram.StartDate = dtTrainingProgramStartDate.Value;
                            selectedTrainingProgram.EndDate = dtTrainingProgramEndDate.Value;
                            selectedTrainingProgram.Name = txtTrainingProgramName.Text;
                            selectedTrainingProgram.Description = txtTrainingProgramDescription.Text;
                            selectedTrainingProgram.TrainerID = Guid.TryParse(lstEmployees.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir eğitmen seçiniz.");


                            ValidationResult result = new TrainingProgramValidator().Validate(selectedTrainingProgram);
                            if (!result.IsValid)
                                throw new Exception(string.Join("\n", result.Errors));

                            TrainingProgramSaveDialog dialogForm = new(selectedTrainingProgram.ID);
                            DialogResult dialogResult = dialogForm.ShowDialog();
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (dialogForm.trainingProgramEmployees != null && dialogForm.trainingProgramEmployees.Count > 0)
                                    selectedTrainingProgram.TrainingProgramEmployees = dialogForm.trainingProgramEmployees;
                                var recordsToDelete = FP.ADBContext?.TrainingProgramEmployee
                                    .Where(tpe => tpe.TrainingProgramID == selectedTrainingProgram.ID);
                                if (recordsToDelete != null)
                                    FP.ADBContext?.TrainingProgramEmployee.RemoveRange(recordsToDelete);
                                FP.TrainingProgramService?.Update(selectedTrainingProgram);
                            }
                            selectedTrainingProgram = null;
                            MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetAllTrainingProgramsToList();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }

        }
        private void BtnTrainingProgramDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTrainingProgram.SelectedIndex != -1 && lstTrainingProgram.SelectedValue != null)
                {

                    DialogResult dr = MessageBox.Show($"{lstTrainingProgram?.SelectedItem?.ToString()} isimli eğitim programını silmek istediğinize emin misiniz?", "Eğitim Programı Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Guid tpID = (Guid.TryParse(lstTrainingProgram?.SelectedValue?.ToString(), out var tpXID) ? tpXID : throw new Exception("Geçerli bir eğitim programı seçiniz."));
                        var recordsToDelete = FP.ADBContext?.TrainingProgramEmployee
                                   .Where(tpe => tpe.TrainingProgramID == tpID);
                        if (recordsToDelete != null)
                            FP.ADBContext?.TrainingProgramEmployee.RemoveRange(recordsToDelete);
                        FP.TrainingProgramService?.Delete(tpID);
                        selectedTrainingProgram = null;
                        MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllTrainingProgramsToList();
                        FP.FormClear(this);
                    }
                }
                else
                {
                    MessageBox.Show("Listeden bir eğitim programı seçiniz!");
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        #endregion
    }
}

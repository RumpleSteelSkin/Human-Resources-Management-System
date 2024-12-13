using HRMS.Business.Services;
using HRMS.DataAccess.Context;
using HRMS.DataAccess.Repositories;
using HRMS.Entities.Models;
using HRMS.UI.Tools;

namespace HRMS.UI.Forms
{
    public partial class EmployeeForm : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly EmployeeRepository _employeeRepository;
        public EmployeeForm()
        {
            InitializeComponent();
            var context = new ADBContext();

            _employeeRepository = new EmployeeRepository(context);
            _employeeService = new EmployeeService(_employeeRepository);
        }

        private Employee? selectedemployee;

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {
                FP.UpdateListBox(lstÇalışanlar, "ID", null!, FP.EmployeeService?.GetAll()!);
                FP.UpdateComboBox(cmbDepartment, "ID", "Name", FP.DepartmentService?.GetAll()!);
                FP.UpdateComboBox(cmbPosition, "ID", "Name", FP.PositionService?.GetAll()!);
                FP.UpdateListBox(lstEmployees, "ID", null!, FP.EmployeeService?.GetAll()!, LstEmployees_SelectedIndexChanged!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"{lstEmployees.SelectedItem} isimli çalışanı eklemek istediğinize emin misiniz?", "Çalışan Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Employee employee = new()
                    {
                        FirstName = txtName.Text,
                        LastName = txtSurname.Text,
                        Gender = cmbGender.Text,
                        Salary = Convert.ToDecimal(txtSalary.Text),
                        DateOfBirth = dtpDateOfBirth.Value,
                        HireDate = dtpHireDate.Value,
                        DepartmentID = Guid.TryParse(cmbDepartment.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir departman seçiniz."),
                        PositionID = Guid.TryParse(cmbPosition.SelectedValue?.ToString(), out var posId) ? posId : throw new Exception("Geçerli bir pozisyon seçiniz."),
                        Subordinate = Guid.TryParse(lstÇalışanlar.SelectedValue?.ToString(), out var subId) ? subId : null
                    };
                    _employeeService.Create(employee);
                    FP.FormClear(this);
                    MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }

        private void TxtSubordinate_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(lstÇalışanlar, "ID", null!, FP.EmployeeService?.GetAll()?.Where(x => x.FullName!.Contains(txtSubordinate.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
        }

        private void LstÇalışanlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstEmployees.SelectedIndex != -1 && lstEmployees.SelectedItem != null)
                {
                    selectedemployee = (Employee)lstEmployees.SelectedItem;
                    txtName.Text = selectedemployee.FirstName;
                    txtSurname.Text = selectedemployee.LastName;
                    dtpDateOfBirth.Value = selectedemployee.DateOfBirth;
                    dtpHireDate.Value = selectedemployee.HireDate;
                    txtSalary.Text = selectedemployee.Salary.ToString();
                    cmbGender.Text = selectedemployee.Gender;
                    cmbDepartment.SelectedValue = selectedemployee.DepartmentID;
                    cmbPosition.SelectedValue = selectedemployee.PositionID;
                    lstÇalışanlar.SelectedValue = selectedemployee.Subordinate;
                }
            }
            catch { }
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(lstEmployees, "ID", null!, FP.EmployeeService?.GetAll()?.Where(x => x.FullName!.Contains(txtArama.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
        }

        private void BtnCıkar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEmployees.SelectedIndex != -1 && lstEmployees.SelectedItem != null)
                {
                    DialogResult dr = MessageBox.Show($"{lstEmployees.SelectedItem} isimli çalışanı silmek istediğinize emin misiniz?", "Çalışan silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (selectedemployee != null)
                        {
                            FP.EmployeeService?.Delete(selectedemployee.ID);
                            MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetAllEmployeeToList();
                            FP.FormClear(this);
                        }
                    }
                }


            }
            catch (Exception ex)
            {

                FP.ShowError(ex);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEmployees.SelectedIndex != -1)
                {
                    if (lstEmployees.SelectedValue != null)
                    {
                        DialogResult dr = MessageBox.Show($"{lstEmployees?.SelectedItem?.ToString()} isimli çalışanı güncellemek istediğinize emin misiniz?", "Çalışan güncelleme  İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            if (selectedemployee != null)
                            {
                                selectedemployee.FirstName = txtName.Text;
                                selectedemployee.LastName = txtSurname.Text;
                                selectedemployee.DateOfBirth = dtpDateOfBirth.Value;
                                selectedemployee.HireDate = dtpHireDate.Value;
                                selectedemployee.Salary = Convert.ToDecimal(txtSalary.Text);
                                selectedemployee.Gender = cmbGender.Text;
                                selectedemployee.DepartmentID = Guid.TryParse(cmbDepartment.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir departman seçiniz.");
                                selectedemployee.PositionID = Guid.TryParse(cmbPosition.SelectedValue?.ToString(), out var posId) ? posId : throw new Exception("Geçerli bir pozisyon seçiniz.");
                                selectedemployee.Subordinate = Guid.TryParse(lstÇalışanlar.SelectedValue?.ToString(), out var subId) ? subId : null;
                                FP.EmployeeService?.Update(selectedemployee);
                                MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                selectedemployee = null;
                                GetAllEmployeeToList();
                                FP.FormClear(this);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("çalışan ID'si boş!");
                    }
                }
                else
                {
                    MessageBox.Show("Listeden bir çalışan seçiniz!");
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);

            }
        }

        private void GetAllEmployeeToList()
        {
            try
            {
                FP.UpdateListBox(lstÇalışanlar, "ID", null!, FP.EmployeeService?.GetAll()!);
                FP.UpdateListBox(lstEmployees, "ID", "Name", FP.EmployeeService?.GetAll()!, LstEmployees_SelectedIndexChanged!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
    }
}

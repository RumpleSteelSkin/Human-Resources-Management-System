using HRMS.Entities.Models;
using HRMS.UI.Tools;
using System.Data;

namespace HRMS.UI.Forms
{
    public partial class PerformanceReviewForm : Form
    {
        private void GetAllEmployeeAndPerformanceReview()
        {
            try
            {
                FP.UpdateListBox(lstVoterEmployee, "ID", "Name", FP.EmployeeService?.GetAll()!);
                FP.UpdateListBox(puanlst, "ID", null!, FP.PerformanceReviewService?.GetAll()!, Puanlst_SelectedIndexChanged!);
                FP.UpdateListBox(calisanliste, "ID", null!, FP.EmployeeService?.GetAll()!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        PerformanceReview? selectedPerformanceReview;
        public PerformanceReviewForm()
        {
            InitializeComponent();
        }
        private void PerformanceReviewForm_Load(object sender, EventArgs e)
        {
            GetAllEmployeeAndPerformanceReview();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"{calisanliste.SelectedItem?.ToString()} isimli çalışana {puan.Value} puan vermek istediğinize emin misiniz?", "Peformans Değerlendirme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (calisanliste.SelectedIndex != -1 && calisanliste.SelectedItem != null && lstVoterEmployee.SelectedIndex != -1 && lstVoterEmployee.SelectedItem != null)
                    {
                        PerformanceReview performance = new()
                        {
                            EmployeeID = Guid.TryParse(calisanliste.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir çalışan seçiniz."),
                            ReviewID = Guid.TryParse(lstVoterEmployee.SelectedValue?.ToString(), out var voterID) ? voterID : throw new Exception("Geçerli bir oy verici seçiniz."),
                            Score = (int)puan.Value,
                            Comments = yorumtxt.Text,
                            ReviewDate = DateTime.Now,
                        };
                        FP.PerformanceReviewService?.Create(performance);
                        MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FP.FormClear(this);
                        GetAllEmployeeAndPerformanceReview();
                    }
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }

        private void AramaTxt_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(calisanliste, "ID", null!, FP.EmployeeService?.GetAll()?.Where(emp => emp.FullName!.Contains(aramaTxt.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
        }

        private void TxtVoterSearch_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(lstVoterEmployee, "ID", null!, FP.EmployeeService?.GetAll()?.Where(emp => emp.FullName!.Contains(txtVoterSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (puanlst.SelectedIndex != -1 && puanlst.SelectedValue != null)
                {
                    if (selectedPerformanceReview != null)
                    {
                        DialogResult dr = MessageBox.Show($"{puanlst?.SelectedItem?.ToString()} puanı güncellemek istediğinize emin misiniz?", "Puan Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            selectedPerformanceReview.Score = (int)puan.Value;
                            selectedPerformanceReview.Comments = yorumtxt.Text;
                            selectedPerformanceReview.EmployeeID = Guid.TryParse(lstVoterEmployee.SelectedValue?.ToString(), out var votedID) ? votedID : throw new Exception("Geçerli bir puanlanan çalışanı seçiniz.");
                            selectedPerformanceReview.ReviewID = Guid.TryParse(lstVoterEmployee.SelectedValue?.ToString(), out var voterID) ? voterID : throw new Exception("Geçerli bir puanlayan çalışanı seçiniz.");
                            FP.PerformanceReviewService?.Update(selectedPerformanceReview);
                            MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetAllEmployeeAndPerformanceReview();
                            selectedPerformanceReview = null;
                            FP.FormClear(this);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Güncellemek istediğiniz bir performans değerlendirmesini seçiniz...");
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }

        private void Puanlisteara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FP.UpdateListBox(puanlst, "ID", null!, FP.PerformanceReviewService?.GetAll()?.Where(emp => emp.Employee!.FullName!.Contains(puanlisteara.Text, StringComparison.OrdinalIgnoreCase) || emp.Review!.FullName!.Contains(puanlisteara.Text, StringComparison.OrdinalIgnoreCase)).ToList()!, Puanlst_SelectedIndexChanged!);
            }
            catch { }
        }

        private void Puanlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (puanlst.SelectedIndex != -1 && puanlst.SelectedItem != null)
                {
                    selectedPerformanceReview = (PerformanceReview)puanlst.SelectedItem;
                    yorumtxt.Text = selectedPerformanceReview.Comments;
                    lstVoterEmployee.SelectedValue = selectedPerformanceReview.ReviewID;
                    calisanliste.SelectedValue = selectedPerformanceReview.EmployeeID;
                    puan.Value = selectedPerformanceReview.Score;
                }
            }
            catch { }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (puanlst.SelectedIndex != -1 && puanlst.SelectedValue != null)
                {
                    if (selectedPerformanceReview != null)
                    {
                        DialogResult dr = MessageBox.Show($"{puanlst?.SelectedItem?.ToString()} performans değerlendirmesini silmek istediğinize emin misiniz?", "Puan Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            FP.PerformanceReviewService?.Delete(selectedPerformanceReview.ID);
                            MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetAllEmployeeAndPerformanceReview();
                            selectedPerformanceReview = null;
                            FP.FormClear(this);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz bir performans değerlendirmesini seçiniz...");
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
    }
}

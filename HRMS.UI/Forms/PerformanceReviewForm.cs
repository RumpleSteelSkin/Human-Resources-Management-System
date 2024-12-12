using HRMS.Entities.Models;
using HRMS.UI.Tools;
using System.Data;

namespace HRMS.UI.Forms
{
    public partial class PerformanceReviewForm : Form
    {
        public PerformanceReviewForm()
        {
            InitializeComponent();
        }
        private void PerformanceReviewForm_Load(object sender, EventArgs e)
        {
            FP.UpdateListBox(calisanliste, "ID", null!, FP.EmployeeService?.GetAll()!);
            FP.UpdateListBox(lstVoterEmployee, "ID", null!, FP.EmployeeService?.GetAll()!);
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
            FP.UpdateListBox(calisanliste, "ID", null!, FP.EmployeeService?.GetAll()?.Where(emp => emp.FullName!.Contains(aramaTxt.Text,StringComparison.OrdinalIgnoreCase)).ToList()!);
        }

        private void TxtVoterSearch_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(lstVoterEmployee, "ID", null!, FP.EmployeeService?.GetAll()?.Where(emp => emp.FullName!.Contains(txtVoterSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
        }
    }
}

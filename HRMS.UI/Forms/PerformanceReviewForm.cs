using HRMS.Entities.Models;
using HRMS.UI.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.UI.Forms
{
    public partial class PerformanceReviewForm : Form
    {
        public PerformanceReviewForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PerformanceReviewForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"{calisanliste.SelectedItem?.ToString()} isimli çalışana izin talebi eklemek istediğinize emin misiniz?", "İzin Talebi Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (calisanliste.SelectedIndex != -1 && calisanliste.SelectedItem != null)
                    {
                        //string leaveTypeSet = cmbLeaveType.SelectedIndex == 7 ? txtOther.Text : cmbLeaveType.Text;

                        PerformanceReview performance = new()
                        {
                            EmployeeID = Guid.TryParse(calisanliste.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir çalışan seçiniz."),
                            Score = (int) puan.Value,
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

        private void aramaTxt_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(calisanliste, "ID", null, FP.EmployeeService?.GetAll().Where(emp => emp.FullName.Contains(aramaTxt.Text)).ToList());
        }
    }
}

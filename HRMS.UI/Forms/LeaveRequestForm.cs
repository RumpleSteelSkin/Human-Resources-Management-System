using HRMS.Entities.Models;
using HRMS.UI.Tools;
using Microsoft.Data.SqlClient;
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
    public partial class LeaveRequestForm : Form
    {
        public LeaveRequestForm()
        {
            InitializeComponent();

            startDatePicker.ValueChanged += (sender, e) =>
            {
                if (endDatePicker.Value < startDatePicker.Value)
                {
                    MessageBox.Show("Bitiş tarihi, başlangıç tarihinden önce olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    endDatePicker.Value = startDatePicker.Value;
                }
            };

            endDatePicker.ValueChanged += (sender, e) =>
            {
                if (endDatePicker.Value < startDatePicker.Value)
                {
                    MessageBox.Show("Bitiş tarihi, başlangıç tarihinden önce olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    endDatePicker.Value = startDatePicker.Value;
                }
            };
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeaveRequestForm_Load(object sender, EventArgs e)
        {
            yorumtxt.Visible = false;
            yorumlbl.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (izinCombo.SelectedIndex == 7)
            {
                yorumlbl.Visible = true;
                yorumtxt.Visible = true;
            }
            else
            {
                yorumtxt.Visible = false; yorumlbl.Visible = false;

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void yorumlbl_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LeaveRequest leaveRequest = new()
            {
                EmployeeID = Guid.TryParse(calisanlst.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir çalışan seçiniz."),
                StartDate = startDatePicker.Value,
                EndDate = endDatePicker.Value,
                LeaveType = izinCombo.Text,
                LeaveStatus = onayCombo.Text
            };
            FP.LeaveRequestService?.Create(leaveRequest);
        }

        private void calısanlarCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aramaTxt_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(calisanlst, "ID", null, FP.EmployeeService?.GetAll().Where(emp => emp.FullName.Contains(aramaTxt.Text)).ToList());
            //calisanlst.ValueMember = "ID"; 
            //calisanlst.DataSource = FP.EmployeeService?.GetAll().Where(emp => emp.FullName.Contains(aramaTxt.Text)).ToList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FP.UpdateListBox(izinLst, "ID", null, FP.LeaveRequestService?.GetAll());
        }
    }
}

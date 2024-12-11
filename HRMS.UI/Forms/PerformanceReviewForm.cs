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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(calisanliste, "ID", null, FP.EmployeeService?.GetAll().Where(emp => emp.FullName.Contains(aramaTxt.Text)).ToList());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

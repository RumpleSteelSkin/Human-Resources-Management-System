using HRMS.Business.Services;
using HRMS.DataAccess.Context;
using HRMS.DataAccess.Repositories;
using HRMS.Entities.Models;

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

        Employee? selectedemployee;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var context = new ADBContext();
            var employees = context.Employees.ToList();


        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new()
                {
                    FirstName = txtName.Text,
                    LastName = txtSurname.Text,
                    Gender = cmbGender.Text,
                    Salary = Convert.ToDecimal(txtSalary.Text),
                    DateOfBirth = dtpDateOfBirth.Value,
                    HireDate = dtpHireDate.Value,
                    TerminationDate = dtpTerminationDate.Value,
                    //DepartmentID = Guid.TryParse(cmbDepartment.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir departman seçiniz."),
                };
               
                if (cmbDepartment.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir departman seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                if (cmbPosition.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir pozisyon seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                
                _employeeService.Create(employee);
                MessageBox.Show("kayıt basarılı");
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

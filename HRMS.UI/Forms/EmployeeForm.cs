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
            FP.UpdateListBox(lstÇalışanlar, "ID", null!, FP.EmployeeService?.GetAll()!);
            FP.UpdateComboBox(cmbDepartment, "ID", "Name", FP.DepartmentService?.GetAll()!);
            FP.UpdateComboBox(cmbPosition, "ID", "Name", FP.PositionService?.GetAll()!);
            FP.UpdateListBox(lstEmployees, "ID", null!, FP.EmployeeService?.GetAll()!);
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
                    DepartmentID = Guid.TryParse(cmbDepartment.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir departman seçiniz."),
                    PositionID = Guid.TryParse(cmbPosition.SelectedValue?.ToString(), out var posId) ? posId : throw new Exception("Geçerli bir pozisyon seçiniz."),
                    Subordinate = Guid.TryParse(lstÇalışanlar.SelectedValue?.ToString(), out var subId) ? subId : throw new Exception("Geçerli bir ast seçiniz."),
                };



                _employeeService.Create(employee);
                FP.FormClear(this);
                MessageBox.Show("kayıt basarılı");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtSubordinate_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(lstÇalışanlar, "ID", null!, FP.EmployeeService?.GetAll()?.Where(x => x.FullName!.Contains(txtSubordinate.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
        }

        private void lstÇalışanlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(lstEmployees, "ID", null!, FP.EmployeeService?.GetAll()?.Where(x => x.FullName!.Contains(txtArama.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
        }

        private void btnCıkar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEmployees.SelectedIndex != -1 && lstEmployees.SelectedItem != null)
                {
                    DialogResult dr = MessageBox.Show($"{lstEmployees.SelectedItem.ToString()} isimli çalışanı silmek istediğinize emin misiniz?", "çalışan silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        FP.EmployeeService?.Delete(Guid.TryParse(lstEmployees.SelectedValue?.ToString(), out var empID) ? empID : throw new Exception("Geçerli bir çalışan seçiniz."));
                        MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (Exception ex)
            {

                FP.ShowError(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEmployees.SelectedIndex != -1)
                {
                    if (lstEmployees.SelectedValue != null)
                    {
                        DialogResult dr = MessageBox.Show($"{lstEmployees?.SelectedItem?.ToString()} isimli çalışanı güncellemek istediğinize emin misiniz?", "çalışan güncelleme  İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            FP.EmployeeService?.Delete(Guid.TryParse(lstEmployees?.SelectedValue?.ToString(), out var empID) ? empID : throw new Exception("Geçerli bir çalışan seçiniz."));
                            selectedemployee = null;
                            MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetAllEmployeeToList();
                            FP.FormClear(this);
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
                FP.UpdateListBox(lstEmployees, "ID", "Name", FP.EmployeeService?.GetAll()!, lstEmployees_SelectedIndexChanged!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
    }
}

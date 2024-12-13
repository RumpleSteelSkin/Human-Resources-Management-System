using HRMS.Entities.Models;
using HRMS.UI.Tools;
using System.Data;

namespace HRMS.UI.Forms
{
    public partial class LeaveRequestForm : Form
    {
        public LeaveRequestForm()
        {
            InitializeComponent();
            dtEndDate.ValueChanged += (sender, e) =>
            {
                if (dtEndDate.Value < dtStartDate.Value)
                {
                    MessageBox.Show("Bitiş tarihi, başlangıç tarihinden önce olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }
        #region GLOBALS
        LeaveRequest? selectedLeaveRequest;
        #endregion
        #region METHODS
        private void GetAllEmployeeAndLeaveRequestToList()
        {
            try
            {
                FP.UpdateListBox(lstEmployees, "ID", "Name", FP.EmployeeService?.GetAll()!);
                FP.UpdateListBox(lstLeaveRequest, "ID", null!, FP.LeaveRequestService?.GetAll()!, LstLeaveRequest_SelectedIndexChanged!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        #endregion
        #region EVENTS
        private void LeaveRequestForm_Load(object sender, EventArgs e)
        {
            GetAllEmployeeAndLeaveRequestToList();
            txtOther.Visible = false;
            lblOther.Visible = false;
            pBottomTab.Location = new Point(10, lblOther.Location.Y);
        }
        private void CmbLeaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLeaveType.SelectedIndex == 7)
            {
                lblOther.Visible = true;
                txtOther.Visible = true;
                pBottomTab.Location = new Point(10, 593);
            }
            else
            {
                txtOther.Visible = false;
                lblOther.Visible = false;
                pBottomTab.Location = new Point(10, lblOther.Location.Y);
            }
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(lstEmployees, "ID", null!, FP.EmployeeService?.GetAll()?.Where(emp => emp.FullName!.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
        }
        private void BtnSaveLeaveRequest_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"{lstEmployees.SelectedItem?.ToString()} isimli çalışana izin talebi eklemek istediğinize emin misiniz?", "İzin Talebi Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (lstEmployees.SelectedIndex != -1 && lstEmployees.SelectedItem != null)
                    {
                        string leaveTypeSet = cmbLeaveType.SelectedIndex == 7 ? txtOther.Text : cmbLeaveType.Text;

                        LeaveRequest leaveRequest = new()
                        {
                            EmployeeID = Guid.TryParse(lstEmployees.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir çalışan seçiniz."),
                            StartDate = dtStartDate.Value,
                            EndDate = dtEndDate.Value,
                            LeaveType = leaveTypeSet,
                            LeaveStatus = cmbLeaveStatus.Text
                        };
                        FP.LeaveRequestService?.Create(leaveRequest);
                        MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void TxtSearchLeaveRequest_TextChanged(object sender, EventArgs e)
        {
            FP.UpdateListBox(lstLeaveRequest, "ID", null!, FP.LeaveRequestService?.GetAll()?.Where(emp => emp.Employee!.FullName!.Contains(txtSearchLeaveRequest.Text, StringComparison.OrdinalIgnoreCase)).ToList()!, LstLeaveRequest_SelectedIndexChanged!);
        }
        private void BtnUpdateLeaveRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstLeaveRequest.SelectedIndex != -1 && lstLeaveRequest.SelectedValue != null)
                {
                    if (selectedLeaveRequest != null)
                    {
                        DialogResult dr = MessageBox.Show($"{lstLeaveRequest?.SelectedItem?.ToString()} izin talebini güncellemek istediğinize emin misiniz?", "İzin Talebi Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            string leaveTypeSet = cmbLeaveType.SelectedIndex == 7 ? txtOther.Text : cmbLeaveType.Text;
                            selectedLeaveRequest.StartDate = dtStartDate.Value;
                            selectedLeaveRequest.EndDate = dtEndDate.Value;
                            selectedLeaveRequest.LeaveStatus = cmbLeaveStatus.Text;
                            selectedLeaveRequest.LeaveType = leaveTypeSet;
                            FP.LeaveRequestService?.Update(selectedLeaveRequest);
                            selectedLeaveRequest = null;
                            MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetAllEmployeeAndLeaveRequestToList();
                            FP.FormClear(this);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Güncellemek istediğiniz bir izin talebi seçiniz...");
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void BtnDeleteLeaveRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstLeaveRequest.SelectedIndex != -1 && lstLeaveRequest.SelectedValue != null)
                {

                    DialogResult dr = MessageBox.Show($"{lstLeaveRequest?.SelectedItem?.ToString()} izin talebini silmek istediğinize emin misiniz?", "İzin Talebi Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        FP.LeaveRequestService?.Delete(Guid.TryParse(lstLeaveRequest?.SelectedValue?.ToString(), out var leaveRequestID) ? leaveRequestID : throw new Exception("Geçerli bir izin talebi seçiniz."));
                        selectedLeaveRequest = null;
                        MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllEmployeeAndLeaveRequestToList();
                        FP.FormClear(this);
                    }
                }
                else
                {
                    MessageBox.Show("Listeden bir izin talebi seçiniz!");
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void LstLeaveRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstLeaveRequest.SelectedIndex != -1 && lstLeaveRequest.SelectedItem != null)
                {
                    selectedLeaveRequest = (LeaveRequest)lstLeaveRequest.SelectedItem;
                    int index = cmbLeaveType.FindStringExact(selectedLeaveRequest.LeaveType);
                    if (index >= 0)
                    {
                        cmbLeaveType.Text = selectedLeaveRequest.LeaveType;
                    }
                    else
                    {
                        cmbLeaveType.SelectedIndex = 7;
                        txtOther.Text = selectedLeaveRequest.LeaveType;
                    }
                    lstEmployees.SelectedValue = selectedLeaveRequest.EmployeeID;
                    cmbLeaveStatus.Text = selectedLeaveRequest.LeaveStatus;
                    dtStartDate.Value = selectedLeaveRequest.StartDate;
                    dtEndDate.Value = selectedLeaveRequest.EndDate;
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

using HRMS.Entities.Models;
using HRMS.UI.Tools;

namespace HRMS.UI.Forms
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }
        #region GLOBALS
        Department? selectedDepartment;
        #endregion
        #region METHODS
        private void AddContexMenuStrip()
        {
            ContextMenuStrip cms = new();
            ToolStripMenuItem[] TSMIS =
            [
                new()
                {
                    Image = Bitmap.FromFile(@".\Images\bmp\Update.bmp"),
                    Text = "GÜNCELLE",
                    BackColor = Color.Green,
                    ForeColor = Color.Black
                },
                new()
                {
                    Image = Bitmap.FromFile(@".\Images\bmp\Delete.bmp"),
                    Text = "SİL",
                    BackColor = Color.DarkRed,
                    ForeColor = Color.White
                },
            ];
            TSMIS[0].Click += ProductUpdate;
            TSMIS[1].Click += ProductDelete;
            cms.Items.AddRange(TSMIS);
            cms.ShowImageMargin = true;
            cms.ImageScalingSize = new Size(32, 32);
            cms.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lstDepartmentList.ContextMenuStrip = cms;
        }
        private void GetAllDepartmanToList()
        {
            try
            {
                FP.UpdateListBox(lstDepartmentList, "ID", "Name", FP.DepartmentService?.GetAll()!, LstDepartmentList_SelectedIndexChanged!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        #endregion
        #region EVENTS
        private void ProductDelete(object? sender, EventArgs e)
        {
            try
            {
                if (lstDepartmentList.SelectedIndex != -1)
                {
                    if (lstDepartmentList.SelectedValue != null)
                    {
                        DialogResult dr = MessageBox.Show($"{lstDepartmentList?.SelectedItem?.ToString()} isimli departmanı silmek istediğinize emin misiniz?", "Departman Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            FP.DepartmentService?.Delete(Guid.TryParse(lstDepartmentList?.SelectedValue?.ToString(), out var departmentID) ? departmentID : throw new Exception("Geçerli bir departman seçiniz."));
                            selectedDepartment = null;
                            MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetAllDepartmanToList();
                            FP.FormClear(this);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Departman ID'si boş!");
                    }
                }
                else
                {
                    MessageBox.Show("Listeden bir departman seçiniz!");
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
                MessageBox.Show("Muhtemelen bu departmanın içerisinde aktif çalışanlar bulunmaktadır, Departmanı silmek için çalışanları farklı departmana yönlendirmeniz gerekmektedir.");
            }
        }
        private void ProductUpdate(object? sender, EventArgs e)
        {
            try
            {
                if (lstDepartmentList.SelectedIndex != -1)
                {
                    if (lstDepartmentList.SelectedValue != null)
                    {
                        if (selectedDepartment != null)
                        {
                            DialogResult dr = MessageBox.Show($"{lstDepartmentList?.SelectedItem?.ToString()} isimli departmanı güncellemek istediğinize emin misiniz?", "Departman Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                selectedDepartment.Name = txtDepartmentName.Text;
                                selectedDepartment.Location = txtDepartmentLocation.Text;
                                selectedDepartment.IsActive = chkDepartmentActiveOrPassive.Checked;
                                FP.DepartmentService?.Update(selectedDepartment);
                                selectedDepartment = null;
                                MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetAllDepartmanToList();
                                FP.FormClear(this);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
                MessageBox.Show("Muhtemelen bu departmanın içerisinde aktif çalışanlar bulunmaktadır, Departmanı güncellemek için çalışanları farklı departmana yönlendirmeniz gerekmektedir.");
            }
        }
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            AddContexMenuStrip();
            GetAllDepartmanToList();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FP.UpdateListBox(lstDepartmentList, "ID", "Name", FP.DepartmentService?.GetAll()?.Where(x => x.Name!.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList()!, LstDepartmentList_SelectedIndexChanged!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void ChkDepartmentActiveOrPassive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chkDepartmentActiveOrPassive.Text = chkDepartmentActiveOrPassive.Checked ? "AKTİF" : "PASİF";
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void LstDepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstDepartmentList.SelectedIndex != -1 && lstDepartmentList.SelectedValue != null)
                {
                    selectedDepartment = (Department?)lstDepartmentList.SelectedItem;
                    if (selectedDepartment != null)
                    {
                        txtDepartmentName.Text = selectedDepartment.Name;
                        txtDepartmentLocation.Text = selectedDepartment.Location;
                        chkDepartmentActiveOrPassive.Checked = selectedDepartment.IsActive;
                    }
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"{txtDepartmentName.Text} isimli departmanı eklemek istediğinize emin misiniz?", "Departman Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Department department = new()
                    {
                        Name = txtDepartmentName.Text,
                        Location = txtDepartmentLocation.Text,
                        IsActive = chkDepartmentActiveOrPassive.Checked
                    };
                    FP.DepartmentService?.Create(department);
                    MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllDepartmanToList();
                    FP.FormClear(this);
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

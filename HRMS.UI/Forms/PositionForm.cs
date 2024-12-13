using HRMS.Entities.Models;
using HRMS.UI.Tools;

namespace HRMS.UI.Forms
{
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
        }
        #region GLOBALS
        Position? selectedPosition;
        #endregion
        #region METHODS
        private void AddContextMenuStrip()
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
            TSMIS[0].Click += PositionUpdate;
            TSMIS[1].Click += PositionDelete;
            cms.Items.AddRange(TSMIS);
            cms.ShowImageMargin = true;
            cms.ImageScalingSize = new Size(32, 32);
            cms.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lstPositionList.ContextMenuStrip = cms;
        }
        private void GetAllPositionsToList()
        {
            try
            {
                FP.UpdateListBox(lstPositionList, "ID", "Name", FP.PositionService?.GetAll()!, LstPositionList_SelectedIndexChanged!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        #endregion
        #region EVENTS
        private void PositionDelete(object? sender, EventArgs e)
        {
            try
            {
                if (lstPositionList.SelectedIndex != -1)
                {
                    if (lstPositionList.SelectedValue != null)
                    {
                        DialogResult dr = MessageBox.Show($"{lstPositionList?.SelectedItem?.ToString()} isimli pozisyonu silmek istediğinize emin misiniz?", "Pozisyon Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            Guid positionID = Guid.TryParse(lstPositionList?.SelectedValue?.ToString(), out var posID) ? posID : throw new Exception("Geçerli bir pozisyon seçiniz.");
                            int positionIDInEmployee = FP.EmployeeService!.GetAll()!.Where(x => x.PositionID == positionID).ToList().Count;
                            if (positionIDInEmployee == 0)
                            {
                                FP.PositionService?.Delete(positionID);
                                selectedPosition = null;
                                MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetAllPositionsToList();
                                FP.FormClear(this);
                            }
                            else
                            {
                                throw new Exception("Bu pozisyona bağlı çalışanlar olduğu için silme işlemi yapılamaz.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pozisyon ID'si boş!");
                    }
                }
                else
                {
                    MessageBox.Show("Listeden bir pozisyon seçiniz!");
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
                MessageBox.Show("Muhtemelen bu pozisyon içerisinde aktif çalışanlar bulunmaktadır. Pozisyonu silmek için çalışanları farklı pozisyonlara yönlendirmeniz gerekmektedir.");
            }
        }
        private void PositionUpdate(object? sender, EventArgs e)
        {
            try
            {
                if (lstPositionList.SelectedIndex != -1)
                {
                    if (lstPositionList.SelectedValue != null)
                    {
                        if (selectedPosition != null)
                        {
                            DialogResult dr = MessageBox.Show($"{lstPositionList?.SelectedItem?.ToString()} isimli pozisyonu güncellemek istediğinize emin misiniz?", "Pozisyon Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                selectedPosition.Name = txtPositionName.Text;
                                selectedPosition.Salary = Convert.ToDecimal(txtPositionSalary.Text);
                                selectedPosition.IsActive = chkPositionActiveOrPassive.Checked;
                                FP.PositionService?.Update(selectedPosition);
                                selectedPosition = null;
                                MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetAllPositionsToList();
                                FP.FormClear(this);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void ChkPositionActiveOrPassive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chkPositionActiveOrPassive.Text = chkPositionActiveOrPassive.Checked ? "AKTİF" : "PASİF";
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void LstPositionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstPositionList.SelectedIndex != -1 && lstPositionList.SelectedValue != null)
                {
                    selectedPosition = (Position?)lstPositionList.SelectedItem;
                    if (selectedPosition != null)
                    {
                        txtPositionName.Text = selectedPosition.Name;
                        txtPositionSalary.Text = selectedPosition.Salary.ToString();
                        chkPositionActiveOrPassive.Checked = selectedPosition.IsActive;
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
                DialogResult dr = MessageBox.Show($"{txtPositionName.Text} isimli pozisyonu eklemek istediğinize emin misiniz?", "Pozisyon Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Position position = new()
                    {
                        Name = txtPositionName.Text,
                        Salary = Convert.ToDecimal(txtPositionSalary.Text),
                        IsActive = chkPositionActiveOrPassive.Checked
                    };
                    FP.PositionService?.Create(position);
                    MessageBox.Show("İşlem Başarılı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllPositionsToList();
                    FP.FormClear(this);
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void PositionForm_Load_1(object sender, EventArgs e)
        {
            AddContextMenuStrip();
            GetAllPositionsToList();
        }
        private void TxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                FP.UpdateListBox(lstPositionList, "ID", "Name", FP.PositionService?.GetAll()?.Where(x => x.Name!.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList()!, LstPositionList_SelectedIndexChanged!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        #endregion
    }
}

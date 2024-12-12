using HRMS.Entities.Models;
using HRMS.UI.Tools;

namespace HRMS.UI.Forms
{
    public partial class TrainingProgramSaveDialog : Form
    {
        public TrainingProgramSaveDialog(Guid trainingProgramID)
        {
            InitializeComponent();
            _tpID = trainingProgramID;
        }
        #region GLOBALS
        private readonly Guid _tpID;
        public List<TrainingProgramEmployee>? trainingProgramEmployees = [];
        #endregion

        #region EVENTS
        private void TrainingProgramSaveDialog_Load(object sender, EventArgs e)
        {
            try
            {
                lstStudents.ValueMember = "ID";
                lstStudents.DisplayMember = "Name";
                FP.UpdateListBox(chkListEmployees, "ID", "FullName", FP.EmployeeService?.GetAll()!);
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void TxtEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FP.UpdateListBox(chkListEmployees, "ID", null!, FP.EmployeeService?.GetAll()?.Where(emp => emp.FullName!.Contains(txtEmployeeSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList()!);
            }
            catch { }
        }
        private void BtnYes_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Listeyi onaylamak istediğinize emin misiniz?", "Eğitim Programı Çalışan Seçimi Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                foreach (Employee item in lstStudents.Items)
                {
                    TrainingProgramEmployee tpe = new()
                    {
                        EmployeeID = item.ID,
                        TrainingProgramID = _tpID
                    };
                    trainingProgramEmployees?.Add(tpe);
                }
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Vazgeçmek istediğinize emin misiniz?", "Eğitim Programı Çalışan Seçimi İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }
        private void BtnProcess_Click(object sender, EventArgs e)
        {
            foreach (Employee item in chkListEmployees.CheckedItems)
            {
                if (lstStudents.Items.Contains(item))
                {
                    MessageBox.Show($"{item} isimli çalışan zaten listede ekli.");
                }
                else
                {
                    lstStudents.Items.Add(item);
                }
            }
        }
        private void LstStudents_DoubleClick(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1 && lstStudents.SelectedItem != null)
            {
                lstStudents.Items.Remove(lstStudents.SelectedItem);
            }
        }
        #endregion
    }
}

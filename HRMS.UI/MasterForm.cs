using HRMS.UI.Forms;
using HRMS.UI.Tools;

namespace HRMS.UI
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem masterMenu = new("��LEMLER");
            ToolStripMenuItem[] childs = [
                new("DEPARTMAN ��LEMLER�", null, new EventHandler(Department_Click!)),
                new("�ALI�AN ��LEMLER�", null, new EventHandler(Employee_Click!)),
                new("�Z�N TALEP ��LEMLER�",null, new EventHandler(LeaveRequest_Click!)),
                new("PERFORMANS DE�ERLEND�RME ��LEMLER�",null,new EventHandler(PerformanceReview_Click!)),
                new("POZ�SYON ��LEMLER�",null,new EventHandler(Position_Click!)),
                new("E��T�M PROGRAMI ��LEMLER�",null,new EventHandler(TrainingProgram_Click!))
            ];
            masterMenu.DropDownItems.AddRange(childs);
            MenuStrip ms = new()
            {
                MdiWindowListItem = masterMenu,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI Black", 15f, FontStyle.Bold)
            };
            ms.Items.Add(masterMenu);
            this.MainMenuStrip = ms;
            this.Controls.Add(ms);
        }
        private void Department_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new DepartmentForm()); }
        private void Employee_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new EmployeeForm()); }
        private void LeaveRequest_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new LeaveRequestForm()); }
        private void PerformanceReview_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new PerformanceReviewForm()); }
        private void Position_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new PositionForm()); }
        private void TrainingProgram_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new TrainingProgramForm()); }
    }
}

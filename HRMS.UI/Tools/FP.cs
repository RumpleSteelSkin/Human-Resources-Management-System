using HRMS.Business.Services;
using HRMS.DataAccess.Context;
using HRMS.DataAccess.Repositories;

namespace HRMS.UI.Tools
{
    public static class FP
    {
        /// <summary>
        /// Belirtilen ListBox'un veri kaynağını (DataSource) günceller ve istenilen özelliklere göre yapılandırır.
        /// Seçilen değeri sıfırlar (SelectedIndex = -1) ve istenirse, SelectedIndexChanged olayını geçici olarak devre dışı bırakıp yeniden ekler.
        /// </summary>
        /// <param name="listBox">Veri kaynağı güncellenecek olan ListBox kontrolü.</param>
        /// <param name="valueMember">ListBox'un ValueMember özelliği olarak ayarlanacak özellik adı.</param>
        /// <param name="displayMember">ListBox'un DisplayMember özelliği olarak ayarlanacak özellik adı.</param>
        /// <param name="dataSource">ListBox için kullanılacak yeni veri kaynağı.</param>
        /// <param name="selectedIndexChangedHandler">Eğer tanımlı ise, SelectedIndexChanged olayını geçici olarak devre dışı bırakıp yeniden eklemek için kullanılacak olay işleyicisi.</param>
        public static void UpdateListBox(ListBox listBox, string valueMember, string displayMember, object dataSource, EventHandler? selectedIndexChangedHandler = null)
        {
            if (selectedIndexChangedHandler != null)
                listBox.SelectedIndexChanged -= selectedIndexChangedHandler;
            listBox.DataSource = null;
            listBox.ValueMember = valueMember;
            listBox.DisplayMember = displayMember;
            listBox.DataSource = dataSource;
            listBox.SelectedIndex = -1;
            if (selectedIndexChangedHandler != null)
                listBox.SelectedIndexChanged += selectedIndexChangedHandler;
        }
        public static void UpdateComboBox(ComboBox comboBox, string valueMember, string displayMember, object dataSource)
        {
            comboBox.DataSource = null;
            comboBox.ValueMember = valueMember;
            comboBox.DisplayMember = displayMember;
            comboBox.DataSource = dataSource;
            comboBox.SelectedIndex = -1;
        }

        /// <summary>
        ///  Formun açık olup olmadığını kontrol ederek belirtilen fMdiParent formun içine fMdiChild açmasını sağlar
        /// </summary>
        public static void FormControlAndOpenInMdi(Form fMdiParent, Form fMdiChild)
        {
            bool isOpen = false;
            fMdiChild.MdiParent = fMdiParent;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == fMdiChild.GetType())
                    isOpen = true;
            }
            if (isOpen)
                MessageBox.Show("Bu Form zaten açık durumda.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                fMdiChild.Show();
        }

        /// <summary>
        ///  Form içerisinde bulunan tüm elementler arasında textbox ve maskedtexboxların içini temizler.
        /// </summary>
        public static void FormClear(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item.TabIndex == 1)
                    item.Focus();
                if (item is TextBox box)
                    box.Clear();
                else if (item is MaskedTextBox mbox)
                    mbox.Clear();
                else if (item is CheckBox cbox)
                    cbox.Checked = false;
                else if (item is ComboBox combo)
                    combo.Text = "";
                else if (item is DateTimePicker dt)
                    dt.Value = DateTime.Now;
                else if (item.Controls.Count > 0)
                    FormClear(item);
            }
        }
        /// <summary>
        ///  Basit hata ekranı gösterici.
        /// </summary>
        public static void ShowError(Exception ex)
        {
            MessageBox.Show($"{ex.Message}\n{ex.InnerException}", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static DepartmentService? _departmentService;
        private static ADBContext? _aDBContext;
        private static EmployeeService? _employeeService;
        private static LeaveRequestService? _leaveRequestService;
        private static PerformanceReviewService? _performanceReviewService;
        private static PositionService? _positionService;
        private static TrainingProgramService? _trainingProgramService;
        //private static TrainingProgramEmployeeService? _trainingProgramEmployeeService;
        public static DepartmentService? DepartmentService { get => _departmentService; }
        public static ADBContext? ADBContext { get => _aDBContext; }
        public static EmployeeService? EmployeeService { get => _employeeService; }
        public static LeaveRequestService? LeaveRequestService { get => _leaveRequestService; }
        public static PerformanceReviewService? PerformanceReviewService { get => _performanceReviewService; }
        public static PositionService? PositionService { get => _positionService; }
        public static TrainingProgramService? TrainingProgramService { get => _trainingProgramService; }
        //public static TrainingProgramEmployeeService? TrainingProgramEmployeeService { get => _trainingProgramEmployeeService; }

        /// <summary>
        ///  Tüm generic servislerin tanımlanması bu metod içerisinde gerçekleşir.
        ///  Bir kere çalıştırılması yeterlidir.
        /// </summary>
        public static void DefineServices()//Program.cs triggers this method
        {
            _aDBContext = new();
            _departmentService = new(new DepartmentRepository(_aDBContext));
            _employeeService = new(new EmployeeRepository(_aDBContext));
            _leaveRequestService = new(new LeaveRequestRepository(_aDBContext));
            _performanceReviewService = new(new PerformanceReviewRepository(_aDBContext));
            _positionService = new(new PositionRepository(_aDBContext));
            _trainingProgramService = new(new TrainingProgramRepository(_aDBContext));
            //_trainingProgramEmployeeService = new(new TrainingProgramEmployeeRepository(_aDBContext));
        }
    }
}

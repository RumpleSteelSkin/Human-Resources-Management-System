using HRMS.Business.Services;
using HRMS.DataAccess.Context;
using HRMS.DataAccess.Repositories;

namespace HRMS.UI.Tools
{
    public static class FP
    {
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

        private static DepartmentService? _departmentService;
        private static ADBContext? _aDBContext;
        private static EmployeeService? _employeeService;
        private static LeaveRequestService? _leaveRequestService;
        //private static PerformanceReviewService? _performanceReviewService;
        private static PositionService? _positionService;
        private static TrainingProgramService? _trainingProgramService;

        public static DepartmentService? DepartmentService { get => _departmentService; }
        public static ADBContext? ADBContext { get => _aDBContext; }
        public static EmployeeService? EmployeeService { get => _employeeService; }
        public static LeaveRequestService? LeaveRequestService { get => _leaveRequestService; }
        //public static PerformanceReviewService? PerformanceReviewService { get => _performanceReviewService; }
        public static PositionService? PositionService { get => _positionService; }
        public static TrainingProgramService? TrainingProgramService { get => _trainingProgramService; }
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
            //_performanceReviewService = new(new PerformanceReviewRepository(_aDBContext));
            _positionService = new(new PositionRepository(_aDBContext));
            _trainingProgramService = new(new TrainingProgramRepository(_aDBContext));
        }
    }
}

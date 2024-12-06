using HRMS.Entities.Models;
using HRMS.UI.Tools;

namespace HRMS.UI.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }
        //Yapılacaklar
        //İleride kullanıcı giriş ekranı lazım olabilir.
        //Employees tablosunda TrainingProgramID sütunu silinmesi lazım, gereksiz.

        private void BtnSampleData_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            List<string> firstNames =
            [
            // Kız İsimleri
            "Ayşe", "Fatma", "Elif", "Zeynep", "Merve", "Esra", "Dilara", "Beyza", "Hatice", "Nisa",
            "Eylül", "Melis", "Seda", "İpek", "Şevval", "Damla", "Havva", "Beril", "Ceren", "Nazlı",
            "Deniz", "Cansu", "Sinem", "Derya", "Ecem",
            // Erkek İsimleri
            "Ahmet", "Mehmet", "Ali", "Mustafa", "Hüseyin", "Yusuf", "Emre", "Burak", "Kerem", "Kaan",
            "Arda", "Mert", "Oğuz", "Tuna", "Berat", "Selim", "Furkan", "Eren", "Ömer", "Can",
            "Enes", "Hakan", "Yunus", "Barış", "Alper"
            ];
            List<string> lastNames =
            [
            "Yılmaz", "Kaya", "Demir", "Çelik", "Şahin", "Aydın", "Öztürk", "Arslan", "Yıldız", "Polat",
            "Ekinci", "Keskin", "Koç", "Çetin", "Aksoy", "Kurt", "Bulut", "Güneş", "Bozkurt", "Aslan",
            "Bayram", "Işık", "Karaca", "Özdemir", "Korkmaz", "Erdoğan", "Uzun", "Yavuz", "Taş", "Koçak",
            "Can", "Doğan", "Sezer", "Toprak", "Şen", "Kaplan", "Erdem", "Çakır", "Ergin", "Ateş",
            "Kılıç", "Altun", "Güler", "Acar", "Özkan", "Kocaman", "Ak", "Gürbüz", "Yüksel", "Sarıkaya"
            ];
            List<string> departmentNames =
            [
            "Bilgi Teknolojileri", "İnsan Kaynakları", "Muhasebe", "Pazarlama", "Satış",
            "Lojistik", "Üretim", "Ar-Ge", "Destek Hizmetleri", "Kalite Kontrol"
            ];
            List<string> positionName = [
            // Bilgi Teknolojileri
            "Yazılım Geliştirici", "Sistem Yöneticisi", "Ağ Uzmanı", "Veri Analisti", "Bilgi Güvenliği Uzmanı",
            "IT Destek Uzmanı", "Web Geliştirici", "Bulut Mühendisi", "Yapay Zeka Uzmanı", "DevOps Mühendisi",
    
            // İnsan Kaynakları
            "İşe Alım Uzmanı", "İK Yöneticisi", "Eğitim ve Gelişim Uzmanı", "Performans Yönetimi Uzmanı", "Bordro Uzmanı",
            "İK Destek Asistanı", "Organizasyonel Gelişim Uzmanı", "Yetenek Yönetimi Uzmanı", "Çalışan İlişkileri Uzmanı",
    
            // Muhasebe
            "Muhasebe Uzmanı", "Mali İşler Müdürü", "Finansal Analist", "Vergi Uzmanı", "Defter Tutma Uzmanı",
            "Muhasebe Denetçisi", "Nakit Akış Uzmanı", "Bütçe Planlama Uzmanı", "Finans Müdürü",
    
            // Pazarlama
            "Dijital Pazarlama Uzmanı", "Marka Yöneticisi", "Reklam Uzmanı", "Pazarlama Stratejisti", "Pazarlama Analisti",
            "Sosyal Medya Uzmanı", "Müşteri Deneyimi Uzmanı", "E-Ticaret Uzmanı", "Pazarlama Müdürü",
    
            // Satış
            "Satış Temsilcisi", "Bölge Satış Yöneticisi", "Müşteri Hizmetleri Uzmanı", "Satış Analisti", "Satış Müdürü",
            "Satış Destek Uzmanı", "Satış Operasyon Uzmanı", "İç Satış Temsilcisi", "Satış Danışmanı",
    
            // Lojistik
            "Lojistik Uzmanı", "Tedarik Zinciri Uzmanı", "Depo Sorumlusu", "Nakliye Koordinatörü", "Lojistik Yöneticisi",
            "Operasyon Planlama Uzmanı", "Stok Yönetimi Uzmanı", "Lojistik Destek Uzmanı", "Sevkiyat Sorumlusu",
    
            // Üretim
            "Üretim Operatörü", "Üretim Planlama Uzmanı", "Üretim Müdürü", "Mühendislik Yöneticisi",
            "Makine Operatörü", "Üretim Süreç Uzmanı", "Üretim Destek Uzmanı", "Teknik Çizim Uzmanı",
    
            // Ar-Ge
            "Araştırma Uzmanı", "Geliştirme Mühendisi", "Ürün Tasarımcısı", "Ar-Ge Yöneticisi", "Patent Uzmanı",
            "Proje Yöneticisi", "Yenilik Uzmanı", "Teknoloji Analisti", "Ar-Ge Teknikeri",
    
            // Destek Hizmetleri
            "Ofis Asistanı", "Müşteri Destek Uzmanı", "Çağrı Merkezi Uzmanı", "Sekreter", "Destek Hizmetleri Yöneticisi",
            "Faturalama Uzmanı", "Posta ve Kargo Sorumlusu", "Telefon Operatörü", "Halkla İlişkiler Uzmanı",
    
            // Kalite Kontrol
            "Kalite Kontrol Uzmanı", "Süreç Denetçisi", "Kalite Güvence Uzmanı", "Test Mühendisi", "Kalite Kontrol Müdürü",
            "Ürün Test Uzmanı", "Kalite Sistem Uzmanı", "Üretim Denetçisi", "Kalite Ölçüm Uzmanı"
            ];

            List<string> leaveTypes = [
            "Yıllık İzin",
            "Hastalık İzni",
            "Doğum İzni",
            "Babalık İzni",
            "Evlilik İzni",
            "Cenaze İzni",
            "Eğitim İzni",
            "Seyahat İzni",
            "Diğer"
            ];

            List<string> leaveStatuses = [
            "Onaylandı",
            "Beklemede",
            "Reddedildi"
            ];

            //▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓Departman ekleme işlemi 10 Adet
            List<Department> departments = [];
            for (int i = 0; i < departmentNames.Count; i++)
            {
                Department dpm = new()
                {
                    Name = departmentNames[i],
                    Location = $"BİNA {rnd.Next(1, 6)} KAT {rnd.Next(1, 6)}"
                };
                departments.Add(dpm);
            }
            foreach (Department item in departments)
            {
                FP.DepartmentService?.Create(item);
            }

            //▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓Pozisyon ekleme işlemi 90 Adet
            List<Position> positions = [];
            for (int i = 0; i < positionName.Count; i++)
            {
                Position pst = new()
                {
                    Name = positionName[i],
                    Salary = rnd.Next(20003, 100000)
                };
                positions.Add(pst);
            }
            foreach (Position item in positions)
            {
                FP.PositionService?.Create(item);
            }

            //▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓Çalışan ekleme işlemi 100 Adet
            List<Employee> employees = [];
            for (int i = 0; i < 100; i++)
            {
                int age = rnd.Next(18, 51);
                int birthYear = DateTime.Now.Year - age;
                int birthMonth = rnd.Next(1, 13);
                int birthDay = rnd.Next(1, DateTime.DaysInMonth(birthYear, birthMonth) + 1);
                Position selectedPosition = positions[rnd.Next(0, positions.Count)];
                Employee emp = new()
                {
                    DateOfBirth = new DateTime(birthYear, birthMonth, birthDay),
                    FirstName = firstNames[rnd.Next(firstNames.Count)],
                    LastName = lastNames[rnd.Next(lastNames.Count)],
                    Gender = rnd.Next(2) == 0 ? "ERKEK" : "KADIN",
                    HireDate = DateTime.Now,
                    Salary = selectedPosition.Salary + rnd.Next(5000),
                    DepartmentID = departments[rnd.Next(0, departments.Count)].ID,
                    PositionID = selectedPosition.ID
                };
                employees.Add(emp);
            }
            foreach (Employee item in employees)
            {
                FP.EmployeeService?.Create(item);
            }

            //▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓İzin talebi ekleme işlemi 50 Adet
            List<LeaveRequest> leaveRequests = [];
            for (int i = 0; i < 50; i++)
            {
                DateTime today = DateTime.Now;
                DateTime startDate = today.AddDays(rnd.Next(-30, 365)); // Bugünden 30 gün önceye kadar ya da 1 yıl sonraya kadar
                // Rastgele izin bitiş tarihi (StartDate'ten 1-15 gün sonrasına kadar)
                DateTime endDate = startDate.AddDays(rnd.Next(1, 16));
                LeaveRequest request = new()
                {
                    LeaveType = leaveTypes[rnd.Next(leaveTypes.Count)],
                    StartDate = startDate,
                    EndDate = endDate,
                    LeaveStatus = leaveStatuses[rnd.Next(leaveStatuses.Count)],
                    EmployeeID = employees[rnd.Next(0, employees.Count)].ID
                };
                leaveRequests.Add(request);
            }
            foreach (LeaveRequest item in leaveRequests)
            {
                FP.LeaveRequestService?.Create(item);
            }
        }
    }
}

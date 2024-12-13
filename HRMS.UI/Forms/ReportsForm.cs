using HRMS.UI.Tools;
using System.Data;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml.Style;
using OfficeOpenXml;

namespace HRMS.UI.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }
        #region GLOBALS
        private Chart? GenderGraphchart;
        private Chart? EmployeesInDepartmentGraphchart;
        private Chart? BirthdaysChartchart;
        private Chart? PerformanceReviewGraphchart;
        private Control? oldParent;
        DataGridView? dgwLR;
        #endregion

        #region EVENTS
        //private void BtnSampleData_Click(object sender, EventArgs e)
        //{
        //    Random rnd = new();
        //    List<string> firstNames =
        //    [
        //    // Kız İsimleri
        //    "Ayşe", "Fatma", "Elif", "Zeynep", "Merve", "Esra", "Dilara", "Beyza", "Hatice", "Nisa",
        //    "Eylül", "Melis", "Seda", "İpek", "Şevval", "Damla", "Havva", "Beril", "Ceren", "Nazlı",
        //    "Deniz", "Cansu", "Sinem", "Derya", "Ecem",
        //    // Erkek İsimleri
        //    "Ahmet", "Mehmet", "Ali", "Mustafa", "Hüseyin", "Yusuf", "Emre", "Burak", "Kerem", "Kaan",
        //    "Arda", "Mert", "Oğuz", "Tuna", "Berat", "Selim", "Furkan", "Eren", "Ömer", "Can",
        //    "Enes", "Hakan", "Yunus", "Barış", "Alper"
        //    ];
        //    List<string> lastNames =
        //    [
        //    "Yılmaz", "Kaya", "Demir", "Çelik", "Şahin", "Aydın", "Öztürk", "Arslan", "Yıldız", "Polat",
        //    "Ekinci", "Keskin", "Koç", "Çetin", "Aksoy", "Kurt", "Bulut", "Güneş", "Bozkurt", "Aslan",
        //    "Bayram", "Işık", "Karaca", "Özdemir", "Korkmaz", "Erdoğan", "Uzun", "Yavuz", "Taş", "Koçak",
        //    "Can", "Doğan", "Sezer", "Toprak", "Şen", "Kaplan", "Erdem", "Çakır", "Ergin", "Ateş",
        //    "Kılıç", "Altun", "Güler", "Acar", "Özkan", "Kocaman", "Ak", "Gürbüz", "Yüksel", "Sarıkaya"
        //    ];
        //    List<string> departmentNames =
        //    [
        //    "Bilgi Teknolojileri", "İnsan Kaynakları", "Muhasebe", "Pazarlama", "Satış",
        //    "Lojistik", "Üretim", "Ar-Ge", "Destek Hizmetleri", "Kalite Kontrol"
        //    ];
        //    List<string> positionName = [
        //    // Bilgi Teknolojileri
        //    "Yazılım Geliştirici", "Sistem Yöneticisi", "Ağ Uzmanı", "Veri Analisti", "Bilgi Güvenliği Uzmanı",
        //    "IT Destek Uzmanı", "Web Geliştirici", "Bulut Mühendisi", "Yapay Zeka Uzmanı", "DevOps Mühendisi",

        //    // İnsan Kaynakları
        //    "İşe Alım Uzmanı", "İK Yöneticisi", "Eğitim ve Gelişim Uzmanı", "Performans Yönetimi Uzmanı", "Bordro Uzmanı",
        //    "İK Destek Asistanı", "Organizasyonel Gelişim Uzmanı", "Yetenek Yönetimi Uzmanı", "Çalışan İlişkileri Uzmanı",

        //    // Muhasebe
        //    "Muhasebe Uzmanı", "Mali İşler Müdürü", "Finansal Analist", "Vergi Uzmanı", "Defter Tutma Uzmanı",
        //    "Muhasebe Denetçisi", "Nakit Akış Uzmanı", "Bütçe Planlama Uzmanı", "Finans Müdürü",

        //    // Pazarlama
        //    "Dijital Pazarlama Uzmanı", "Marka Yöneticisi", "Reklam Uzmanı", "Pazarlama Stratejisti", "Pazarlama Analisti",
        //    "Sosyal Medya Uzmanı", "Müşteri Deneyimi Uzmanı", "E-Ticaret Uzmanı", "Pazarlama Müdürü",

        //    // Satış
        //    "Satış Temsilcisi", "Bölge Satış Yöneticisi", "Müşteri Hizmetleri Uzmanı", "Satış Analisti", "Satış Müdürü",
        //    "Satış Destek Uzmanı", "Satış Operasyon Uzmanı", "İç Satış Temsilcisi", "Satış Danışmanı",

        //    // Lojistik
        //    "Lojistik Uzmanı", "Tedarik Zinciri Uzmanı", "Depo Sorumlusu", "Nakliye Koordinatörü", "Lojistik Yöneticisi",
        //    "Operasyon Planlama Uzmanı", "Stok Yönetimi Uzmanı", "Lojistik Destek Uzmanı", "Sevkiyat Sorumlusu",

        //    // Üretim
        //    "Üretim Operatörü", "Üretim Planlama Uzmanı", "Üretim Müdürü", "Mühendislik Yöneticisi",
        //    "Makine Operatörü", "Üretim Süreç Uzmanı", "Üretim Destek Uzmanı", "Teknik Çizim Uzmanı",

        //    // Ar-Ge
        //    "Araştırma Uzmanı", "Geliştirme Mühendisi", "Ürün Tasarımcısı", "Ar-Ge Yöneticisi", "Patent Uzmanı",
        //    "Proje Yöneticisi", "Yenilik Uzmanı", "Teknoloji Analisti", "Ar-Ge Teknikeri",

        //    // Destek Hizmetleri
        //    "Ofis Asistanı", "Müşteri Destek Uzmanı", "Çağrı Merkezi Uzmanı", "Sekreter", "Destek Hizmetleri Yöneticisi",
        //    "Faturalama Uzmanı", "Posta ve Kargo Sorumlusu", "Telefon Operatörü", "Halkla İlişkiler Uzmanı",

        //    // Kalite Kontrol
        //    "Kalite Kontrol Uzmanı", "Süreç Denetçisi", "Kalite Güvence Uzmanı", "Test Mühendisi", "Kalite Kontrol Müdürü",
        //    "Ürün Test Uzmanı", "Kalite Sistem Uzmanı", "Üretim Denetçisi", "Kalite Ölçüm Uzmanı"
        //    ];

        //    List<string> leaveTypes = [
        //    "Yıllık İzin",
        //    "Hastalık İzni",
        //    "Doğum İzni",
        //    "Babalık İzni",
        //    "Evlilik İzni",
        //    "Cenaze İzni",
        //    "Eğitim İzni",
        //    "Seyahat İzni",
        //    "Diğer"
        //    ];

        //    List<string> leaveStatuses = [
        //    "Onaylandı",
        //    "Beklemede",
        //    "Reddedildi"
        //    ];

        //    //▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓Departman ekleme işlemi 10 Adet
        //    List<Department> departments = [];
        //    for (int i = 0; i < departmentNames.Count; i++)
        //    {
        //        Department dpm = new()
        //        {
        //            Name = departmentNames[i],
        //            Location = $"BİNA {rnd.Next(1, 6)} KAT {rnd.Next(1, 6)}"
        //        };
        //        departments.Add(dpm);
        //    }
        //    foreach (Department item in departments)
        //    {
        //        FP.DepartmentService?.Create(item);
        //    }

        //    //▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓Pozisyon ekleme işlemi 90 Adet
        //    List<Position> positions = [];
        //    for (int i = 0; i < positionName.Count; i++)
        //    {
        //        Position pst = new()
        //        {
        //            Name = positionName[i],
        //            Salary = rnd.Next(20003, 100000)
        //        };
        //        positions.Add(pst);
        //    }
        //    foreach (Position item in positions)
        //    {
        //        FP.PositionService?.Create(item);
        //    }

        //    //▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓Çalışan ekleme işlemi 100 Adet
        //    List<Employee> employees = [];
        //    for (int i = 0; i < 100; i++)
        //    {
        //        int age = rnd.Next(18, 51);
        //        int birthYear = DateTime.Now.Year - age;
        //        int birthMonth = rnd.Next(1, 13);
        //        int birthDay = rnd.Next(1, DateTime.DaysInMonth(birthYear, birthMonth) + 1);
        //        Position selectedPosition = positions[rnd.Next(0, positions.Count)];
        //        Employee emp = new()
        //        {
        //            DateOfBirth = new DateTime(birthYear, birthMonth, birthDay),
        //            FirstName = firstNames[rnd.Next(firstNames.Count)],
        //            LastName = lastNames[rnd.Next(lastNames.Count)],
        //            Gender = rnd.Next(2) == 0 ? "ERKEK" : "KADIN",
        //            HireDate = DateTime.Now,
        //            Salary = selectedPosition.Salary + rnd.Next(5000),
        //            DepartmentID = departments[rnd.Next(0, departments.Count)].ID,
        //            PositionID = selectedPosition.ID
        //        };
        //        employees.Add(emp);
        //    }
        //    foreach (Employee item in employees)
        //    {
        //        FP.EmployeeService?.Create(item);
        //    }

        //    //▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓İzin talebi ekleme işlemi 50 Adet
        //    List<LeaveRequest> leaveRequests = [];
        //    for (int i = 0; i < 50; i++)
        //    {
        //        DateTime today = DateTime.Now;
        //        DateTime startDate = today.AddDays(rnd.Next(-30, 365)); // Bugünden 30 gün önceye kadar ya da 1 yıl sonraya kadar
        //        // Rastgele izin bitiş tarihi (StartDate'ten 1-30 gün sonrasına kadar)
        //        DateTime endDate = startDate.AddDays(rnd.Next(1, 30));
        //        LeaveRequest request = new()
        //        {
        //            LeaveType = leaveTypes[rnd.Next(leaveTypes.Count)],
        //            StartDate = startDate,
        //            EndDate = endDate,
        //            LeaveStatus = leaveStatuses[rnd.Next(leaveStatuses.Count)],
        //            EmployeeID = employees[rnd.Next(0, employees.Count)].ID
        //        };
        //        leaveRequests.Add(request);
        //    }
        //    foreach (LeaveRequest item in leaveRequests)
        //    {
        //        FP.LeaveRequestService?.Create(item);
        //    }


        //    //▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓Eğitim programı ekleme işlemi 5 Adet
        //    List<TrainingProgram> trainingPrograms = [];
        //    for (int i = 1; i < 6; i++)//5 Adet eğitim için döngü
        //    {
        //        List<TrainingProgramEmployee> trainingProgramEmployees = [];//Ara tablo için liste
        //        TrainingProgram tp = new()
        //        {
        //            Name = $"Eğitim {i}",//Rastgele eğitim ismi atama
        //            Description = "Eğitim Yapılcak",
        //            StartDate = DateTime.Now,
        //            EndDate = DateTime.Now,
        //            TrainerID = employees[rnd.Next(0, employees.Count)].ID,//Rastgele eğitim veren çalışan
        //        };

        //        for (int j = (i * 10) - 10; j < i * 10; j++)//Her eğitimde 10 adet eğitim alan çalışan girdisi için döngü
        //        {
        //            TrainingProgramEmployee tpe = new()
        //            {
        //                TrainingProgramID = tp.ID,//*Yeni açılan eğitim programının IDsi
        //                EmployeeID = employees[j].ID//*Eğitim programına eklenecek eğitimi alan çalışan IDsi
        //            };
        //            trainingProgramEmployees.Add(tpe);//Ara tabloya listesine ekle.
        //        }
        //        tp.TrainingProgramEmployees = trainingProgramEmployees;//Eklenen ara tabloyu eğitim programına tanımla.
        //        trainingPrograms.Add(tp);//Oluşturulan eğitim programını listeye ekle
        //    }
        //    foreach (TrainingProgram item in trainingPrograms)//Herşeyin sonunda eğitim programı Listesini döndür
        //    {
        //        FP.TrainingProgramService?.Create(item);//Dönen her eğitim programını sql'e gönder
        //        //EF Core otomatik olarak ara tabloyu dolduracaktır.
        //    }

        //    //▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓Performans değerlendirmesi ekleme işlemi 100 Adet
        //    List<PerformanceReview> performanceReviews = [];
        //    for (int i = 0; i < 100; i++)
        //    {
        //        PerformanceReview pr = new()
        //        {
        //            Score = rnd.Next(0, 100),
        //            Comments = "YORUM " + i,
        //            EmployeeID = employees[i].ID,
        //            ReviewID = employees[rnd.Next(0, employees.Count)].ID,
        //            ReviewDate = DateTime.Now
        //        };
        //        performanceReviews.Add(pr);
        //    }
        //    foreach (PerformanceReview item in performanceReviews)
        //    {
        //        FP.PerformanceReviewService?.Create(item);
        //    }
        //}
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            GenderGraph();
            EmployeesInDepartmentGraph();
            GeneralConditionInfos();
            LeaveRequestGraph();
            BirthdaysChart();
            PerformanceReviewGraph();
        }
        private void AllGraphZoom_DoubleClick(object sender, EventArgs e)
        {
            var chart = (Chart)sender;
            if (chart.Parent != pAllGraph)
            {
                oldParent = chart.Parent;
                pAllGraph.Controls.Add(chart);
                chart.Dock = DockStyle.Fill;
                chart.BringToFront();
            }
            else
            {
                oldParent?.Controls.Add(chart);
                chart.BringToFront();
            }
        }
        private void BtnExportPDF_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar (*.*)|*.*";
            saveFileDialog.Title = "PDF Olarak Kaydet";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
                CreatePdf(saveFileDialog.FileName);
        }
        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Excel Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar (*.*)|*.*";
            saveFileDialog.Title = "Excel Olarak Kaydet";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                // Call the method to create the Excel file
                CreateExcel(saveFileDialog.FileName);
            }
        }
        #endregion

        #region METHODS
        private void GeneralConditionInfos()
        {
            var sumEmployees = FP.EmployeeService?.GetAll()?.Count();
            var sumSalary = FP.EmployeeService?.GetAll()?.Sum(x => x.Salary);
            CultureInfo trCulture = new("tr-TR");
            lblGeneralCondition.Text =
                $"ÇALIŞAN SAYISI\n{sumEmployees}\n" +
                $"ORTALAMA MAAŞ\n{String.Format(trCulture, "{0:C}", (sumSalary / sumEmployees))}\n" +
                $"TOPLAM MAAŞ\n{String.Format(trCulture, "{0:C}", sumSalary)}";

            lblGeneralCondition.BackColor = Color.White;
            lblGeneralCondition.ForeColor = Color.Black;
        }
        private void GenderGraph()
        {
            GenderGraphchart = new()
            {
                Dock = DockStyle.Fill
            };
            lblGenderGraph.Controls.Add(GenderGraphchart);
            GenderGraphchart.DoubleClick += AllGraphZoom_DoubleClick!;
            ChartArea chartArea = new("MainArea");
            GenderGraphchart.ChartAreas.Add(chartArea);

            Series series = new("GenderGraph")
            {
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };
            GenderGraphchart.Series.Add(series);

            var genderCounts = FP.EmployeeService?.GetAll()
                ?.GroupBy(x => x.Gender)
                ?.Select(g => new { Gender = g.Key, Count = g.Count() })
                ?.ToList();

            if (genderCounts != null)
            {
                foreach (var genderCount in genderCounts)
                {
                    series.Points.Add(new DataPoint(0, genderCount.Count)
                    {
                        LegendText = genderCount.Gender,
                        Label = $"{genderCount.Gender}: {genderCount.Count}"
                    });
                }
            }

            GenderGraphchart.Titles.Add("Cinsiyet Grafiği");
        }
        private void EmployeesInDepartmentGraph()
        {
            EmployeesInDepartmentGraphchart = new()
            {
                Dock = DockStyle.Fill
            };
            lblEmployeesInDepartments.Controls.Add(EmployeesInDepartmentGraphchart);
            EmployeesInDepartmentGraphchart.DoubleClick += AllGraphZoom_DoubleClick!;
            ChartArea chartArea = new("MainArea");
            EmployeesInDepartmentGraphchart.ChartAreas.Add(chartArea);

            Series series = new("EmployeesInDepartmentGraph")
            {
                IsXValueIndexed = true,
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Doughnut
            };
            EmployeesInDepartmentGraphchart.Series.Add(series);

            var employees = FP.EmployeeService?.GetAll();
            var departments = FP.DepartmentService?.GetAll();
            if (departments != null)
            {
                var employeesInDepartmentData = employees
                ?.Join(departments,
                       ex => ex.DepartmentID,
                       d => d.ID,
                       (ex, d) => new { ex, d.Name })
                .GroupBy(x => x.Name)
                .Select(g => new { DepartmentName = g.Key, Count = g.Count() })
                .ToList();
                if (employeesInDepartmentData != null)
                {
                    byte i = 0;
                    foreach (var employeesInDepartment in employeesInDepartmentData)
                    {
                        series.Points.Add(new DataPoint(i, employeesInDepartment.Count)
                        {
                            LegendText = employeesInDepartment.DepartmentName,
                            Label = $"{employeesInDepartment.DepartmentName}: {employeesInDepartment.Count}"
                        });
                        i += 1;
                    }
                }
            }
            EmployeesInDepartmentGraphchart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            EmployeesInDepartmentGraphchart.Titles.Add("Departman İçerisinde Çalışanlar Grafiği");
        }
        private void BirthdaysChart()
        {
            var today = DateTime.Now.Date;
            var employeesWithRemainingDays = FP.EmployeeService?.GetAll()?
                .Select(ez => new
                {
                    EmployeeName = ez.FirstName + " " + ez.LastName,
                    RemainingDays = (int)(ez.DateOfBirth.AddYears(
                        ez.DateOfBirth.Month > today.Month ||
                        (ez.DateOfBirth.Month == today.Month && ez.DateOfBirth.Day >= today.Day)
                        ? today.Year - ez.DateOfBirth.Year
                        : today.Year - ez.DateOfBirth.Year + 1) - today).TotalDays
                })
                .OrderByDescending(x => x.RemainingDays).Where(x => x.RemainingDays < 31)
                .ToList();

            BirthdaysChartchart = new()
            {
                Dock = DockStyle.Fill
            };
            lblEmployeeDateOfBirth.Controls.Add(BirthdaysChartchart);
            BirthdaysChartchart.DoubleClick += AllGraphZoom_DoubleClick!;
            ChartArea chartArea = new("MainArea");
            BirthdaysChartchart.ChartAreas.Add(chartArea);

            Series series = new("Birthdays")
            {
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Bar
            };
            BirthdaysChartchart.Series.Add(series);
            if (employeesWithRemainingDays != null)
            {
                int i = 0;
                foreach (var employee in employeesWithRemainingDays)
                {
                    series.Points.Add(new DataPoint(i, employee.RemainingDays)
                    {
                        LegendText = employee.EmployeeName,
                        Label = $"{employee.EmployeeName}: {employee.RemainingDays}"
                    });
                    i += 1;
                }
                BirthdaysChartchart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                BirthdaysChartchart.Titles.Add("Doğum Günlerine Kalan Gün Sayısı");
            }
        }
        private void PerformanceReviewGraph()
        {
            var performanceReview = FP.PerformanceReviewService?.GetAll()?
                .Join(FP.EmployeeService?.GetAll()!, x => x.EmployeeID, y => y.ID, (x, y) => new { x, y.FullName })
                .Select(g => new { g.FullName, g.x.Score })
                .OrderByDescending(h => h.Score).Take(10).OrderBy(h => h.Score).ToList();
            PerformanceReviewGraphchart = new()
            {
                Dock = DockStyle.Fill
            };
            lblPerformanceReview.Controls.Add(PerformanceReviewGraphchart);
            PerformanceReviewGraphchart.DoubleClick += AllGraphZoom_DoubleClick!;
            ChartArea chartArea = new("MainArea");
            PerformanceReviewGraphchart.ChartAreas.Add(chartArea);

            Series series = new("PerformanceReview")
            {
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Bar
            };
            PerformanceReviewGraphchart.Series.Add(series);

            if (performanceReview != null)
            {
                int i = 0;
                foreach (var pR in performanceReview)
                {
                    series.Points.Add(new DataPoint(i, pR.Score)
                    {
                        LegendText = pR.FullName,
                        Label = $"{pR.FullName}: {pR.Score}"
                    });
                    i += 1;
                }
            }
            PerformanceReviewGraphchart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            PerformanceReviewGraphchart.Titles.Add("Performans Değerlendirmeleri");
        }
        private void LeaveRequestGraph()
        {
            dgwLR = new()
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                DataSource = null
            };
            lblLeaveRequestTypeGraph.Controls.Add(dgwLR);
            var LeaveRequest = FP.LeaveRequestService?.GetAll()?
                .Where(x => x.StartDate <= DateTime.Now && x.EndDate >= DateTime.Now && (x.LeaveStatus == "Onaylandı " || x.LeaveStatus == "Onaylandı"))
                .Join(FP.EmployeeService?.GetAll()!, ex => ex.EmployeeID, d => d.ID, (ex, d) => new { ex, d.FullName })
                .Select(x => new { x.FullName, x.ex.StartDate, x.ex.EndDate }).ToList();
            dgwLR.DataSource = LeaveRequest;
        }
        private void CreatePdf(string outputFilePath)
        {
            Document doc = new();
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(outputFilePath, FileMode.Create));
                doc.Open();
                iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font titleFont = new(STF_Helvetica_Turkish, 20, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font normalFont = new(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);

                Paragraph title = new("GENEL ŞİRKET DURUM", titleFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(title);

                var sumEmployees = FP.EmployeeService?.GetAll()?.Count();
                var sumSalary = FP.EmployeeService?.GetAll()?.Sum(x => x.Salary);
                CultureInfo trCulture = new("tr-TR");
                Paragraph normalText = new($"\nŞirket içerisindeki varlıkların genel durumu;\nŞirkette {sumEmployees} çalışan bulunmaktadır.\nŞirketin çalışanlara sağladığı ortalama maaş: {String.Format(trCulture, "{0:C}", (sumSalary / sumEmployees))}TL\nŞirketin çalışanlara ödediği toplam maaş: {String.Format(trCulture, "{0:C}", sumSalary)}TL\n\n", normalFont)
                {
                    Alignment = Element.ALIGN_LEFT
                };
                doc.Add(normalText);

                PdfPTable table = new(2);
                for (int i = 1; i < 5; i++)
                {
                    var chartImage = new MemoryStream();
                    switch (i)
                    {
                        case 1:
                            EmployeesInDepartmentGraphchart?.SaveImage(chartImage, ChartImageFormat.Png);
                            break;
                        case 2:
                            GenderGraphchart?.SaveImage(chartImage, ChartImageFormat.Png);
                            break;
                        case 3:
                            BirthdaysChartchart?.SaveImage(chartImage, ChartImageFormat.Png);
                            break;
                        case 4:
                            PerformanceReviewGraphchart?.SaveImage(chartImage, ChartImageFormat.Png);
                            break;
                        default:
                            break;
                    }
                    iTextSharp.text.Image chart_Image = iTextSharp.text.Image.GetInstance(chartImage.GetBuffer());
                    chart_Image.ScalePercent(50f);
                    PdfPCell cell = new(chart_Image)
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_MIDDLE,
                        Border = iTextSharp.text.Rectangle.NO_BORDER
                    };
                    table.AddCell(cell);
                }
                doc.Add(table);

                normalText = new("\nİZİNDE OLAN ÇALIŞANLAR\n\n", normalFont);
                doc.Add(normalText);

                if (dgwLR != null)
                {
                    PdfPTable pdfTable = new(dgwLR.Columns.Count)
                    {
                        WidthPercentage = 100
                    };

                    foreach (DataGridViewColumn column in dgwLR.Columns)
                    {
                        PdfPCell cell = new(new Phrase(column.HeaderText))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY
                        };
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dgwLR.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                            }
                        }
                    }
                    doc.Add(pdfTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata meydana geldi: {ex.Message}");
            }
            finally
            {
                doc.Close();
            }
        }
        private void CreateExcel(string outputFilePath)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using var package = new ExcelPackage();
                var worksheet = package.Workbook.Worksheets.Add("Şirket Durumu");

                worksheet.Cells[1, 1].Value = "GENEL ŞİRKET DURUM";
                worksheet.Cells[1, 1].Style.Font.Size = 20;
                worksheet.Cells[1, 1].Style.Font.Bold = true;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                var sumEmployees = FP.EmployeeService?.GetAll()?.Count();
                var sumSalary = FP.EmployeeService?.GetAll()?.Sum(x => x.Salary);
                CultureInfo trCulture = new("tr-TR");

                worksheet.Cells[3, 1].Value = "Şirket içerisindeki varlıkların genel durumu;";
                worksheet.Cells[4, 1].Value = $"Şirkette {sumEmployees} çalışan bulunmaktadır.";
                worksheet.Cells[5, 1].Value = $"Şirketin çalışanlara sağladığı ortalama maaş: {string.Format(trCulture, "{0:C}", (sumSalary / sumEmployees))} TL";
                worksheet.Cells[6, 1].Value = $"Şirketin çalışanlara ödediği toplam maaş: {string.Format(trCulture, "{0:C}", sumSalary)} TL";

                // Resimleri yan yana eklemek için X konumunu değiştireceğiz
                int imageStartRow = 8; // Resimlerin yerleştirileceği satır
                for (int i = 1; i < 5; i++)
                {
                    var chartImage = new MemoryStream();
                    switch (i)
                    {
                        case 1:
                            EmployeesInDepartmentGraphchart?.SaveImage(chartImage, ChartImageFormat.Png);
                            break;
                        case 2:
                            GenderGraphchart?.SaveImage(chartImage, ChartImageFormat.Png);
                            break;
                        case 3:
                            BirthdaysChartchart?.SaveImage(chartImage, ChartImageFormat.Png);
                            break;
                        case 4:
                            PerformanceReviewGraphchart?.SaveImage(chartImage, ChartImageFormat.Png);
                            break;
                        default:
                            break;
                    }

                    var image = worksheet.Drawings.AddPicture($"Chart{i}", chartImage);

                    image.SetPosition(imageStartRow, 0, (i * 7) - 7, 0);
                }

                worksheet.Cells[24, 1].Value = "İZİNDE OLAN ÇALIŞANLAR";
                worksheet.Cells[24, 1].Style.Font.Bold = true;

                if (dgwLR != null)
                {
                    int startRow = 25;
                    for (int i = 0; i < dgwLR.Columns.Count; i++)
                    {
                        worksheet.Cells[startRow, i + 1].Value = dgwLR.Columns[i].HeaderText;
                        worksheet.Cells[startRow, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[startRow, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    startRow++;
                    foreach (DataGridViewRow row in dgwLR.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                worksheet.Cells[startRow, i + 1].Value = row.Cells[i].Value?.ToString() ?? string.Empty;
                            }
                            startRow++;
                        }
                    }
                }

                worksheet.Cells.AutoFitColumns();
                FileInfo excelFile = new(outputFilePath);
                package.SaveAs(excelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata meydana geldi: {ex.Message}");
            }

        }

        #endregion
    }
}

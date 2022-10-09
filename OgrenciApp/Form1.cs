using OgrenciApp.Repositories;
using OgrenciApp.Repositories.Bases;
using OgrenciApp.Services;

namespace OgrenciApp
{
    public partial class Form1 : Form
    {
        OgrenciService _ogrenciService;
        IRepositoryBase _repository;
        string _path = Application.StartupPath.Replace(@"bin\Debug\net6.0-windows", "Files") + "\\Öğrenciler.txt";
        public Form1()
        {
            _repository = new FileReporisotory(_path);
            _ogrenciService = new OgrenciService(_repository);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Getir();
        }

        private void Getir()
        {
            dataGridView1.DataSource = _ogrenciService.OgrencileriGetir();
            dataGridView1.ClearSelection();
        }
    }
}
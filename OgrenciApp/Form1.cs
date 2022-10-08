using OgrenciApp.Repositories;
using OgrenciApp.Services;

namespace OgrenciApp
{
    public partial class Form1 : Form
    {
        OgrenciService _ogrenciService;
        public Form1()
        {
            _ogrenciService = new OgrenciService(new MemoriyRepository());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Getir();
        }

        private void Getir()
        {
            dataGridView1.DataSource = _ogrenciService.OgrencileriGetir();
        }
    }
}
using OgrenciApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace OgrenciApp.Data
{
    public static class OgrenciData
    {
        public static Ogrenci[] Ogrenciler { get; set; }
        static OgrenciData()
        {
            //String.x = "x";
            //x.Trim(); //string classındaki method

            //string.IsNullOrWhiteSpace(" ")
            Ogrenciler = new Ogrenci[]
                {
                            new Ogrenci()
                    {
                        Id = 1,
                        Adi = "Mehmet",
                        Soyadi = "Anaç"
                    },
                    new Ogrenci()
                    {
                        Id = 2,
                        Adi = "Mehmet2",
                        Soyadi = "Anaç2"
                    },
                    new Ogrenci()
                    {
                        Id = 3,
                        Adi = "Mehmet3",
                        Soyadi = "Anaç3"
                    }
                };

        }

    }
}

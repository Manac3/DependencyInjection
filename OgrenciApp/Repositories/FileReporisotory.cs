using OgrenciApp.Models;
using OgrenciApp.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciApp.Repositories
{
    public class FileReporisotory : IRepositoryBase
    {
        private readonly string _path;
        const char _seperator = '~';

        public FileReporisotory(string path)
        {
            _path = path;
        }

        public Ogrenci[] Getir()
        {
            string[] lines = File.ReadAllLines(_path, Encoding.UTF8);
            Ogrenci[] ogrenciler = new Ogrenci[lines.Length];
            string[] lineItems;
            for (int i = 0; i < lines.Length; i++)
            {
               lineItems = lines[i].Split(_seperator); //_seperatoru yukarda tanımladık güzel oldu 
                ogrenciler[i] = new Ogrenci()

                {
                    Id = int.Parse(lineItems[0]),
                    Adi = lineItems[1],
                    Soyadi = lineItems[2]
                };
                
            }
            return ogrenciler;
        }

        public Ogrenci Getir(int index)
        {
            throw new NotImplementedException();
        }
    }
}

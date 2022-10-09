using OgrenciApp.Data;
using OgrenciApp.Models;
using OgrenciApp.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciApp.Repositories
{
    public class MemoriyRepository : IRepositoryBase

    {
        public Ogrenci[] Getir()
        {
            return OgrenciData.Ogrenciler;
        }
        public Ogrenci Getir(int index)
        {
            return OgrenciData.Ogrenciler[index];
        }
    }
}

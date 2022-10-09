using OgrenciApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciApp.Repositories.Bases
{
    public interface IRepositoryBase
    {
        Ogrenci[] Getir();
        Ogrenci Getir(int index);
    }
}

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

        public FileReporisotory(string path)
        {
            _path = path;
        }

        public Ogrenci[] Getir()
        {
            File.ReadAllLines(_path, Encoding.UTF8);
        }
    }
}

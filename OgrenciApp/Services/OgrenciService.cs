using OgrenciApp.Models;
using OgrenciApp.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciApp.Services
{
    public class OgrenciService
    {
        private readonly IRepositoryBase _repository;

        public OgrenciService(IRepositoryBase repository) //constructer injection
        {
            _repository = repository;
        }
        public Ogrenci[] OgrencileriGetir()
        {
            return _repository.Getir();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
    public class SinhVien_Services
    {
        public List<SinhVien> GetAll()
        {
            Model1 context = new Model1();
            return context.SinhViens.ToList();
        }
    }
}

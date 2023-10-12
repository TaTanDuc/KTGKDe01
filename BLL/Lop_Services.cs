using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Lop_Services
    {
        public List<Lớp> GetAll() 
        {
            Model1 context = new Model1();
            return context.Lớp.ToList();
        }
    }
}

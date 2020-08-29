using DAL;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Process
{
    public class InforCarProcess
    {
        DataContext db = new DataContext();

        public List<InforCarEntities> GetAll()
        {
            var Cars = db.inforCars.OrderByDescending(o => o.ID);
            return Cars.ToList();
        }
    }
}

using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ViewModels
{
    public class BillsVM:BillsEntities
    {
        public string CusName { get; set; }
        public string EmpName { get; set; }
        public string CarName { get; set; }
        public int NumCar { get; set; }
        public double TotalPrice { get; set; }
    }
}

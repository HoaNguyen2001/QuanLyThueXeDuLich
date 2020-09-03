using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entities
{
    [Table("Bills")]
    public class BillsEntities
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int EmpID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateOfHire { get; set; }
        public DateTime DateOfPayment { get; set; }
        public int PricePerDay { get; set; }
        public int InforCarID { get; set; }
        public DateTime CreateDay { get; set; }
        public bool Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entities
{
    [Table("Customers")]
    public class CustomerEntities
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public int IDCardNumber { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

    }
}

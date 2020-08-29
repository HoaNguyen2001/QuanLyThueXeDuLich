using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entities
{
    [Table("InforCar")]
    public class InforCarEntities
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ManufacturerCar { get; set; }
        public string Color { get; set; }
        public DateTime RegistrationDate { get; set; } //ngày đăng kí
        public string Status { get; set; } //Trạng thái
        public int NumCar { get; set; } //biển số xe
        public int PricePerDay { get; set; } //giá tiền 1 ngày
        public DateTime ManufactureYear { get; set; } //năm sản xuats
        public int NumberOfCar { get; set; } //Số lượng
        public DateTime DateAddCar { get; set; } //ngyaf nhập
    } 
}

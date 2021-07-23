using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DAW.Models.ShoeEntities
{
    public class Order
    {

        [Key]
        public int Id { get; set; }
        [DisplayName("Mã Khách Hàng")]
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        [DisplayName("Số Lượng")]
        public int Amount { get; set; }
        [DisplayName("Ngày Đặt Hàng")]
        public DateTime Date { get; set; }
        [ForeignKey("Shoes")]
        public int ShoeId { get; set; }
        public Shoe Shoes { get; set; }
    }
}
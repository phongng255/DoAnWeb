using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DAW.Models.ShoeEntities
{
    public class Shoe
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Tên Giày")]
        public string Name { get; set; }
        [DisplayName("Màu Giày")]
        public string Color { get; set; }
        [DisplayName("Kích Cỡ")]
        public int Size { get; set; }
        [DisplayName("Hình Ảnh Giày")]
        public string image { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        ICollection<Order> Orders { get; set; }
    }
}
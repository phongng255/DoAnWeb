using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DAW.Models.ShoeEntities
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Thương Hiệu")]
        public string Name { get; set; }

        [DisplayName("Hình Ảnh Thương Hiệu")]
        public string image { get; set; }
        ICollection<Shoe> Shoes { get; set; }
    }
}
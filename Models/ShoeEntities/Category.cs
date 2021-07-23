using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DAW.Models.ShoeEntities
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [DisplayName("Loại Sản Phẩm")]
        public string Name { get; set; }

        [DisplayName("Hình Ảnh Loại")]
        public string image { get; set; }

        ICollection<Shoe> Shoes { get; set; }
    }
}
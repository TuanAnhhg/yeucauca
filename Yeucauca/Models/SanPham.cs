using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yeucauca.Models
{
    public class SanPham
    {
        [ScaffoldColumn(false)]
        public int Masanpham { get; set; }
        [Required, StringLength(100), Display(Name = "Name")] public string Tensanpham { get; set; }
        public virtual ICollection<SanPham> cancau { get; set; }
    }
}
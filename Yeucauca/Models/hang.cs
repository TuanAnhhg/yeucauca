using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Yeucauca.Models
{
    public class hang
    {
        [ScaffoldColumn(false)]
        public int Mahang { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string Tenhang { get; set; }
        [Required, StringLength(1000), Display(Name = "Mô tả sản phảm"), DataType(DataType.MultilineText)] public string MoTa { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Giá")]
        public float? donvitien { get; set; }
        public int? Masanpham { get; set; }
        public virtual SanPham  SanPham { get; set; }
        public string Image { get; internal set; }
    }
}
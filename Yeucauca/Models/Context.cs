using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Yeucauca.Models
{
    public class Context : DbContext
    {
        public Context() : base("Yeucauca") 
        { }
        public DbSet<SanPham> Tensanpham { get; set; }
        public DbSet<hang> hang { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Yeucauca.Models
{
    public class hangDatabaseInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)

        {
            GetSanPham().ForEach(c => context.Tensanpham.Add(c));
            Gethang().ForEach(p => context.hang.Add(p));
        }
        private static List<SanPham> GetSanPham()
        {
            var SanPham = new List<SanPham> {                 new SanPham
                {
                    Masanpham = 1,
                    Tensanpham = "Cần câu"
                },
                new SanPham
                {
                    Masanpham = 2,
                    Tensanpham = "Máy câu"
                },
                new SanPham {
                    Masanpham = 3,
                    Tensanpham = "Mồi câu"
                },
                new SanPham
                {
                   Masanpham = 4,
                    Tensanpham = "Đồ dùng Khác"
                }             };
            return SanPham;
        }
        private static List<hang> Gethang()
        {
            var hang = new List<hang> { 
                 new hang 
                {
                   Mahang = 1,
                    Tenhang = "Fire & Blood",
                    MoTa = "300 Years Before A Game of Thrones (A Targaryen History) (A Song of Ice and Fire).",   
                    Image = "Pic1.png", 
                   donvitien = 16.04f, 
                   Masanpham = 1
                }, new hang
                {
                   Mahang = 1,
                    Tenhang = "Fire & Blood",
                    MoTa = "300 Years Before A Game of Thrones (A Targaryen History) (A Song of Ice and Fire).",
                    Image = "Pic1.png",
                   donvitien = 16.04f,
                   Masanpham = 1
                },
                 new hang
                {
                   Mahang = 1,
                    Tenhang = "Fire & Blood",
                    MoTa = "300 Years Before A Game of Thrones (A Targaryen History) (A Song of Ice and Fire).",
                    Image = "Pic1.png",
                   donvitien = 16.04f,
                   Masanpham = 1
                },
                new hang
                {
                   Mahang = 1,
                    Tenhang = "Fire & Blood",
                    MoTa = "300 Years Before A Game of Thrones (A Targaryen History) (A Song of Ice and Fire).",
                    Image = "Pic1.png",
                   donvitien = 16.04f,
                   Masanpham = 1
                },
               new hang
                {
                   Mahang = 1,
                    Tenhang = "Fire & Blood",
                    MoTa = "300 Years Before A Game of Thrones (A Targaryen History) (A Song of Ice and Fire).",
                    Image = "Pic1.png",
                   donvitien = 16.04f,
                   Masanpham = 1
                },
            }; 
            return hang; 
        } 
    } 
} 


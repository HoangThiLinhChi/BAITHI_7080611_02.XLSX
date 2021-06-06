using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HoangThiLinhChi_08.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int MaTinhThanh { get; set; }
        [Foreignkey("MaTinhThanh")]
        public TinhThanh TinhThanh { get; set; }
    }
}
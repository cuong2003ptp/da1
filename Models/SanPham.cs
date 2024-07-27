using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duan1.Models
{
    public class SanPham
    {
        public Guid ID { get; set; }
        public string TenSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public int SoLuong { get; set; }

    }
}

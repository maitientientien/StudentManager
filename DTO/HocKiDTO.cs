using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocKiDTO
    {
        private string MaHK;
        private string TenHK;

        public HocKiDTO(string maHK, string tenHK)
        {
            MaHK = maHK;
            TenHK = tenHK;
        }

        public string MaHK1 { get => MaHK; set => MaHK = value; }
        public string TenHK1 { get => TenHK; set => TenHK = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopDTO
    {
        private string MaLop;
        private string TenLop;
        private string MaKhoa;
        private string MaGV;

        public LopDTO(string maLop, string tenLop, string maKhoa, string maGV)
        {
            MaLop1 = maLop;
            TenLop1 = tenLop;
            MaKhoa1 = maKhoa;
            MaGV1 = maGV;
        }


        public LopDTO() { }
        
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string TenLop1 { get => TenLop; set => TenLop = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public string MaGV1 { get => MaGV; set => MaGV = value; }
    }
}

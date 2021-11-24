using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHocDTO
    {
        private string MaMH;
        private string TenMH;
        private string MaGV;

        public MonHocDTO(string maMH, string tenMH, string maGV)
        {
            MaMH1 = maMH;
            TenMH1 = tenMH;
            MaGV1 = maGV;
        }

        public MonHocDTO() { }

        public string MaMH1 { get => MaMH; set => MaMH = value; }
        public string TenMH1 { get => TenMH; set => TenMH = value; }
        public string MaGV1 { get => MaGV; set => MaGV = value; }
    }
}

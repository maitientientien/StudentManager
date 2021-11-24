using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVienDTO
    {
        private string MaGV;
        private string TenGV;

        public GiangVienDTO(string maGV, string tenGV)
        {
            MaGV1 = maGV;
            TenGV1 = tenGV;
        }

        public string MaGV1 { get => MaGV; set => MaGV = value; }
        public string TenGV1 { get => TenGV; set => TenGV = value; }
    }
}

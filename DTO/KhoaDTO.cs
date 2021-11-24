using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoaDTO
    {
        private string MaKhoa;
        private string TenKhoa;

        public KhoaDTO(string maKhoa, string tenKhoa)
        {
            MaKhoa1 = maKhoa;
            TenKhoa1 = tenKhoa;
        }

        public KhoaDTO() { }

        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public string TenKhoa1 { get => TenKhoa; set => TenKhoa = value; }
    }
}

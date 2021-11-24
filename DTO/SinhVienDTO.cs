using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVienDTO
    {
        private string MaSV;
        private string HoSV;
        private string TenSV;
        private DateTime NgaySinh;
        private string DiaChi;
        private string MaLop;
        private string MaKhoa;

        //contructor
        public SinhVienDTO(string maSV, string hoSV, string tenSV, DateTime ngaySinh, string diaChi, string maLop, string maKhoa)
        {
            MaSV = maSV;
            HoSV = hoSV;
            TenSV = tenSV;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            MaLop = maLop;
            MaKhoa = maKhoa;
        }
        public SinhVienDTO() { }

        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string HoSV1 { get => HoSV; set => HoSV = value; }
        public string TenSV1 { get => TenSV; set => TenSV = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
    }
}

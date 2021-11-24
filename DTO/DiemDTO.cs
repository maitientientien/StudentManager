using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemDTO
    {
        private string MaSV;
        private string MaMH;
        private int DiemCC;
        private float DiemKT;
        private float DiemThi;
        private float DiemTB;
        private string MaGV;
        private string MaHK;

        public DiemDTO(string maSV, string maMH, int diemCC, float diemKT, float diemThi, float diemTB ,string maGV, string maHK)
        {
            MaSV1 = maSV;
            MaMH1 = maMH;
            DiemCC1 = diemCC;
            DiemKT1 = diemKT;
            DiemThi1 = diemThi;
            DiemTB1 = diemTB;
            MaGV1 = maGV;
            MaHK1 = maHK;
        }
        public DiemDTO() { }


        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string MaMH1 { get => MaMH; set => MaMH = value; }
        public int DiemCC1 { get => DiemCC; set => DiemCC = value; }
        public float DiemKT1 { get => DiemKT; set => DiemKT = value; }
        public float DiemThi1 { get => DiemThi; set => DiemThi = value; }
        public float DiemTB1 { get => DiemTB; set => DiemTB = value; }
        public string MaGV1 { get => MaGV; set => MaGV = value; }
        public string MaHK1 { get => MaHK; set => MaHK = value; }
    }
}

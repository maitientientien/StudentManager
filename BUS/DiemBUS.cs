using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class DiemBUS
    {
        public static DataTable GetDS_Diem()
        {
            return DiemDAL.DS_Diem();
        }
        //insert
        public static void InsertDiem(DiemDTO diem)
        {
            DiemDAL.InsertDiem(diem);
        }
        /*public static void Nhap_Diem(string maSV, string maMH, int diemCC, float diemKT, float diemThi, float diemTB, string maGV, string maHK)
        {
            DiemDAL.Nhap_Diem(maSV,maMH,diemCC,diemKT,diemThi,diemTB,maGV,maHK);
        }*/
    }
}

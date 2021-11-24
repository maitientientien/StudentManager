using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class SinhVienBUS
    {
        public static DataTable GetDS_SinhVien()
        {
            return SinhVienDAL.DS_SinhVien();
        }
        //insert
        public static void InsertSV (SinhVienDTO sinhVien)
        {
            SinhVienDAL.InsertSV(sinhVien);
        }
        //update
        public static void UpdateSinhVien (SinhVienDTO sinhVien)
        {
            SinhVienDAL.Update_SV(sinhVien);
        }

        //delete
        public static void deleteSinhVien(string masv)
        {
            SinhVienDAL.Delete_SV(masv);
        }
        //timkiem masv
        public static DataTable timkiem_MaSV(string ma )
        {
            return SinhVienDAL.timSV_Ma(ma);
        }
        //timkiem ten
        public static DataTable timkiem_TenSV(string ten)
        {
            return SinhVienDAL.timSV_Ten(ten);
        }

    }
}


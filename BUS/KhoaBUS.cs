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
    public class KhoaBUS
    {
        public static DataTable GetDS_Khoa()
        {
            return KhoaDAL.DS_Khoa();
        }
        //insert
        public static void InsertKhoa(KhoaDTO khoa)
        {
            KhoaDAL.InsertKhoa(khoa);
        }
        //update
        public static void UpdateKhoa (KhoaDTO khoa)
        {
            KhoaDAL.UpdateKhoa(khoa);
        }

        //delete
        public static void delete_Khoa(string maKhoa)
        {
            KhoaDAL.DeleteKhoa(maKhoa);
        }


    }
}

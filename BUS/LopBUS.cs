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
    public class LopBUS
    {
        public static DataTable GetDS_Lop()
        {
            return LopDAL.DS_Lop();
        }
        //insert
        public static void InsertLopSV (LopDTO lop)
        {
            LopDAL.InsertLop(lop);
        }
        //update
        public static void UpdateLopSV(LopDTO lop)
        {
            LopDAL.UpdateLop(lop);
        }
        //delete
        public static void DeleteLop (string maLop)
        {
            LopDAL.DeleteLop(maLop);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class MonHocBUS
    {
		public static DataTable GetDataDS_MonHoc()
		{
			return MonHocDAL.DS_MonHoc();
		}
        //insert
        public static void InsertMonHoc(MonHocDTO monHoc)
        {
            MonHocDAL.InsertMonHoc(monHoc);
        }
        //update
        public static void UpdateMonHoc(MonHocDTO monHoc)
        {
            MonHocDAL.UpdateMonHoc(monHoc);
        }

        //delete
        public static void deleteMonHoc(string maMH)
        {
            MonHocDAL.DeleteMonHoc(maMH);
        }


    }
}

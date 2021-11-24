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
    public  class GiangVienBUS
    {
        public static DataTable GetDS_GiangVien ()
        {
            return GiangVienDAL.DS_GiangVien();
        }


    }
}

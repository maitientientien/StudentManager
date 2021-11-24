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
    public class HocKiBUS
    {
        public static DataTable GetDS_HocKi()
        {
            return HocKiDAL.DS_HocKi();
        }

    }
}

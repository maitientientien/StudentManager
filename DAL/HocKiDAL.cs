using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HocKiDAL
    {

		public static DataTable DS_HocKi ()
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("GetDataHocKi", Conn);
			command.CommandType = CommandType.StoredProcedure;
			Conn.Open();
			SqlDataAdapter da = new SqlDataAdapter();
			DataTable ds = new DataTable();
			da.SelectCommand = command;
			da.Fill(ds);
			Conn.Close();
			return ds;
		}
	}
}

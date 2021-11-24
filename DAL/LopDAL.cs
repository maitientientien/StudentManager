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
    public class LopDAL
    {
		//getdata
		public static DataTable DS_Lop()
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("GetDataLop", Conn);
			command.CommandType = CommandType.StoredProcedure;
			Conn.Open();
			SqlDataAdapter da = new SqlDataAdapter();
			DataTable ds = new DataTable();
			da.SelectCommand = command;
			da.Fill(ds);
			Conn.Close();
			return ds;
		}
		//insert 
		public static void InsertLop (LopDTO lop)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("Insert_Lop", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@TenLop", SqlDbType.NVarChar, 30);
			command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 50);
			command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
			command.Parameters["@MaLop"].Value = lop.MaLop1;
			command.Parameters["@TenLop"].Value = lop.TenLop1;
			command.Parameters["@MaGV"].Value = lop.MaGV1;
			command.Parameters["@MaKhoa"].Value = lop.MaKhoa1;

			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}

		//update
		public static void UpdateLop (LopDTO lop)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("UpdateLop", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@TenLop", SqlDbType.NVarChar, 30);
			command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 50);
			command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
			command.Parameters["@MaLop"].Value = lop.MaLop1;
			command.Parameters["@TenLop"].Value = lop.TenLop1;
			command.Parameters["@MaGV"].Value = lop.MaGV1;
			command.Parameters["@MaKhoa"].Value = lop.MaKhoa1;

			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}

		//delete
		public static void DeleteLop (string maLop)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("DeleteLop", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);

			command.Parameters["@MaLop"].Value = maLop;
			
			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}



	}
}

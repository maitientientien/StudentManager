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
    public class KhoaDAL
    {

		//getdata
		public static DataTable DS_Khoa()
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("GetDataKhoa", Conn);
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
		public static void InsertKhoa(KhoaDTO khoa )
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("Insert_Khoa", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@TenKhoa", SqlDbType.NVarChar, 50);

			command.Parameters["@MaKhoa"].Value = khoa.MaKhoa1;
			command.Parameters["@TenKhoa"].Value = khoa.TenKhoa1;
			

			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}

		//update
		public static void UpdateKhoa (KhoaDTO khoa)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("UpdateKhoa", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@TenKhoa", SqlDbType.NVarChar, 50);

			command.Parameters["@MaKhoa"].Value = khoa.MaKhoa1;
			command.Parameters["@TenKhoa"].Value = khoa.TenKhoa1;


			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}

		//delete
		public static void DeleteKhoa(string maKhoa )
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("DeleteKhoa", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
			command.Parameters["@MaKhoa"].Value = maKhoa;


			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}





	}
}

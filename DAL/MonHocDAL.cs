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
    public class MonHocDAL
    {
		public static DataTable DS_MonHoc ()
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("GetData_MonHoc", Conn);
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
		public static void InsertMonHoc(MonHocDTO monHoc)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("Insert_MonHoc", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaMH", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@TenMH", SqlDbType.NVarChar, 50);
			command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
			command.Parameters["@MaMH"].Value = monHoc.MaMH1;
			command.Parameters["@TenMH"].Value = monHoc.TenMH1;
			command.Parameters["@MaGV"].Value = monHoc.MaGV1;
			

			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}

		//cap nhat 
		public static void UpdateMonHoc (MonHocDTO monHoc)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("Update_MonHoc", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaMH", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@TenMH", SqlDbType.NVarChar, 50);
			command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
			command.Parameters["@MaMH"].Value = monHoc.MaMH1;
			command.Parameters["@TenMH"].Value = monHoc.TenMH1;
			command.Parameters["@MaGV"].Value = monHoc.MaGV1;

			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}
		//xoa
		public static void DeleteMonHoc (string maMH)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("Delete_MonHoc", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaMH", SqlDbType.NVarChar, 10);

			command.Parameters["@MaMH"].Value = maMH;


			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}


	}
}

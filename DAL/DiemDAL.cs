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
    public class DiemDAL
    {

		public static DataTable DS_Diem()
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("GetData_Diem", Conn);
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
		public static void InsertDiem(DiemDTO diem)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("Insert_Diem", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaSV", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@MaMH", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@DiemCC", SqlDbType.Int );
			command.Parameters.Add("@DiemKT", SqlDbType.Float);
			command.Parameters.Add("@DiemThi", SqlDbType.Float);
			command.Parameters.Add("@DiemTB", SqlDbType.Float);
			command.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@MaHK", SqlDbType.NVarChar, 10);

			command.Parameters["@MaSV"].Value = diem.MaSV1;
			command.Parameters["@MaMH"].Value = diem.MaMH1;
			command.Parameters["@DiemCC"].Value = diem.DiemCC1;
			command.Parameters["@DiemKT"].Value = diem.DiemKT1;
			command.Parameters["@DiemThi"].Value = diem.DiemThi1;
			command.Parameters["@DiemTB"].Value = diem.DiemTB1;
			command.Parameters["@MaGV"].Value = diem.MaGV1;
			command.Parameters["@MaHK"].Value = diem.MaHK1;

			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}
		/*public static void Nhap_Diem(DiemDTO diem)
		{
			
			float diemtb = (float)(diem.DiemCC1 * 2 + diem.DiemKT1 * 3 + diem. DiemThi1* 5) / 10;
			SqlConnection Conn = DB_Connect.HamKetNoi();
			Conn.Open();
			SqlCommand cmd = new SqlCommand("insert into DIEM values ('" + diem.MaSV1 + "','" + diem.MaMH1 + "','" + diem.DiemCC1 + "','" + diem.DiemKT1+ "','" + diem.DiemThi1+ "','" + diem.DiemTB1 + "','" + diem.MaGV1 + "','" +diem.MaHK1 + "')", Conn);//lệnh truy vấn
			cmd.ExecuteNonQuery();
			Conn.Close();
		}
		

		public static void Nhap_Diem(string maSV, string maMH, int diemCC, float diemKT, float diemThi, float diemTB, string maGV, string maHK)
		{

			float diemtb = (float)(diemCC * 2 + diemKT * 3 + diemThi * 5) / 10;
			SqlConnection Conn = DB_Connect.HamKetNoi();
			Conn.Open();
			SqlCommand cmd = new SqlCommand("insert into DIEM values ('" + maSV + "','" + maMH + "','" + diemCC + "','" + diemKT + "','" + diemThi + "','" + diemTB + "','" + maGV + "','" + maHK + "')", Conn);//lệnh truy vấn
			cmd.ExecuteNonQuery();
			Conn.Close();
		}*/




	}
}

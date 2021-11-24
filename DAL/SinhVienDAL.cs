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
    public class SinhVienDAL
    {
		//getdata
		public static DataTable DS_SinhVien()
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("GetData_SinhVien",Conn);
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
		public static void InsertSV(SinhVienDTO sinhVien)
        {
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("Insert_SinhVien", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaSV", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@HoSV", SqlDbType.NVarChar, 30);
			command.Parameters.Add("@TenSV", SqlDbType.NVarChar, 50);
			command.Parameters.Add("@NgaySinh", SqlDbType.Date);
			command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
			command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
			command.Parameters["@MaSV"].Value = sinhVien.MaSV1;
			command.Parameters["@HoSV"].Value = sinhVien.HoSV1;
			command.Parameters["@TenSV"].Value = sinhVien.TenSV1;
			command.Parameters["@NgaySinh"].Value = sinhVien.NgaySinh1;
			command.Parameters["@DiaChi"].Value = sinhVien.DiaChi1;
			command.Parameters["@MaLop"].Value = sinhVien.MaLop1;
			command.Parameters["@MaKhoa"].Value = sinhVien.MaKhoa1;

			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();
			
		}

		//cap nhat 
		public static void Update_SV (SinhVienDTO sinhVien)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("UpdateSV", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaSV", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@HoSV", SqlDbType.NVarChar, 30);
			command.Parameters.Add("@TenSV", SqlDbType.NVarChar, 50);
			command.Parameters.Add("@NgaySinh", SqlDbType.Date);
			command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
			command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
			command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 10);
			command.Parameters["@MaSV"].Value = sinhVien.MaSV1;
			command.Parameters["@HoSV"].Value = sinhVien.HoSV1;
			command.Parameters["@TenSV"].Value = sinhVien.TenSV1;
			command.Parameters["@NgaySinh"].Value = sinhVien.NgaySinh1;
			command.Parameters["@DiaChi"].Value = sinhVien.DiaChi1;
			command.Parameters["@MaLop"].Value = sinhVien.MaLop1;
			command.Parameters["@MaKhoa"].Value = sinhVien.MaKhoa1;

			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}
		//xoa
		public static void Delete_SV (string maSV )
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			SqlCommand command = new SqlCommand("DeleteSV", Conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.Add("@MaSV", SqlDbType.NVarChar, 10);
			
			command.Parameters["@MaSV"].Value =maSV;
			

			Conn.Open();
			command.ExecuteNonQuery();
			Conn.Close();

		}
		//tim kiem sinh vien
		public static DataTable timSV_Ma(string ma)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			Conn.Open();
			SqlDataAdapter adap = new SqlDataAdapter("select row_number() over (order by MaSV) as STT, MaSV as [Mã Sinh Viên],HoSV as[Họ Sinh Viên],TenSV as[Tên Sinh Viên],DiaChi as [Địa Chỉ],NgaySinh as[Ngày Sinh],MaLop as [Mã Lớp], MaKhoa as [Mã Khoa]  from SinhVien where MaSV like '%" + ma + "%'", Conn);
			DataTable ds = new DataTable();
			adap.Fill(ds);
			Conn.Close();
			return ds;

		}
		public static DataTable timSV_Ten(string ten)
		{
			SqlConnection Conn = DB_Connect.HamKetNoi();
			Conn.Open();
			SqlDataAdapter adap = new SqlDataAdapter("select row_number() over (order by MaSV) as STT, MaSV as [Mã Sinh Viên],HoSV as[Họ Sinh Viên],TenSV as[Tên Sinh Viên],DiaChi as [Địa Chỉ],NgaySinh as[Ngày Sinh],MaLop as [Mã Lớp], MaKhoa as [Mã Khoa]  from SinhVien where TenSV like '%" + ten + "%'", Conn);
			DataTable ds = new DataTable();
			adap.Fill(ds);
			Conn.Close();
			return ds;

		}



	}
}

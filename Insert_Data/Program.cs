using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Insert_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-DMUVDQOK\\WIRATAMA;database=TokoBakery;Integrated Security " +
                    "= TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Kasir (Id_kasir,Nama_kasir,Jenis_Kelamin )values('K01','Wira','L')" +
                    "insert into Kasir (Id_kasir,Nama_kasir,Jenis_Kelamin )values('K02','Arya','L')" +
                    "insert into Kasir (Id_kasir,Nama_kasir,Jenis_Kelamin )values('K03','Ditya','L')" +
                    "insert into Kasir (Id_kasir,Nama_kasir,Jenis_Kelamin )values('K04','Gito','L')" +
                    "insert into Kasir (Id_kasir,Nama_kasir,Jenis_Kelamin )values('K05','Memet','L')" +

                    "insert into Customer (Id_Customer,Nama_Customer,Jenis_Kelamin,No_Telp )values('C01','Athallariq','L','082278501731')" +
                    "insert into Customer (Id_Customer,Nama_Customer,Jenis_Kelamin,No_Telp )values('C02','Indah','P','082278501741')" +
                    "insert into Customer (Id_Customer,Nama_Customer,Jenis_Kelamin,No_Telp )values('C03','Rabin','L','082278501701')" +
                    "insert into Customer (Id_Customer,Nama_Customer,Jenis_Kelamin,No_Telp )values('C04','Ivan','L','082278501711')" +
                    "insert into Customer (Id_Customer,Nama_Customer,Jenis_Kelamin,No_Telp )values('C05','Satia','L','082278501710')" +
                    con);

                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }
    } 
}

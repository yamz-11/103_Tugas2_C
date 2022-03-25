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

                    //Menambakah data dalam tabel Customer
                    "insert into Customer (Id_Customer,Nama_Customer,Jenis_Kelamin,No_Telp )values('C01','Athallariq','L','082278501731')" +
                    "insert into Customer (Id_Customer,Nama_Customer,Jenis_Kelamin,No_Telp )values('C02','Indah','P','082278501741')" +
                    "insert into Customer (Id_Customer,Nama_Customer,Jenis_Kelamin,No_Telp )values('C03','Rabin','L','082278501701')" +
                    "insert into Customer (Id_Customer,Nama_Customer,Jenis_Kelamin,No_Telp )values('C04','Ivan','L','082278501711')" +
                    "insert into Customer (Id_Customer,Nama_Customer,Jenis_Kelamin,No_Telp )values('C05','Satia','L','082278501710')" +

                    //Menambahkan data dalam tabel Barang
                    "insert into Baarang (Id_Barang,Nama_Barang,Qty,Stock_Barang )values('Brg01','Sweet Bread','1','20')" +
                    "insert into Baarang (Id_Barang,Nama_Barang,Qty,Stock_Barang )values('Brg02','Cake','2','25')" +
                    "insert into Baarang (Id_Barang,Nama_Barang,Qty,Stock_Barang )values('Brg03','Chiffon','1','11')" +
                    "insert into Baarang (Id_Barang,Nama_Barang,Qty,Stock_Barang )values('Brg04','Donut','3','50')" +
                    "insert into Baarang (Id_Barang,Nama_Barang,Qty,Stock_Barang )values('Brg05','Cookies','5','40')" +
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

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
                    "insert into Baarang (Id_Barang,Nama_Barang,Harga_Barang,Qty,Stock_Barang )values('Brg01','Sweet Bread','Rp.10.000','1','20')" +
                    "insert into Baarang (Id_Barang,Nama_Barang,Harga_Barang,Qty,Stock_Barang )values('Brg02','Cake','Rp.20.000','2','25')" +
                    "insert into Baarang (Id_Barang,Nama_Barang,Harga_Barang,Qty,Stock_Barang )values('Brg03','Chiffon','Rp.8.000','1','11')" +
                    "insert into Baarang (Id_Barang,Nama_Barang,Harga_Barang,Qty,Stock_Barang )values('Brg04','Donut','Rp.5.000','3','50')" +
                    "insert into Baarang (Id_Barang,Nama_Barang,Harga_Barang,Qty,Stock_Barang )values('Brg05','Cookies','Rp.3.000','5','40')" +

                    //Menambahkan data dalam tabel Transaksi
                    "insert into Transaksi (Id_Transaksi,Id_Barang,Id_Customer,Id_Kasir,Qty,Tanggal,Waktu,Jumlah_Bayar,Total_Pembayaran )values('Trk01','Brg01','C01','K01','1','21-03-2022'Rp.10.000','Rp.10.000')" +
                    "insert into Transaksi (Id_Transaksi,Id_Barang,Id_Customer,Id_Kasir,Qty,Tanggal,Waktu,Jumlah_Bayar,Total_Pembayaran )values('Trk02','Brg02','C02','K02','2','22-03-2022'Rp.40.000','Rp.50.000')" +
                    "insert into Transaksi (Id_Transaksi,Id_Barang,Id_Customer,Id_Kasir,Qty,Tanggal,Waktu,Jumlah_Bayar,Total_Pembayaran )values('Trk03','Brg03','C03','K03','1','23-03-2022'Rp.8.000','Rp.10.000')" +
                    "insert into Transaksi (Id_Transaksi,Id_Barang,Id_Customer,Id_Kasir,Qty,Tanggal,Waktu,Jumlah_Bayar,Total_Pembayaran )values('Trk04','Brg04','C04','K04','3','24-03-2022'Rp.15.000','Rp.20.000')" +
                    "insert into Transaksi (Id_Transaksi,Id_Barang,Id_Customer,Id_Kasir,Qty,Tanggal,Waktu,Jumlah_Bayar,Total_Pembayaran )values('Trk05','Brg05','C05','K05','3','25-03-2022'Rp.15.000','Rp.15.000')",
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

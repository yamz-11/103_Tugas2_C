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
                    "insert into Kasir (Id_kasir,Nama_kasir,Jenis_Kelamin )values('K05','Memet','L')",
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

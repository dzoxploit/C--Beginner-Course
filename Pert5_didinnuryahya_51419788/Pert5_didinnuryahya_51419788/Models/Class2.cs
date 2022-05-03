using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Pert5_didinnuryahya_51419788.Models
{
    public class Class2
    {
        MySqlConnection con;
        public String nm { set; get; }
        public String Pass { set; get; }
        public String status { set; get; }

        public MySqlConnection connection()
        {
            String koneksi = String.Format("server={0};user id={1}; password={2};" +
                "database=pengguna", "localhost",
                "root", "");
            MySqlConnection cn = new MySqlConnection(koneksi);
            return cn;
        }

        public String isi(String nm, String Pass)
        {
            try
            {
                this.con = connection();
                String query = String.Format("INSERT INTO login VALUE('{0}', '{1}');", nm, Pass);
                MySqlCommand comm = new MySqlCommand(query, this.con);
                this.con.Open();
                comm.ExecuteNonQuery();
                con.Close();
                return ("Register berhasil");
            }
            catch (Exception e)
            {
                return ("Register gagal");
            }
        }

    }
}
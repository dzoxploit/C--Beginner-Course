using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Pert5_didinnuryahya_51419788.Models
{
    public class Class1
    {
        MySqlConnection con;
        public String nm { set; get; }
        public String Pass { set; get; }
        public String dta1 { set; get; }
        public String dta2 { set; get; }

        public MySqlConnection connection()
        {
            String koneksi = String.Format("server={0};user id={1}; password={2};" +
                "database=pengguna;", "localhost",
                "root", "");
            MySqlConnection cn = new MySqlConnection(koneksi);
            return cn;
        }

        public void ambil(String nm)
        {
            this.con = connection();
            String query = String.Format("SELECT * FROM LOGIN WHERE nama='{0}'", nm);
            MySqlCommand comm = new MySqlCommand(query, this.con);

            this.con.Open();
            MySqlDataReader dta = comm.ExecuteReader();
            if (dta.HasRows)
            {
                while (dta.Read())
                {
                    dta1 = dta[0].ToString();
                    dta2 = dta[1].ToString();
                }
            }

            con.Close();
        }


    }
}
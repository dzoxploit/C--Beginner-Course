using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace DidinPertemuan8.Models
{
    public class Class1
    {
        public String usr, ps, stat;
        public String id { get; set; }
        public String pass { get; set; }
        public String title { get; set; }
        public String konten { get; set; }
        public String hapus { get; set; }
        public String time { get; set; }
        public Stack<String> judul = new Stack<String>();
        public Stack<String> isi = new Stack<String>();
        public Stack<String> tgl = new Stack<String>();
        private MySqlConnection koneksi()
        {
            MySqlConnection koneksi;
            koneksi = new MySqlConnection();
            koneksi.ConnectionString = string.Format("server=localhost; user id=root; password =; " + "database=blog_didin;"); //misal blog_putlan
            try
            {
                koneksi.Open();
                this.stat = "success";
                return koneksi;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return koneksi;
        }
        public void Login()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = koneksi();
                cmd.CommandText = string.Format("Select * from login where id ='" + id
               + "';");
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    this.usr = read["id"].ToString();
                    this.ps = read["password"].ToString();
                }
                koneksi().Close();
            }
            catch (Exception e) { }
        }
        public void ambil_konten()
        {
            MySqlDataReader ambil;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = koneksi();
            cmd.CommandText = string.Format("Select * from konten;");
            ambil = cmd.ExecuteReader();
            while (ambil.Read())
            {
                this.judul.Push(ambil["judul"].ToString());
                this.isi.Push(ambil["isi"].ToString());
                this.tgl.Push(ambil["tanggal"].ToString());
            }
        }
        public void isi_kontent()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = koneksi();
            cmd.CommandText = string.Format("insert into konten values(null, '" + title + "' , '" + konten + "', '" + time + "'); ");
            cmd.ExecuteNonQuery();
            koneksi().Close();
        }
        public void hapus_kontent()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = koneksi();
            cmd.CommandText = string.Format("delete from konten where judul ='" +
           hapus + "';");
            cmd.ExecuteNonQuery();
            koneksi().Close();
        }

    }
}
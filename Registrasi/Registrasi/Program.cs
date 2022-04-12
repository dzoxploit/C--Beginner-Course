using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registrasi
{
    class Program
    {
        static void Main(string[] args)
        {
            String username, password, email, nama, gender;
            int umur;

            Console.WriteLine("Form Registrasi LearningGeeky.com");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            try
            {
                Console.Write("Username \t: ");
                username = Console.ReadLine();
                Console.Write("Password \t: ");
                password = Console.ReadLine();
                Console.Write("Nama \t: ");
                nama = Console.ReadLine();
                Console.Write("Gender (L/P) \t: ");
                gender = Console.ReadLine();
                Console.Write("Email \t\t: ");
                email = Console.ReadLine();
                Console.Write("Umur \t\t: ");
                umur = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();

                Validasi v = new Validasi();
                v.setUsername(username);
                v.setPassword(password);
                v.setEmail(email);
                v.setNama(nama);
                v.setGender(gender);
                v.setUmur(umur);

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Hasil Pendaftaran");
                if (v.validate() == "ok")
                {
                    Console.WriteLine("Registrasi Berhasil");
                }
                else {
                    Console.WriteLine(v.validate());
                }

                Console.WriteLine();
                Console.WriteLine("Data Yang Terinput");
                Console.WriteLine("Username \t {0}: ",username);
                Console.WriteLine("Password \t: {0}", password);
                Console.WriteLine("Nama \t: {0}",nama);
                Console.WriteLine("Gender (L/P) \t: {0}", gender);
                Console.WriteLine("Email \t\t: {0}",email);
                Console.WriteLine("Umur \t\t: {0}",umur);
                Console.WriteLine();


            }
            catch(Exception e) {
                Console.WriteLine("Error Invalid Input");
            }
            Console.ReadKey();

        }
    }
    class Validasi {
        private String username, password, email, nama, gender;
        private int umur;

        public void setUsername(String username) {
            this.username = username.ToLower();   
        }
        public void setPassword(String password)
        {
            this.password = password.ToLower();
        }
        public void setEmail(String email)
        {
            this.email = email.ToLower();
        }
        public void setNama(String nama)
        {
            this.nama = nama.ToLower();
        }
        public void setGender(String gender)
        {
            this.gender = gender.ToLower();
        }
        public void setUmur(int umur)
        {
            this.umur = umur;
        }

        public string validate() {
            string keterangan;
            if (username == null || password == null || email == null || nama == null
                || gender == null || umur == 0) {
                    keterangan = "Tidak boleh ada field yang kosong";
            }
            else if (username.Length < 8 || username.Length > 32) {
                keterangan = "Panjang username harus 8-32 karakter";
            }
            else if (password.Length < 8 || password.Length > 32)
            {
                keterangan = "Panjang password harus 8-32 karakter";
            }
            else if (nama.Length > 100)
            {
                keterangan = "Panjang nama tidak boleh melebihi 100 karakter";
            }
            else if (email.Length < 8)
            {
                keterangan = "Panjang email harus lebih dari 8 karakter";
            }
            else if (umur < 17)
            {
                keterangan = "Anda Terlalu Muda Untuk Mendaftar";
            }

            else if(gender.ToLower() == "l" || gender.ToLower() == "p")
            {
                keterangan = "Masukan gender dengan benar. \nL = laki-laki\nP = perempuan";
            }
            else
            {
                keterangan = "ok";
            }

            return keterangan;
        }
    }
}

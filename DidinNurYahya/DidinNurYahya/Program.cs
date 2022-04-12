using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DidinNurYahya
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("=== PROGRAM WAKWAW ===");
            Console.Write("Masukan Nama Awal Anda: ");
            string nama_awal = Console.ReadLine();
            Console.Write("Masukan Nama Akhir Anda: ");
            string nama_akhir = Console.ReadLine();
            Console.Write("Masukan Kelas Anda: ");
            string kelas = Console.ReadLine();

            string gabung = string.Concat(nama_awal," ",nama_akhir);
            string aSTR = nama_awal.Substring(4, 6);
            
            StringBuilder bStr = new StringBuilder(nama_akhir);

            bStr.Replace('a', 'k');
            bStr.Replace('i', 'k');
            bStr.Replace('u', 'k');
            bStr.Replace('e', 'k');
            bStr.Replace('o', 'k');


            Console.WriteLine("Nama saya adalah {0}, Kelas saya adalah {1}", gabung, kelas);
            Console.WriteLine("Hasil Substring Nama Awal adalah {0}", aSTR);
            Console.WriteLine("Hasil Replace dari character nama akhir saya adalah {0}", bStr);
             */
            string nama_awal = "Universitas";
            string nama_akhir = " Gunadarma";
            Console.WriteLine("String Awal : {0}",nama_awal);
            Console.WriteLine("String Akhir : {0}",nama_akhir);

            string aSTR = nama_awal.ToLower();
            string bStr = aSTR.Replace('i', 'o');

            string cStr = nama_akhir.ToUpper();
            string dStr = cStr.Substring(0, 5);

            string eStr = string.Concat(bStr, dStr);
            Console.WriteLine("Hasil Gabungan Beberapa Method String : {0}", eStr);
            Console.ReadLine();
        }
    }
}

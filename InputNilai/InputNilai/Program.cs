using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace InputNilai
{
    class Program
    {
        private ArrayList data = new ArrayList();
        static void Main(string[] args)
        {
            Program p = new Program();
            p.startMenu();

            Console.ReadKey();
        }
        private void startMenu() {
            Console.WriteLine("Program Input Nilai LearningGeeky");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1) Input Nilai");
            Console.WriteLine("2) Daftar Nilai");
            Console.WriteLine("3) Exit");

            try
            {
                Console.Write("Pilih Menu:  ");
                int index = Convert.ToInt16(Console.ReadLine());

                switch (index)
                {
                    case 1:
                        InputNilai();
                        break;
                    case 2:
                        DaftarNilai();
                        break;
                    case 3:
                        Exit();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) {
                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("> Error user input please choose menu in bellow (1-4)");
                Console.WriteLine("---------------------------");

                this.InputNilai();
            }
        }
        private void InputNilai() {
            Console.Clear();
            Console.WriteLine("Input Nilai Siswa");
            Console.WriteLine("-----------------------------");

            try
            {
                Console.WriteLine("Masukan Nama Siswa");
                string siswaInput = Console.ReadLine();
                Console.WriteLine("Masukan Nilai Siswa");
                string nilaiInput = Console.ReadLine();

                try
                {
                    ArrayList newData = new ArrayList();
                    newData.Add(siswaInput);
                    newData.Add(nilaiInput);

                    this.data.AddRange(newData);
                }
                catch (Exception e) {
                    Console.Clear();
                    Console.WriteLine("Hey it is something wrong with arraylist");
                    Console.WriteLine("Error: {0}", e);
                }
                Console.Clear();
                Console.WriteLine("DataStore Success");
                Console.WriteLine();

                this.startMenu();
            }
            catch (Exception) {
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(">error user input");
                Console.WriteLine("------------------------------------");

                this.InputNilai();
            }
        }
        private void DaftarNilai() {
            Console.Clear();
            Console.WriteLine("Daftar Nilai Yang Tersedia");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            if (data.Count == 0)
            {
                Console.WriteLine("Belum ada data");
            }
            else {
                Console.WriteLine("! Nama Siswa\t Nilai\t Angka\t Keterangan\t");
                int n = 1;

                foreach (var item in this.data) {
                    if (!IsEven(n)) 
                        Console.Write("|");

                    Console.Write(" {0} \t", item);

                    if (IsEven(n)) {
                        int nilai = Convert.ToInt16(item);

                        Console.Write(" {0}\t|", this.getAngka(nilai));

                        if (nilai >= 65)
                            Console.Write("Lulus\t");
                        else
                            Console.Write("Tidak Lulus\t");
                        Console.WriteLine();
                    }
                    n++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            this.startMenu();

        }
        private void Exit() {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thanks for using application");
            Console.WriteLine("Bye");
        }

        private bool IsEven(int number) {
            return number % 2 == 0;
        }

        private string getAngka(int nilai) {
            string nilaiAngka;

            if (nilai <= 100 || nilai >= 0)
            {
                if (nilai >= 0 && nilai <= 20)
                    nilaiAngka = "E";
                else if (nilai > 20 && nilai <= 40)
                    nilaiAngka = "D";

                else if (nilai > 40 && nilai <= 60)
                    nilaiAngka = "C";
                else if (nilai > 60 && nilai <= 80)
                    nilaiAngka = "B";
                else
                    nilaiAngka = "A";
            }
            else {
                nilaiAngka = "unvalid";
            }
            return nilaiAngka;
        }

    }
}

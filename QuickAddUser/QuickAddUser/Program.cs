using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickAddUser
{
    class Program
    {
        System.Collections.ArrayList UserList = new System.Collections.ArrayList();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();

            Console.ReadKey();
        }
        private void Start() {
            bool n = true;
            Console.WriteLine("> Quick Add User Form");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            do
            {
                inputUser();

                n = askContinue();
            } while (n);

            showUser();

        }
        private bool askContinue() {
            Console.Write("Do you want to add more user (y/n):");
            string signal = Console.ReadLine();

            if (!(signal == "y" || signal == "n"))
                askContinue();
         
            return (signal == "y") ? true : false;
        }

        private void inputUser() {
            try
            {
                string user;

                Console.Write("Input new user : ");

                user = Console.ReadLine();

                UserList.Add(user);
            }
            catch (Exception) {
                Console.WriteLine("Error: Sorry, Please try to input user again");
                Console.WriteLine();
                inputUser();
            }
        }
        private void showUser() {
            int n = 0;

            Console.Clear();
            Console.WriteLine("Daftar User Yang Telah diinput");
            Console.WriteLine("-------------------------------");

            while (n < UserList.Count) {
                Console.WriteLine("{0}. {1}", n + 1, UserList[n]);
                n++;
            }
        }
    }
}

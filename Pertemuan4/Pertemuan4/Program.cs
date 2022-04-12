using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Memanggil Menu
            Interface i = new Interface();
            i.LoginMenu();

            Console.ReadKey();
        }
    }
}

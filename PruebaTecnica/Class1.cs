using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    internal class Class1
    {
        public static void Main()
        {
            string path = File.ReadAllText("C:\\el_quijote.txt");

            Console.WriteLine(path); // it ll display ur file on console

            Console.Write(path.Length); // show character
            Console.WriteLine();

            Console.WriteLine(path.Split('\r').Length);  // total line

            Console.WriteLine(path.Split(' ').Length); // total word


        }

    }
}

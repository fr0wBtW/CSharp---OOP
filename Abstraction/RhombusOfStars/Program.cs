using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var rhombusDrawer = new RhombusAsStringDrawer();
            var rhomnusAsString = rhombusDrawer.Draw(n);

            Console.WriteLine(rhomnusAsString);
        }
    }
}

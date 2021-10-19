using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(3, 1, 1, 3);
            Console.WriteLine(rectangle.Contains(new Point(2, 2)));
        }
    }
}

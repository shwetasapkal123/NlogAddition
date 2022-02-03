using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Problem\n Enter a value");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value");
            int b=Convert.ToInt32(Console.ReadLine());
            AddNumbers add = new AddNumbers();
            Console.WriteLine("Result is "+add.Sum(a,b));
            Console.ReadLine();
        }
    }
}

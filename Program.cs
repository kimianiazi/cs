using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace حقوق_خالص
{
    class Program
    {
        static void Main(string[] args)
        {
            Class employe = new Class();

            Console.WriteLine("name?");
            employe.name = Console.ReadLine();

            Console.WriteLine("last?");
            employe.last = Console.ReadLine();

            Console.WriteLine("number?");
            employe.number = Console.ReadLine();

            Console.WriteLine("payment?");
            employe.payment = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(employe.Income(employe.payment));

            Console.ReadKey();

        }
    }
}

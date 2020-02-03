using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppContext(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString))
            {
                Console.WriteLine($"{context.Animals.Count()} Animals found.");
                Console.WriteLine($"{context.Plants.Count()} Plants found.");
            }

            Console.ReadLine();
        }
    }
}

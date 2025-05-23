using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();
            Console.WriteLine("Enter 4 items for the list:");


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter item {i + 1}");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    list.Add(value);

                }

                else
                {
                    list.Add(input);
                }

            }

            Console.WriteLine($"\nTotal items in the list {list.Count}");
            Console.WriteLine("Items");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

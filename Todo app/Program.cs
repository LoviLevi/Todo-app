using ConsoleTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int valasztas = 0;

            while (valasztas != 3)
            {
                Console.Clear();

                Console.WriteLine("1 - Add to the list");
                Console.WriteLine("2 - Show all");
                Console.WriteLine("3- Exit");

                valasztas = int.Parse(Console.ReadLine());
                if (valasztas == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Írd be a Task-ot");
                    string task = Console.ReadLine();
                    list.Add(task);

                    Console.Clear();
                    Console.WriteLine("Task added...");
                }
                else if (valasztas == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Tasks:");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                    Console.ReadKey();
                }
                else if(valasztas == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Quiting...");
                    Console.ReadKey();
                }
            }
        }
    }
}

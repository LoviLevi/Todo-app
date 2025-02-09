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

            List<Task> list = new List<Task>();
            int valasztas = 0;
            int id = 1;

            #region v1
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
                    Console.WriteLine("Wite down the Task's description:");
                    string desc = Console.ReadLine();
                    Console.WriteLine("Wite down the Task's expiring date (MM.DD. format):");
                    string exp = Console.ReadLine();
                    Task task1 = new Task(id,desc, exp);
                    list.Add(task1);

                    Console.Clear();
                    Console.WriteLine("Task added...");
                }
                else if (valasztas == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Tasks:");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i].Id + ". " + list[i].Description + " - " + list[i].Expiring_time);
                    }
                    Console.ReadKey();
                }
                else if (valasztas == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Quiting...");
                    Console.ReadKey();
                }
            }
            #endregion

        }
    }
}

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
            List<Task> Mondaylist = new List<Task>();
            List<Task> Tuesdaylist = new List<Task>();
            List<Task> Wednesdaylist = new List<Task>();
            List<Task> Thursdaylist = new List<Task>();
            List<Task> Fridaylist = new List<Task>();
            List<Task> Saturndaylist = new List<Task>();
            List<Task> Sundaylist = new List<Task>();

            int valasztas = 0;
            int id = 1;

            #region v1
            while (valasztas != 3)
            {
                Console.Clear();
                Console.WriteLine("1 - Show the weekly list");
                Console.WriteLine("2 - Add to a weekly list");
                Console.WriteLine("3 - Exit");

                valasztas = int.Parse(Console.ReadLine());
                if (valasztas == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Monday");

                    for (int i = 0; i < Mondaylist.Count; i++)
                    {
                        Console.WriteLine(Mondaylist[i].Description);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Tuesday");

                    for (int i = 0; i < Tuesdaylist.Count; i++)
                    {
                        Console.WriteLine(Tuesdaylist[i].Description);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Wednesday");

                    for (int i = 0; i < Wednesdaylist.Count; i++)
                    {
                        Console.WriteLine(Wednesdaylist[i].Description);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Thursday");

                    for (int i = 0; i < Thursdaylist.Count; i++)
                    {
                        Console.WriteLine(Thursdaylist[i].Description);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Friday");

                    for (int i = 0; i < Fridaylist.Count; i++)
                    {
                        Console.WriteLine(Fridaylist[i].Description);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Saturday");

                    for (int i = 0; i < Saturndaylist.Count; i++)
                    {
                        Console.WriteLine(Saturndaylist[i].Description);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Sunday");

                    for (int i = 0; i < Sundaylist.Count; i++)
                    {
                        Console.WriteLine(Sundaylist[i].Description);
                        Console.WriteLine();
                    }

                    Console.ReadKey();
                }
                else if (valasztas == 2)
                {
                    
                    Console.Clear();
                    Console.WriteLine("Wite down the Task's description:");
                    string desc = Console.ReadLine();
                    Console.WriteLine("Choose the day of the week.");
                    Console.WriteLine("1 - Monday");
                    Console.WriteLine("2 - Tuesday");
                    Console.WriteLine("3 - Wednesday");
                    Console.WriteLine("4 - Thursday");
                    Console.WriteLine("5 - Friday");
                    Console.WriteLine("6 - Saturday");
                    Console.WriteLine("7 - Sunday");
                    int daychoosed = int.Parse(Console.ReadLine());

                    Task task = new Task(id, desc, daychoosed);
                    id++;

                    if (daychoosed == 1)
                    {
                        Mondaylist.Add(task);
                    }
                    else if (daychoosed == 2)
                    {
                        Tuesdaylist.Add(task);
                    }
                    else if (daychoosed == 3)
                    {
                        Wednesdaylist.Add(task);
                    }
                    else if (daychoosed == 4)
                    {
                        Thursdaylist.Add(task);
                    }
                    else if (daychoosed == 5)
                    {
                        Fridaylist.Add(task);
                    }
                    else if (daychoosed == 6)
                    {
                        Saturndaylist.Add(task);
                    }
                    else if (daychoosed == 7)
                    {
                        Sundaylist.Add(task);
                    }
                    Console.WriteLine("Task added...");
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

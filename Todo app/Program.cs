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
            Console.WriteLine("Todo application - 2025");

            Todo task1 = new Todo(1, "Levinni a szemetet", DateTime.Now, "Le kell vinni a szemetet!") ;
            ;
            Console.WriteLine(task1);
        }
    }
    public class Todo
    {
        public int Sorszam { get; set; }
        public string Nev { get; set; }
        public DateTime Datum { get; set; }
        public string Leiras { get; set; }

        public Todo(int sorszam, string nev, DateTime datum, string leiras)
        {
            Sorszam = sorszam;
            Nev = nev;
            Datum = datum;
            Leiras = leiras;
        }
    }
}

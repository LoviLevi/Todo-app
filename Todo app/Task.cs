using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_app
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Day { get; set; }

        public Task(int id, string description, int day)
        {
            Id = id;
            Description = description;
            Day = day;
        }
        //public string Expiring_time { get; set; }


    }
}

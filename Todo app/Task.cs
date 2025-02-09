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
        public string Expiring_time { get; set; }

        public Task(int id, string description, string expiring_time)
        {
            Id = id;
            Description = description;
            Expiring_time = expiring_time;
        }
    }
}

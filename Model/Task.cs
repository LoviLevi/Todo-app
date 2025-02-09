namespace Model
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Expiring_time { get; set; }

        public Task(string description, string expiring_time)
        {
            Description = description;
            Expiring_time = expiring_time;
        }
    }
   
}

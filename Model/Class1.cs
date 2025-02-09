namespace Model
{
    public class Task
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public int Expiring_time { get; set; }

        public Task(string description, int expiring_time)
        {
            Description = description;
            Expiring_time = expiring_time;
        }
    }
   
}

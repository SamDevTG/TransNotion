namespace Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public DateTime ReminderTime { get; set; }
        public string Message { get; set; }

        // Relacionamentos
        public int TaskId { get; set; }
        public Tasks Task { get; set; }
    }
}
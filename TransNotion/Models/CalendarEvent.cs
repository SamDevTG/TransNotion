namespace Models
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Relacionamentos
        public int UserId { get; set; }
        public required User User { get; set; }
    }
}
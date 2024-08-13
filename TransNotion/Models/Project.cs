namespace Models
{
    public class Project
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Relacionamentos
        public int UserId { get; set; }
        public required User User { get; set; }
        public ICollection<Tasks>? Tasks { get; set; }
    }
}
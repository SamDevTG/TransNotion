namespace Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int Priority { get; set; } // 1-High, 2-Medium, 3-Low

        // Relacionamentos
        public int UserId { get; set; }
        public required User User { get; set; }
        public int? ProjectId { get; set; }
        public Project? Project { get; set; }
        public ICollection<Tag>? Tags { get; set; }
    }
}
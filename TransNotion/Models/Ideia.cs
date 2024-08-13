namespace Models
{
    public class Idea
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Relacionamentos
        public int UserId { get; set; }
        public required User User { get; set; }
        public ICollection<Tag>? Tags { get; set; }
    }
}
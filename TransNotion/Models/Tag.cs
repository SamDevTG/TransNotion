namespace Models
{
    public class Tag
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        // Relacionamentos
        public ICollection<Note>? Notes { get; set; }
        public ICollection<Tasks>? Tasks { get; set; }
        public ICollection<Idea>? Ideas { get; set; }
    }
}
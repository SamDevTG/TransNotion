namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Note>? Notes { get; set; }
        public ICollection<Tasks>? Tasks { get; set; }
        public ICollection<Project>? Projects { get; set; }
        public ICollection<Idea>? Ideas { get; set; }
    }
}
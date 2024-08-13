using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace TransNotion.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<CalendarEvent> CalendarEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações adicionais, se necessárias
        }
    }
}

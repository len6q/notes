using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Notes.Application.Interfaces;
using Notes.Domain;
using Notes.Persistence.EntityTypeConfigurations;
using System;
using System.Threading.Tasks;

namespace Notes.Persistence
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set ; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public Task<int> SaveChangesAsync(CancellationChangeToken cancellationChangeToken)
        {
            throw new NotImplementedException();
        }
    }
}

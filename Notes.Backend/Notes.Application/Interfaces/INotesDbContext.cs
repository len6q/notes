using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Notes.Domain;
using System.Threading.Tasks;

namespace Notes.Application.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; }
        
        Task<int> SaveChangesAsync(CancellationChangeToken cancellationChangeToken);
    }
}

using CollegeRoadSwimClub.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeRoadSwimClub.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Swimmer> Swimmers { get; }
    DbSet<Parent> Parents { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}

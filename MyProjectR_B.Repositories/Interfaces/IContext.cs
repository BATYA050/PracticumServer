using Microsoft.EntityFrameworkCore;
using MyProjectR_B.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Repositories.Interfaces
{
    public interface IContext
    {
        DbSet <User> User { get; set; }
       // DbSet <FontSize> FontSize { get; set; }
        DbSet <Children> Children { get; set; }
       // DbSet <Reportage> Reportage { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        
    }
}

using MicroS.Infrastructure.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroS.Infrastructure
{
    public interface IMicroSDBContext
    {
        DbSet<UserEntity> User { get; set; }
        DbSet<User2ComunaEntity> User2Comuna { get; set; }
        DbSet<ComunaEntity> Comuna { get; set; }
        DbSet<RegionEntity> Region { get; set; }

        //crear los metodos que nos permiten hacer los Changes de la BD
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);
    }
}

using MicroS.Infrastructure.DataAccess.Contracts.Entities;
using MicroS.Infrastructure.DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Infrastructure.DataAccess
{
    public class MicroSDBContext : DbContext, IMicroSDBContext {
        public DbSet<UserEntity> User { get; set; }
        public DbSet<User2ComunaEntity> User2Comuna{ get; set; }
        public DbSet<ComunaEntity> Comuna { get; set; }
        public DbSet<RegionEntity > Region { get; set; }

        public MicroSDBContext()
        {

        }
        //Sobrecarga del metodo ModelCreating para crear el modelo directamente cuando hacemos el esquema
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserEntityConfig.setEntityBuilder(modelBuilder.Entity<UserEntity>());
            User2ComunaEntityConfig.setEntityBuilder(modelBuilder.Entity<User2ComunaEntity>());
            ComunaEntityConfig.setEntityBuilder(modelBuilder.Entity<ComunaEntity>());
            RegionEntityConfig.setEntityBuilder(modelBuilder.Entity<RegionEntity>());
            base.OnModelCreating(modelBuilder);
        }

    }
}

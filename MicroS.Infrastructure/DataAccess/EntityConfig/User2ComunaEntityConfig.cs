using MicroS.Infrastructure.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Infrastructure.DataAccess.EntityConfig
{
    public class User2ComunaEntityConfig{
        public static void setEntityBuilder(EntityTypeBuilder<User2ComunaEntity> entityBuilder)
        {
            entityBuilder.ToTable("User2Comuna");
            entityBuilder.HasOne(x => x.User).WithMany(x => x.User2Comuna).HasForeignKey(x => x.IdUser);
            entityBuilder.HasOne(x => x.Comuna).WithMany(x => x.User2Comuna).HasForeignKey(x => x.IdCom);
            entityBuilder.HasKey(x => new { x.IdUser, x.IdCom });
            entityBuilder.Property(x => x.IdUser).IsRequired();
            entityBuilder.Property(x => x.IdCom).IsRequired();

        }
    }
}

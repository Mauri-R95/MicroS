using MicroS.Infrastructure.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Infrastructure.DataAccess.EntityConfig
{
    public class ComunaEntityConfig{
        public static void setEntityBuilder(EntityTypeBuilder<ComunaEntity> entityBuilder)
        {
            entityBuilder.ToTable("Comuna");
            entityBuilder.HasKey(x => x.IdCom);
            entityBuilder.Property(x => x.IdCom).IsRequired();
            entityBuilder.HasOne(x => x.Region).WithMany(x => x.Comuna).HasForeignKey(x => x.IdReg);
            entityBuilder.HasKey(x => x.IdReg);
            entityBuilder.Property(x => x.IdReg).IsRequired();

        }
    }
}

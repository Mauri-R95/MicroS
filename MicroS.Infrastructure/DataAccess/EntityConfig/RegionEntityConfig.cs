using MicroS.Infrastructure.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Infrastructure.DataAccess.EntityConfig
{
    public class RegionEntityConfig
    {
        public static void setEntityBuilder(EntityTypeBuilder<RegionEntity> entityBuilder)
        {
            entityBuilder.ToTable("User");  
            entityBuilder.HasKey(x => x.IdReg);
            entityBuilder.Property(x => x.IdReg).IsRequired();

        }
    }
}

using MicroS.Infrastructure.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Infrastructure.DataAccess.EntityConfig
{
    //Builder Entity : Se encarga de crear la entidad en la BD
    public class UserEntityConfig{
        public static void setEntityBuilder(EntityTypeBuilder<UserEntity> entityBuilder)
        {
            entityBuilder.ToTable("User");
            entityBuilder.HasKey(x => x.IdUser);
            entityBuilder.Property(x => x.IdUser).IsRequired();

        }
    }
}

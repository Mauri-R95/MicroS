using MicroS.Domain.Models;
using MicroS.Infrastructure.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Infrastructure.DataAccess
{
    public static class UserMapper
    {
        public static UserEntity Map(Usuario dto)
        {
            return new UserEntity()
            {
                Rut = dto.rut,
                IdUser = dto.IdUser,
                Nombre = dto.Nombre,
                ApellidoP = dto.ApellidoP,
                Active = dto.Active,
                CreateDate = dto.CreateDate
            };
        }

        public static Usuario Map(UserEntity entity)
        {
            return new Usuario()
            {
                rut = entity.Rut,
                IdUser = entity.IdUser,
                Nombre = entity.Nombre,
                ApellidoP = entity.ApellidoP,
                Active = entity.Active,
                CreateDate = entity.CreateDate
            };
        }
    }
}

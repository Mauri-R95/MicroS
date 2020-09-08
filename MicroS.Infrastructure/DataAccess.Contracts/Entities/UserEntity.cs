using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Infrastructure.DataAccess.Contracts.Entities
{
    public class UserEntity {
        public int IdUser {get;set;}
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public bool Actiive { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<User2ComunaEntity> User2Comuna { get; set; }

        
    }
}

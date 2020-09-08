using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Infrastructure.DataAccess.Contracts.Entities
{
    public class ComunaEntity{
        public int IdCom { get; set; }
        public string nombre { get; set; }
        public int IdReg { get; set; }

        public virtual RegionEntity Region { get; set; }
        public virtual ICollection<User2ComunaEntity> User2Comuna { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Infrastructure.DataAccess.Contracts.Entities
{
    public class User2ComunaEntity{
        public int IdUser { get; set; }
        public int IdCom { get; set; }

        public virtual UserEntity User { get; set; }
        public virtual ComunaEntity Comuna { get; set; }

    }
}

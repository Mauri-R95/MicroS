using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Infrastructure.DataAccess.Contracts.Entities
{
    public class RegionEntity{
        public int IdReg { get; set; }
        public string nombre { get; set; }

        public virtual ICollection<ComunaEntity> Comuna { get; set; }
    }
}

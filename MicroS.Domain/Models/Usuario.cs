using System;
using System.Collections.Generic;
using System.Text;

namespace MicroS.Domain.Models
{
    public class Usuario
    {
        public int IdUser { get; set; }
        public string rut { get; set; }
        public string Nombre { get; set; }
        public string ApellidoM { get; set; }
        public string ApellidoP { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }

    }
}

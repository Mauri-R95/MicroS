using MicroService.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Domain.Demo
{
    //ValueObject: Son objetos que no tiene una identidad real y son usados para describir aspectos de una identidad
    public class Address : ValueObject
    {
        public string Calle { get; private set;}
        public int Numero { get; private set; }
        public string Region { get; private set; }
        public string Comuna { get; private set; }
        public int CodPostal { get; private set; }

        public Address(){
        }

        public Address(string calle, int numero, string region, string comuna, int codpostal)
        {
            Calle = calle;
            Numero = numero;
            Region = region;
            Comuna = comuna;
            CodPostal = codpostal;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {

            //Se usa yield para returnar cada elemento de uno a uno
            yield return Calle;
            yield return Region;
            yield return Comuna;
            yield return CodPostal;
        }
    }
}

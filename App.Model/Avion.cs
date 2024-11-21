using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public  class Avion : Vehiculo, IMovilidad
    {
        public Avion(string nombre, string tipoDeEnergia,
            string alturaMaxima, string color, string marca) :
            base(nombre, tipoDeEnergia, color, marca)
        {
            AlturaMaxima = alturaMaxima;
        }

        public string AlturaMaxima { get; set; }

        public string Velocidad { get; private set; }

        public string Moverse()
        {            
            return "El avion solo puede volar";
        }

        public override string ToString()
        {
            return base.ToString() + $",{AlturaMaxima}";
        }
    }
}

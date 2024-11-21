using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Carro : Vehiculo, IMovilidad
    {
        public Carro(string nombre, string tipoDeEnergia,
            string tipoCarro, string color, string marca) :
            base(nombre, tipoDeEnergia, color, marca)
        {
            TipoCarro = tipoCarro;
        }

        public string TipoCarro { get; set; } //Deportivo, 4X4

        public string Velocidad { get; private set; }

        public string Moverse()
        {
            return "Desplazarce por carretera";
        }

        public override string ToString()
        {
            return base.ToString() + $",{TipoCarro}";
        }

    }
}

namespace App.Model
{
    public abstract class Vehiculo
    {
  

        protected Vehiculo(string nombre, string tipoDeEnergia,
            string color, string marca)
        {
            Nombre = nombre;
            TipoDeEnergia = tipoDeEnergia;
            Color = color;
            Marca = marca;
        }

        public string Nombre { get; set; }
        public string TipoDeEnergia { get; set; } // Gasolina, electrico, hidrogeno
        public string Color { get; set; }
        public string Marca{ get; set; }

        public override string ToString()
        {
            return $"Nombre:{Nombre}, Tipo de energia {TipoDeEnergia}";
        }
    }
}

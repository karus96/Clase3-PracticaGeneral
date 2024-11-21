using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public interface IMovilidad
    {
        public string Velocidad {  get; }

        public string Moverse();
    }
}

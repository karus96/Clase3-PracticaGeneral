using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    public class Mediator
    {
        private static Mediator _instance;
        public static Mediator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Mediator();
                }
                return _instance;
            }
        }
        private Mediator() { }

        public ISave ObtenerNuevoSave()
        {
            return new Salvar();
        }
    }
}

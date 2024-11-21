using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    public class Salvar : ISave
    {
        public string Path { get; set; }

        public bool Save(string data)
        {
            try
            {
                File.WriteAllText(Path, data);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

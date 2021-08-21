using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReposicionAllan.Clases
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        protected string Presentacion { get; set; }
        
        public virtual void Saludar()
        {
            Presentacion = $"Hola mi nombre es {Nombres} {Apellidos } \nvivo en {Direccion}";
            MessageBox.Show(Presentacion);
        }
    }
}

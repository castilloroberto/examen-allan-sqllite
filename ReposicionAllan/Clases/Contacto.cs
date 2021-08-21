using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReposicionAllan.Clases
{
    public class Contacto:Persona
    {
        public int Id { get; set; }
        public string  Codigo { get; set; }
        public string Telfijo { get; set; }
        public string Celular { get; set; }

        public override void Saludar()
        {
            Presentacion = $"Hola mi nombre es {Nombres} {Apellidos } \nvivo en {Direccion}\n" +
                $"Mi telefono fijo es {Telfijo} y mi telefono celular es {Celular}";
            MessageBox.Show(Presentacion);
        }
    }
}

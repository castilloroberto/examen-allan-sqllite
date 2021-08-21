using ReposicionAllan.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReposicionAllan
{
    public partial class AgregarContacto : Form
    {
        public AgregarContacto()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto()
            {
                Nombres = nombres.Text,
                Apellidos = apellidos.Text,
                Celular = telcelular.Text,
                Codigo = cod.Text,
                Direccion = direccion.Text,
                
            };
            DataBase.InsertarContacto(contacto);
            this.Close();
        }
    }
}

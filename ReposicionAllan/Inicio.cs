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
    public partial class Inicio : Form
    {
        List<Contacto> contactos = new List<Contacto>();
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            CargarContactos();
        }
        private void CargarContactos()
        {
            contactos = DataBase.ObtenerContactos();
            dgv_contactos.DataSource = null;
            dgv_contactos.DataSource = contactos;
        }


        private void ingresar_Click(object sender, EventArgs e)
        {
            var agregarContacto = new AgregarContacto();
            agregarContacto.ShowDialog();
            CargarContactos();

        }
        private dynamic getCell(int cell)
        {
            int fila = dgv_contactos.CurrentRow.Index;
            return dgv_contactos.Rows[fila].Cells[cell].Value;

        }
        private void dgv_contactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgv_contactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = getCell(0);

            var contacto = contactos.Find((contact) => contact.Id == id);
            contacto.Saludar();
        }
    }
}

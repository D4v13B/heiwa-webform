using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Reportes : Form
    {
        // Referencias a los demás formularios
        private Main mainForm;
        private Form usuariosForm;
        private Form ordenesForm;
        private Form productosForm;
        private Form ingredientesForm;
        private Form promocionesForm;

        public Reportes()
        {
            InitializeComponent();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form usuarios,  Form ordenes, Form productos, Form ingredientes, Form promociones)
        {
            mainForm = main;
            usuariosForm = usuarios;
            ordenesForm = ordenes;
            productosForm = productos;
            ingredientesForm = ingredientes;
            promocionesForm = promociones;
        }

        // Manejo de botones
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CambiarFormulario(usuariosForm);
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            CambiarFormulario(ordenesForm);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            CambiarFormulario(productosForm);
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            CambiarFormulario(ingredientesForm);
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            CambiarFormulario(promocionesForm);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        // Método para ocultar el actual y mostrar el siguiente formulario
        private void CambiarFormulario(Form formularioDestino)
        {
            this.Hide(); // Ocultar el formulario actual
            formularioDestino.Show(); // Mostrar el formulario destino
        }


    }
}

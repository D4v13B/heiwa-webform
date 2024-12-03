using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Promociones : Form
    {
        // Referencias a los demás formularios
        private Main mainForm;
        private Form usuariosForm;
        private Form ordenesForm;
        private Form productosForm;
        private Form ingredientesForm;
        private Form reportesForm;

        public Promociones()
        {
            InitializeComponent();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form usuarios, Form ordenes, Form productos, Form ingredientes, Form reportes)
        {
            mainForm = main;
            usuariosForm = usuarios;
            ordenesForm = ordenes;
            productosForm = productos;
            ingredientesForm = ingredientes;
            reportesForm = reportes;
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
        private void btnReportes_Click(object sender, EventArgs e)
        {
            CambiarFormulario(reportesForm);
        }

        // Método para ocultar el actual y mostrar el siguiente formulario
        private void CambiarFormulario(Form formularioDestino)
        {
            this.Hide(); // Ocultar el formulario actual
            formularioDestino.Show(); // Mostrar el formulario destino
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }
    }
}

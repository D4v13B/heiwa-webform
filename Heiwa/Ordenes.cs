using System;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Ordenes : Form
    {
        private Main mainForm;
        private Form usuariosForm;
        private Form productosForm;
        private Form ingredientesForm;

        public Ordenes()
        {
            InitializeComponent();
        }

        public void ConfigurarFormularios(Main main, Form usuarios, Form productos, Form ingredientes)
        {
            mainForm = main;
            usuariosForm = usuarios;
            productosForm = productos;
            ingredientesForm = ingredientes;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CambiarFormulario(usuariosForm);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            CambiarFormulario(productosForm);
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            CambiarFormulario(ingredientesForm);
        }

        private void CambiarFormulario(Form formularioDestino)
        {
            this.Hide();
            formularioDestino.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void gBoxRegistrar_Enter(object sender, EventArgs e)
        {

        }
    }
}

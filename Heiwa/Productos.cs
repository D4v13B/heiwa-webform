using System;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Productos : Form
    {
        private Main mainForm;
        private Form usuariosForm;
        private Form ordenesForm;
        private Form ingredientesForm;

        public Productos()
        {
            InitializeComponent();
        }

        public void ConfigurarFormularios(Main main, Form usuarios, Form ordenes, Form ingredientes)
        {
            mainForm = main;
            usuariosForm = usuarios;
            ordenesForm = ordenes;
            ingredientesForm = ingredientes;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CambiarFormulario(usuariosForm);
        }

        private void btnOrdenes_Click_1(object sender, EventArgs e)
        {
            CambiarFormulario(ordenesForm);
        }
        private void btnIngredientes_Click_1(object sender, EventArgs e)
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
    }
}

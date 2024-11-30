using System;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Ingredientes : Form
    {
        private Main mainForm;
        private Form usuariosForm;
        private Form ordenesForm;
        private Form productosForm;

        public Ingredientes()
        {
            InitializeComponent();
        }

        public void ConfigurarFormularios(Main main, Form usuarios, Form ordenes, Form productos)
        {
            mainForm = main;
            usuariosForm = usuarios;
            ordenesForm = ordenes;
            productosForm = productos;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CambiarFormulario(usuariosForm);
        }

        private void btnOrdenes_Click_1(object sender, EventArgs e)
        {
            CambiarFormulario(ordenesForm);
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            CambiarFormulario(productosForm);
        }

        private void CambiarFormulario(Form formularioDestino)
        {
            this.Hide();
            formularioDestino.Show();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }
    }
}

using System;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Productos : Form
    {
        // Referencias a los demás formularios
        private Main mainForm;
        private Form usuariosForm;
        private Form ordenesForm;
        private Form ingredientesForm;
        private Form promocionesForm;

        public Productos()
        {
            InitializeComponent();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form usuarios, Form ordenes, Form ingredientes, Form promociones)
        {
            mainForm = main;
            usuariosForm = usuarios;
            ordenesForm = ordenes;
            ingredientesForm = ingredientes;
            promocionesForm = promociones;
        }

        // Manejo de botones
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
        private void btnPromociones_Click(object sender, EventArgs e)
        {
            CambiarFormulario(promocionesForm);
        }

        // Método para ocultar el actual y mostrar el siguiente formulario
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

using System;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Ingredientes : Form
    {
        // Referencias a los demás formularios
        private Main mainForm;
        private Form usuariosForm;
        private Form ordenesForm;
        private Form productosForm;
        private Form promocionesForm;

        public Ingredientes()
        {
            InitializeComponent();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form usuarios, Form ordenes, Form productos, Form promociones)
        {
            mainForm = main;
            usuariosForm = usuarios;
            ordenesForm = ordenes;
            productosForm = productos;
            promocionesForm = promociones;
        }

        // Manejo de botones
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CambiarFormulario(usuariosForm);
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            CambiarFormulario(productosForm);
        }
        private void btnPromociones_Click(object sender, EventArgs e)
        {
            CambiarFormulario(promocionesForm);
        }
        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            CambiarFormulario(ordenesForm);
        }

        // Método para ocultar el actual y mostrar el siguiente formulario
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

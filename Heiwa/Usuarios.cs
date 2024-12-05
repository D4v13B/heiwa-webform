using Heiwa.Models;
using Heiwa.Services;
using System;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Usuarios : Form
    {
        // Referencias a los demás formularios
        private Main mainForm;
        private Form ordenesForm;
        private Form productosForm;
        private Form ingredientesForm;
        private Form promocionesForm;
        private Form reportesForm;

        public Usuarios()
        {
            InitializeComponent();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form ordenes, Form productos, Form ingredientes, Form promociones, Form reportes)
        {
            mainForm = main;
            ordenesForm = ordenes;
            productosForm = productos;
            ingredientesForm = ingredientes;
            promocionesForm = promociones;
            reportesForm = reportes;
        }

        // Manejo de botones
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

        //Esto me va a guardar el usuario
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            var nombre = txtNewNombre.Text;
            var correo = txtNewCorreo.Text;
            var password = txtNewPassword.Text;
            var telefono = txtNewTelefono.Text;
            var tipo = lbxNewEstado.Text;
            int tipoId = 1;

            if(tipo == "Cliente")
            {
                tipoId = 2;
            }

            UsuarioRequest usuarioRequest = new UsuarioRequest()
            {
                Nombre = nombre,
                Password = password,
                Email = correo,
                Telefono = telefono,
                UsuarioTipoId = tipoId
            };

            try
            {
                await ServiceAPI.SaveUsuarioAsync(usuarioRequest);
                txtNewNombre.Text = "";
                txtNewCorreo.Text = "";
                txtNewPassword.Text = "";
                txtNewTelefono.Text = "";
                MessageBox.Show("Usuario guardado en la base de Datos");
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error al momento de guardar el usuario {ex.Message}");
            }
        }
    }
}

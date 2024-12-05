using Heiwa.Models;
using Heiwa.Services;
using System;
using System.Collections.Generic;
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
            LoadDataGridView();
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
            formularioDestino.Show(); // Mostrar el formulario destinox
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

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(tipo)) {
                MessageBox.Show("Todos los campos son requeridos");
                return;
            }

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

        private async void LoadDataGridView()
        {
            List<Usuario> users = await ServiceAPI.GetUsuarios();
            if (users.Count > 0)
            {
                dgvtUsuarios.DataSource = users; // Asigna la lista directamente como fuente de datos

                // Personaliza las columnas si es necesario
                dgvtUsuarios.Columns["UsuarioTipo"].Visible = false; // Oculta el objeto UsuarioTipo
                dgvtUsuarios.Columns["LastLogin"].Visible = false; // Oculta el objeto UsuarioTipo
                dgvtUsuarios.Columns["DateJoined"].Visible = false; // Oculta el objeto UsuarioTipo
                dgvtUsuarios.Columns["UsuarioTipoId"].Visible = false; // Oculta el objeto UsuarioTipo
                //dgvtUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                //{
                //    HeaderText = "Tipo de Usuario",
                //    Name = "tipoNombre",
                //    DataPropertyName = "tipoNombre"
                //});
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }

        private void dgvtUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el clic no sea en el encabezado
            if (e.RowIndex >= 0)
            {
                // Obtén el objeto de la fila seleccionada
                var selectedRow = dgvtUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;

                if (selectedRow != null)
                {
                    // Puedes llamar a métodos o actualizar controles con la información
                    MostrarDetalleUsuario(selectedRow);
                }
            }
        }

        private void MostrarDetalleUsuario(Usuario usuario)
        {
            // Muestra la información en controles del formulario
            txtID.Text = usuario.Id.ToString();
            txtNombre.Text = usuario.Nombre;
            txtCorreo.Text = usuario.Email;
            txtPassword.Text = usuario.Password;
            txtTelefono.Text = usuario.Telefono;
            cmbTipo.SelectedIndex = usuario.UsuarioTipoId;
        }

        //Boton de modificar
        private async void button1_Click(object sender, EventArgs e)
        {

        }


        //Btn de eliminar
        private async void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}

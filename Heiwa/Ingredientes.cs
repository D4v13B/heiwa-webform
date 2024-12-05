using Heiwa.Models;
using Heiwa.Services;
using System;
using System.Net.Http;
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
        private Form reportesForm;

        public Ingredientes()
        {
            InitializeComponent();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form usuarios, Form ordenes, Form productos, Form promociones, Form reportes)
        {
            mainForm = main;
            usuariosForm = usuarios;
            ordenesForm = ordenes;
            productosForm = productos;
            promocionesForm = promociones;
            reportesForm = reportes;
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
        private void btnReportes_Click(object sender, EventArgs e)
        {
            CambiarFormulario(reportesForm);
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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text;
            string medida = txtMedida.Text;
            if (string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(medida))
            {
                MessageBox.Show("Debe llenar los campos vacíos.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            var ingredienteRequest = new IngredienteRequest
            {
                Nombre = nombre,
                Stock = cantidad,
                UnidadMedida = medida
            };
            try
                {
                    await ServiceAPI.SaveIngredienteAsync(ingredienteRequest);
                    MessageBox.Show("Ingrediente guardado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el ingrediente: {ex.Message}");
                }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            
                
                if (!int.TryParse(txtID.Text, out int id))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.");
                    return;
                }

                try
                {
                    
                    await ServiceAPI.DeleteIngredienteAsync(id);

                    MessageBox.Show("Ingrediente eliminado correctamente.");

                   
                }
                
                catch (HttpRequestException ex)
                {
                    if (ex.Message.Contains("400"))
                    {
                        MessageBox.Show("Solicitud inválida. Verifique que el ID sea correcto y válido.");
                    }
                    else if (ex.Message.Contains("404"))
                    {
                        MessageBox.Show("No se encontró ningún ingrediente con el ID proporcionado.");
                    }
                    else
                    {
                        MessageBox.Show($"Error al intentar eliminar el ingrediente: {ex.Message}");
                    }
                 }
                catch (Exception ex)
                {
                    MessageBox.Show($"Se produjo un error inesperado: {ex.Message}");
                }
            

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                return;
            }
            string nombre = txtBoxNombre.Text;
            string medida = txtMedida.Text;
            if (string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(medida))
            {
                MessageBox.Show("Debe llenar los campos vacíos.");
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }
            

            var ingredienteRequest = new IngredienteRequest
            {
                Nombre = nombre,
                Stock = cantidad,
                UnidadMedida = medida
            };

            try
            {
                await ServiceAPI.UpdateIngredienteAsync(id, ingredienteRequest);
                MessageBox.Show("Ingrediente guardado exitosamente.");

            }
            catch (HttpRequestException ex)
            {
                if (ex.Message.Contains("400"))
                {
                    MessageBox.Show("Solicitud inválida. Verifique que el ID sea correcto y válido.");
                }
                else if (ex.Message.Contains("404"))
                {
                    MessageBox.Show("No se encontró ningún ingrediente con el ID proporcionado.");
                }
                else
                {
                    MessageBox.Show($"Error al intentar eliminar el ingrediente: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error inesperado: {ex.Message}");
            }
        }
    }
}

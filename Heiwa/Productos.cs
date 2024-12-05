using Heiwa.Models;
using Heiwa.Services;
using System;
using System.Net.Http;
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
        private Form reportesForm;

        public Productos()
        {
            InitializeComponent();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form usuarios, Form ordenes, Form ingredientes, Form promociones, Form reportes)
        {
            mainForm = main;
            usuariosForm = usuarios;
            ordenesForm = ordenes;
            ingredientesForm = ingredientes;
            promocionesForm = promociones;
            reportesForm = reportes;
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
           
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                string tipoSelect = cbxTipo.SelectedItem.ToString();
                string medida = cbxMedida.SelectedItem.ToString();
                int idTipo;

                

                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Por favor, ingrese un nombre válido.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Por favor, ingrese una descripción válida.");
                    return;
                }

                switch (tipoSelect)
                {
                    case "Entrante":
                        idTipo = 1;
                        break;
                    case "Sopa":
                        idTipo = 2;
                        break;
                    case "Bebida alcohólica":
                        idTipo = 3;
                        break;
                    default:
                        MessageBox.Show("Tipo de producto no reconocido.");
                        return;
                }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un precio válido.");
                    return;
                }


                var productoRequest = new ProductoRequest
                {

                    Nombre = nombre,
                    Precio = precio,
                    Descripcion = descripcion,
                    UnidadMedida = medida,
                    ProductoTipoId = idTipo,
                    Foto = "sin imagen",
                };

                try
                {
                    await ServiceAPI.SaveProductAsync(productoRequest);
                    MessageBox.Show("Producto guardado exitosamente.");
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error al guardar: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el producto: {ex.Message}");
                }
            

        }

        private async void button3_Click(object sender, EventArgs e)
        {
                if (!int.TryParse(txtId.Text, out int productoId))
                {
                    MessageBox.Show("Por favor, ingrese un ID de producto válido.");
                    return;
                }

                string nombre = txtName.Text;
                string descripcion = txtDescription.Text;
                string tipoSelect = cbxType.SelectedItem.ToString();
                string medida = cbxMed.SelectedItem.ToString();
                int idTipo;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("No puede dejar campos vacíos.");
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un precio válido.");
                    return;
                }
                switch (tipoSelect)
                {
                    case "Entrante":
                        idTipo = 1;
                        break;
                    case "Sopa":
                        idTipo = 2;
                        break;
                    case "Bebida alcohólica":
                        idTipo = 3;
                        break;
                    default:
                        MessageBox.Show("Tipo de producto no reconocido.");
                        return;
                }

            var productoRequest = new ProductoRequest
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Precio = precio,
                    UnidadMedida = medida,
                    ProductoTipoId = idTipo,
                    Foto = "sin imagen"
                };

                try
                {
                    await ServiceAPI.UpdateProductAsync(productoId, productoRequest);
                    MessageBox.Show("Producto actualizado exitosamente.");
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
                    MessageBox.Show($"Error al actualizar el producto: {ex.Message}");
                }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int productoId))
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.");
                return;
            }

            try
            {
                await ServiceAPI.DeleteProductAsync(productoId);
                MessageBox.Show("Producto eliminado exitosamente.");
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
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
            }
        }
    }
}

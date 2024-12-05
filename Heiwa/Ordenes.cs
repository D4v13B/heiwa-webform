using Heiwa.Models;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Heiwa.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Linq;

namespace Heiwa
{
    public partial class Ordenes : Form
    {
        List<DetalleOrdenRequest> detalles = new List<DetalleOrdenRequest> ();
        List<Producto> productsDetails = new List<Producto> ();
        List<Producto> productoList = new List<Producto> ();
        List<Promocion> promociones = new List<Promocion> ();
        // Referencias a los demás formularios
        private Main mainForm;
        private Form usuariosForm;
        private Form productosForm;
        private Form ingredientesForm;
        private Form promocionesForm;
        private Form reportesForm;

        public Ordenes()
        {
            InitializeComponent();
            loadDataProductsList();
            LoadUsersToComboBox();
            LoadPaysToComboBox();
            obtenerPromociones();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form usuarios, Form productos, Form ingredientes, Form promociones, Form reportes)
        {
            mainForm = main;
            usuariosForm = usuarios;
            productosForm = productos;
            ingredientesForm = ingredientes;
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

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            CambiarFormulario(ingredientesForm);
        }
        private void btnPromociones_Click_1(object sender, EventArgs e)
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

        public async void loadDataProductsList()
        {
            try
            {
                productoList = await ServiceAPI.GetProductsAsync();

                if (productoList.Count > 0)
                {
                    dgvProductos.DataSource = productoList; // Asigna la lista directamente como fuente de datos
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén el objeto de la fila seleccionada
                var selectedRow = dgvProductos.Rows[e.RowIndex].DataBoundItem as Producto;

                if (selectedRow != null)
                {
                    productsDetails.Add(selectedRow);
                    detalles.Add(new DetalleOrdenRequest() { ProductoId = selectedRow.Id, Cantidad = 1, Precio = selectedRow.Precio });
                    LoadDataGridOrdenDetalles();

                    verifyPromociones();
                }
            }
        }

        private void LoadDataGridOrdenDetalles()
        {
            decimal counter = 0;
            dgvDetalleOrden.DataSource = null;
            if (productsDetails.Count > 0)
            {
                dgvDetalleOrden.DataSource = productsDetails;
            }

            foreach (Producto producto in productsDetails)
            {
                counter += producto.Precio;
            }

            lblPrecio.Text = $"Total: ${counter.ToString()}";
        }

        private void verifyPromociones()
        {
            // Lista para almacenar las promociones con los productos asociados
            List<string> promocionesAplicadas = new List<string>();

            // Recorremos todos los productos de la lista productoList
            foreach (var producto in productoList)
            {
                // Verificar si hay promociones aplicables a este producto
                var promocionesAplicables = promociones.Where(p => p.Detalles.Any(pd => pd.ProductoId == producto.Id)).ToList();

                // Si existen promociones para este producto, actualizamos el precio
                foreach (var promocion in promocionesAplicables)
                {
                    // Aquí estamos agregando todos los productos de la promoción
                    var productosDePromocion = string.Join(", ", promocion.Detalles.Select(pd => pd.ProductoId));

                    // Actualizamos el precio del producto en productoList
                    producto.Precio = promocion.Precio;

                    // Buscar el detalle correspondiente y actualizar su precio también
                    var detalle = detalles.FirstOrDefault(d => d.ProductoId == producto.Id);
                    if (detalle != null)
                    {
                        detalle.Precio = promocion.Precio;
                    }

                    // Agregar mensaje de la promoción
                    promocionesAplicadas.Add($"Promoción '{promocion.Nombre}' aplicada a los productos: {productosDePromocion}");
                }
            }

            // Si hay promociones aplicadas, mostrar un mensaje con los detalles
            if (promocionesAplicadas.Count > 0)
            {
                string mensajePromociones = "Promociones aplicadas:\n" + string.Join("\n", promocionesAplicadas);
                MessageBox.Show(mensajePromociones, "Promociones Aplicadas");
            }
            else
            {
                MessageBox.Show("No se aplicaron promociones a los productos.", "Sin Promociones");
            }

            // Actualizar la vista de los detalles de la orden con los nuevos precios
            LoadDataGridOrdenDetalles();
        }



        private async void LoadUsersToComboBox()
        {
            List<Usuario> users = await ServiceAPI.GetUsuarios();

            cmbUsuario.DataSource = users;
            cmbUsuario.DisplayMember = "Email";
            cmbUsuario.ValueMember = "Id";

            if (cmbUsuario.Items.Count > 0)
            {
                cmbUsuario.SelectedIndex = 0; // Selecciona el primer ítem
            }

        }

        private async void LoadPaysToComboBox()
        {
            List<MetodoPago> paymethods = await ServiceAPI.GetMetodosPagoAsync();

            cmbMetodoPago.DataSource = paymethods;
            cmbMetodoPago.DisplayMember = "Nombre";
            cmbMetodoPago.ValueMember = "Id";

            if (cmbMetodoPago.Items.Count > 0)
            {
                cmbMetodoPago.SelectedIndex = 0; // Selecciona el primer ítem
            }

        }

        //Vender
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var observacion = txtObservaciones.Text;
                var payId = Convert.ToInt32(cmbMetodoPago.SelectedValue);
                var userId = Convert.ToInt32(cmbUsuario.SelectedValue);

                if(detalles.Count == 0)
                {
                    MessageBox.Show("Orden incompleta, selecciona algunos productos");
                    return;
                }

                OrdenRequest ordenRequest = new OrdenRequest()
                {
                    Fecha = DateTime.Now,
                    ObservacionCliente = observacion,
                    MetodoPagoId = payId,
                    UsuarioId = userId,
                    OrdenEstadoId = 4,
                    DetalleOrden = detalles
                };

                await ServiceAPI.SaveOrdenAsync(ordenRequest);
                MessageBox.Show("Se ha registrado la orden correctamente");
                detalles.Clear();
                productsDetails.Clear();

                LoadDataGridOrdenDetalles();

            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private async void obtenerPromociones()
        {
            try
            {
                promociones = await ServiceAPI.GetPromocionesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dgvDetalleOrden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén el objeto de la fila seleccionada
                var selectedRow = dgvProductos.Rows[e.RowIndex].DataBoundItem as Producto;

                if (selectedRow != null)
                {
                    productsDetails.Remove(selectedRow);
                    detalles.Remove(new DetalleOrdenRequest() { ProductoId = selectedRow.Id, Cantidad = 1, Precio = selectedRow.Precio });
                    LoadDataGridOrdenDetalles();

                    verifyPromociones();
                }
            }
        }
    }
}

using Heiwa.Models;
using Heiwa.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heiwa
{

    public partial class Promociones : Form
    {
        List<PromocionDetalleRequest> detalle = new List<PromocionDetalleRequest>();
        List<Producto> productosSeleccionado = new List<Producto>();
        List<ProductPromocion> productosPromocionRequest = new List<ProductPromocion>();

        // Referencias a los demás formularios
        private Main mainForm;
        private Form usuariosForm;
        private Form ordenesForm;
        private Form productosForm;
        private Form ingredientesForm;
        private Form reportesForm;

        public Promociones()
        {
            InitializeComponent();
            LoadDataGridProductos();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form usuarios, Form ordenes, Form productos, Form ingredientes, Form reportes)
        {
            mainForm = main;
            usuariosForm = usuarios;
            ordenesForm = ordenes;
            productosForm = productos;
            ingredientesForm = ingredientes;
            reportesForm = reportes;
        }

        // Manejo de botones
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CambiarFormulario(usuariosForm);
        }
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

        private async void LoadDataGridProductos()
        {
            List<Producto> products = await ServiceAPI.GetProductsAsync();
            if (products.Count > 0)
            {
                dgvPromocionDetalle.DataSource = products; // Asigna la lista directamente como fuente de datos
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }

        private async void LoadDataGridDetallePromocion()
        {
            
        }

        private void LoadDataGridPromocion()
        {
            decimal counter = 0;
            if (detalle.Count > 0)
            {
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productosSeleccionado;
            }

            foreach (Producto producto in productosSeleccionado)
            {
                counter += producto.Precio;
            }

            lblPrecio.Text = $"Total: ${counter.ToString()}";
        }

        private void dgvPromocionDetalle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPromocionDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el clic no sea en el encabezado
            if (e.RowIndex >= 0)
            {
                // Obtén el objeto de la fila seleccionada
                var selectedRow = dgvPromocionDetalle.Rows[e.RowIndex].DataBoundItem as Producto;

                if (selectedRow != null)
                {
                    detalle.Add(new PromocionDetalleRequest()
                    {
                        ProductoId = selectedRow.Id
                    });
                    productosPromocionRequest.Add(new ProductPromocion()
                    {
                        productId = selectedRow.Id
                    });
                    productosSeleccionado.Add(selectedRow);
                    LoadDataGridPromocion();
                }
            }
        }

        //Boton para guardar la promocion
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombre.Text;
                DateTime dateinit;
                DateTime dateend;

                if(string.IsNullOrEmpty(dateInit.ToString()) || string.IsNullOrEmpty(dateEnd.ToString()) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Por favor, insertar valores válidos");
                    return;
                }

                if (productosSeleccionado.Count == 0) 
                {
                    MessageBox.Show("No existe productos para la promoción");
                    return;
                }

                bool isDateInitValid = DateTime.TryParse(dateInit.ToString(), out dateinit);
                bool isDateEndValid = DateTime.TryParse(dateEnd.ToString(), out dateend);

                var precio = Convert.ToInt32(txtPrecio.Text);

                if (precio < 0) 
                {
                    MessageBox.Show("Por favor, insertar precio válido");
                    return;
                }
                //Crear los objetos
                PromocionRequest promocionRequest = new PromocionRequest()
                {
                    Nombre = nombre,
                    FechaValidezInicio = dateinit,
                    FechaValidezFinal = dateend,
                    Precio = precio,
                    Productos = productosPromocionRequest,
                };

                //Hacer llamado a la API
                await ServiceAPI.SavePromocionAsync(promocionRequest);
                MessageBox.Show("Se ha registrado la promocion");
                productosSeleccionado.Clear();
                productosPromocionRequest.Clear();
                LoadDataGridPromocion();
                detalle.Clear();

                txtNombre.Text = "";
                txtPrecio.Text = "0";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

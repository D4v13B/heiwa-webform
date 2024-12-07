using Heiwa.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Reportes : Form
    {
        // Referencias a los demás formularios
        private Main mainForm;
        private Form usuariosForm;
        private Form ordenesForm;
        private Form productosForm;
        private Form ingredientesForm;
        private Form promocionesForm;

        public Reportes()
        {
            InitializeComponent();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form usuarios,  Form ordenes, Form productos, Form ingredientes, Form promociones)
        {
            mainForm = main;
            usuariosForm = usuarios;
            ordenesForm = ordenes;
            productosForm = productos;
            ingredientesForm = ingredientes;
            promocionesForm = promociones;
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

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            CambiarFormulario(promocionesForm);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        // Método para ocultar el actual y mostrar el siguiente formulario
        private void CambiarFormulario(Form formularioDestino)
        {
            this.Hide(); // Ocultar el formulario actual
            formularioDestino.Show(); // Mostrar el formulario destino
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            dgvReporte.DataSource = null;
            if (rbReporte1.Checked == true)
            {
                MessageBox.Show("Seleccionaste la opción 1");
                var reporteProducto = await ServiceAPI.ReporteProducto();

                dgvReporte.DataSource = reporteProducto;
            }
            else if (rbReporte2.Checked == true)
            {
                //Por metodo de pago
                //MessageBox.Show("Seleccionaste la opción 2");
                var reporteMetodoPago = await ServiceAPI.ReporteMetodoPago();

                dgvReporte.DataSource = reporteMetodoPago;
            }
            else if (rbReporte3.Checked == true)
            {
                // Ordenes realizadas
                //MessageBox.Show("Seleccionaste la opción 3");
                var reporteOrdenes = await ServiceAPI.ReporteOrdenes();

                reporteOrdenes.Columns.Remove("fecha");
                reporteOrdenes.Columns.Remove("metodoPagoId");
                reporteOrdenes.Columns.Remove("ordenEstadoId");
                reporteOrdenes.Columns.Remove("usuarioId");
                reporteOrdenes.Columns.Remove("metodoPago");
                reporteOrdenes.Columns.Remove("ordenEstado");

               reporteOrdenes.Columns.Remove("usuario");
                reporteOrdenes.Columns.Remove("ordenDetalles");

                dgvReporte.DataSource = reporteOrdenes;
            }
            else if (rbReporte4.Checked == true)
            {
                var reporteTop10 = await ServiceAPI.Top10(dateTimePicker1.Text, dateTimePicker2.Text);

                dgvReporte.DataSource = reporteTop10;
            }
            else if(rbReporte5.Checked == true)
            {
                //MessageBox.Show("Seleccionaste la opción 5");

                var stockIngrediente = await ServiceAPI.StockIngrediente();

                dgvReporte.DataSource= stockIngrediente;
            }
            else
            {
                MessageBox.Show("No hay ninguna opción seleccionada");
            }
        }

        private void rbReporte5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

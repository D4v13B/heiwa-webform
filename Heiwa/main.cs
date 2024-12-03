using System;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Main : Form
    {
        // Declarar las instancias como campos de clase
        private Usuarios usuariosForm;
        private Ordenes ordenesForm;
        private Productos productosForm;
        private Ingredientes ingredientesForm;
        private Promociones promocionesForm;
        private Reportes reportesForm;

        public Main()
        {
            InitializeComponent();

            // Crear las instancias de todos los formularios
            usuariosForm = new Usuarios();
            ordenesForm = new Ordenes();
            productosForm = new Productos();
            ingredientesForm = new Ingredientes();
            promocionesForm = new Promociones();
            reportesForm = new Reportes();

            // Pasar referencias de los formularios entre sí
            usuariosForm.ConfigurarFormularios(this, ordenesForm, productosForm, ingredientesForm, promocionesForm, reportesForm);
            ordenesForm.ConfigurarFormularios(this, usuariosForm, productosForm, ingredientesForm, promocionesForm, reportesForm);
            productosForm.ConfigurarFormularios(this, usuariosForm, ordenesForm, ingredientesForm, promocionesForm, reportesForm);
            ingredientesForm.ConfigurarFormularios(this, usuariosForm, ordenesForm, productosForm, promocionesForm, reportesForm);
            promocionesForm.ConfigurarFormularios(this, usuariosForm, ordenesForm, productosForm, ingredientesForm, reportesForm);
            reportesForm.ConfigurarFormularios(this, usuariosForm, ordenesForm, productosForm, ingredientesForm, promocionesForm);
        }

        private void AbrirAdminWindow()
        {
            // Mostrar el formulario principal con el menú
            usuariosForm.Show();
            this.Hide(); // Ocultar el formulario de inicio de sesión
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AbrirAdminWindow();
        }
    }
}

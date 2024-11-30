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

        public Main()
        {
            InitializeComponent();

            // Crear las instancias de todos los formularios
            usuariosForm = new Usuarios();
            ordenesForm = new Ordenes();
            productosForm = new Productos();
            ingredientesForm = new Ingredientes();

            // Pasar referencias de los formularios entre sí
            usuariosForm.ConfigurarFormularios(this, ordenesForm, productosForm, ingredientesForm);
            ordenesForm.ConfigurarFormularios(this, usuariosForm, productosForm, ingredientesForm);
            productosForm.ConfigurarFormularios(this, usuariosForm, ordenesForm, ingredientesForm);
            ingredientesForm.ConfigurarFormularios(this, usuariosForm, ordenesForm, productosForm);
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

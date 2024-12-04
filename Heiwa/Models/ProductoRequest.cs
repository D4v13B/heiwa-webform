namespace Heiwa.Models
{
    public class ProductoRequest
    {
        public  string Nombre { get; set; }
        public  decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public int ProductoTipoId { get; set; }
        public string Foto { get; set; }
    }
}

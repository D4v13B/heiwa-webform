namespace Heiwa.Models
{
    public class UsuarioRequest
    {
        public  string Nombre { get; set; }
        public  string Password { get; set; }
        public  string Email { get; set; }
        public string Telefono { get; set; }
        public int UsuarioTipoId { get; set; }
    }
}

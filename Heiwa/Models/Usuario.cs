using System;

namespace Heiwa.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public  string Nombre { get; set; }
        public  string Password { get; set; }
        public  string Email { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime DateJoined { get; set; }
        public int UsuarioTipoId { get; set; }

        // Relación con UsuarioTipo
        public UsuarioTipo UsuarioTipo { get; set; }
    }

}

namespace UsuariosApp.API.Models
{
    public class Usuario
    {
        public Guid Id { get; set; } = new Guid();
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Perfil Perfil { get; set; } = Perfil.Usuario;
    }

    public enum Perfil
    {
        Administrador = 1,
        Usuario = 2
    }
}

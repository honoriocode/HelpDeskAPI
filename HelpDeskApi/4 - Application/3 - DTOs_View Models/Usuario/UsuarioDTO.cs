using HelpDeskApi.Domain.Models;

namespace HelpDeskApi.Data.DTOs

{
    public class UsuarioDTO
    {
        public object usuario;

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Guid TipoUsuarioId { get; set; }
        public int Contato { get; set; }

        public UsuarioDTO(Usuario usuario)
        {
            Id = usuario.Id;
            Nome = usuario.Nome;
            Login = usuario.Login;
            Senha = usuario.Senha;
            TipoUsuarioId = usuario.TipoUsuarioId;
            Contato = usuario.Contato;
        }

        public UsuarioDTO(object usuario)
        {
            this.usuario = usuario;
        }
    }

}

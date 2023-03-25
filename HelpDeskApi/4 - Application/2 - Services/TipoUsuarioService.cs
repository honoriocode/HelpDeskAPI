
public class TipoUsuarioService
{
    private readonly List<TipoUsuario> tipoUsuarios;

    public TipoUsuarioService()
    {
        tipoUsuarios = new List<TipoUsuario>();
    }

    public void AdicionaTipoUsuario(TipoUsuario tipoUsuario)
    {
        tipoUsuarios.Add(tipoUsuario);
    }
}


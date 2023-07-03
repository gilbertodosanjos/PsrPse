using PsrPse.Domain.Arguments.Usuario;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceUsuario : IServiceBase
{
    AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);
    AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
}

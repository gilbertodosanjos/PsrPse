using PsrPse.Domain.Arguments.Usuario;
using PsrPse.Domain.Interfaces.Services.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceUsuario : IServiceBase
{
    AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);
    AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
}

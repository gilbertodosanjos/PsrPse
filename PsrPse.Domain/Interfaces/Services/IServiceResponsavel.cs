using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.Responsavel;
using PsrPse.Domain.Interfaces.Services.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceResponsavel : IServiceBase
{
    ResponsavelResponse Adicionar(AdicionarResponsavelRequest request, Guid idUsuario);
    IEnumerable<ResponsavelResponse> Listar(Guid idResponsavel);
    Response Alterar(AdicionarResponsavelRequest request);
    Response Excluir(Guid id);
}

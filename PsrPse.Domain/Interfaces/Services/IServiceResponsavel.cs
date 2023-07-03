using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.Responsavel;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceResponsavel : IServiceBase
{
    AdicionarResponsavelResponse Adicionar(AdicionarResponsavelRequest request, Guid idUsuario);
    IEnumerable<AdicionarResponsavelResponse> Listar(Guid idResponsavel);
    Response Alterar(AdicionarResponsavelRequest request);
    Response Excluir(Guid id);
}

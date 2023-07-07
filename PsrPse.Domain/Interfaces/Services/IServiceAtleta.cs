using PsrPse.Domain.Arguments.Atleta;
using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Interfaces.Services.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceAtleta : IServiceBase
{
    AtletaResponse Adicionar(AdicionarAtletaRequest request, Guid idUsuario);
    IEnumerable<AtletaResponse> Listar(Guid idAtleta);
    Response Alterar(AdicionarAtletaRequest request);
    Response Excluir(Guid id);
}

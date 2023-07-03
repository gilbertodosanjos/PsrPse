using PsrPse.Domain.Arguments.Atleta;
using PsrPse.Domain.Arguments.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceAtleta : IServiceBase
{
    AdicionarAtletaResponse Adicionar(AdicionarAtletaRequest request, Guid idUsuario);
    IEnumerable<AdicionarAtletaResponse> Listar(Guid idAtleta);
    Response Alterar(AdicionarAtletaRequest request);
    Response Excluir(Guid id);
}

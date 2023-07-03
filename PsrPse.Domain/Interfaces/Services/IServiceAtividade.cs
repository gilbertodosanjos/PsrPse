using PsrPse.Domain.Arguments.Atividade;
using PsrPse.Domain.Arguments.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceAtividade : IServiceBase
{
    AdicionarAtividadeResponse Adicionar(AdicionarAtividadeRequest request, Guid idUsuario);
    IEnumerable<AdicionarAtividadeResponse> Listar(Guid idAtividade);
    Response Alterar(AdicionarAtividadeRequest request);
    Response Excluir(Guid id);
}

using PsrPse.Domain.Arguments.Atividade;
using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Interfaces.Services.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceAtividade : IServiceBase
{
    AtividadeResponse Adicionar(AdicionarAtividadeRequest request, Guid idUsuario);
    IEnumerable<AtividadeResponse> Listar(Guid idAtividade);
    Response Alterar(AdicionarAtividadeRequest request);
    Response Excluir(Guid id);
}

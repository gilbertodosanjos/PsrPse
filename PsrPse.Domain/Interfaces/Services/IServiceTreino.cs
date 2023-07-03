using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.Treino;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceTreino : IServiceBase
{
    AdicionarTreinoResponse Adicionar(AdicionarTreinoRequest request, Guid idUsuario);
    IEnumerable<AdicionarTreinoResponse> Listar(Guid idTreino);
    Response Alterar(AdicionarTreinoRequest request);
    Response Excluir(Guid id);
}

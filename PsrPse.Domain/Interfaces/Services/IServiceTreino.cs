using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.Treino;
using PsrPse.Domain.Interfaces.Services.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceTreino : IServiceBase
{
    TreinoResponse Adicionar(AdicionarTreinoRequest request, Guid idUsuario);
    IEnumerable<TreinoResponse> Listar(Guid idTreino);
    Response Alterar(AdicionarTreinoRequest request);
    Response Excluir(Guid id);
}

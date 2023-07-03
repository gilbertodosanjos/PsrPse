using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.TipoAtividade;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceTipoAtividade : IServiceBase
{
    AdicionarTipoAtividadeResponse Adicionar(AdicionarTipoAtividadeRequest request, Guid idUsuario);
    IEnumerable<AdicionarTipoAtividadeResponse> Listar(Guid idTipoAtividade );
    Response Alterar(AdicionarTipoAtividadeRequest request);
    Response Excluir(Guid id);
}

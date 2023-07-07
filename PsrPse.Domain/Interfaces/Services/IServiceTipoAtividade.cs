using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.TipoAtividade;
using PsrPse.Domain.Interfaces.Services.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceTipoAtividade : IServiceBase
{
    TipoAtividadeResponse Adicionar(AdicionarTipoAtividadeRequest request, Guid idUsuario);
    IEnumerable<TipoAtividadeResponse> Listar(Guid idTipoAtividade );
    Response Alterar(AdicionarTipoAtividadeRequest request);
    Response Excluir(Guid id);
}

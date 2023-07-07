using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.GrupoAtividade;
using PsrPse.Domain.Interfaces.Services.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceGrupoAtividade : IServiceBase
{
    GrupoAtividadeResponse Adicionar(AdicionarGrupoAtividadeRequest request, Guid idUsuario);
    IEnumerable<GrupoAtividadeResponse> Listar(Guid idGrupoAtividade);
    Response Alterar(AdicionarGrupoAtividadeRequest request);
    Response Excluir(Guid id);
}

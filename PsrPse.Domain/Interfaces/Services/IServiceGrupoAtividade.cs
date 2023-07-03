using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.GrupoAtividade;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceGrupoAtividade : IServiceBase
{
    AdicionarGrupoAtividadeResponse Adicionar(AdicionarGrupoAtividadeRequest request, Guid idUsuario);
    IEnumerable<AdicionarGrupoAtividadeResponse> Listar(Guid idGrupoAtividade);
    Response Alterar(AdicionarGrupoAtividadeRequest request);
    Response Excluir(Guid id);
}

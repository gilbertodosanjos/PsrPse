using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.Posicao;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServicePosicao : IServiceBase
{
    AdicionarPosicaoResponse Adicionar(AdicionarPosicaoRequest request, Guid idUsuario);
    IEnumerable<AdicionarPosicaoResponse> Listar(Guid idPosicao);
    Response Alterar(AdicionarPosicaoRequest request);
    Response Excluir(Guid id);
}

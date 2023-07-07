using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.Posicao;
using PsrPse.Domain.Interfaces.Services.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServicePosicao : IServiceBase
{
    PosicaoResponse Adicionar(AdicionarPosicaoRequest request, Guid idUsuario);
    IEnumerable<PosicaoResponse> Listar(Guid idPosicao);
    Response Alterar(AdicionarPosicaoRequest request);
    Response Excluir(Guid id);
}

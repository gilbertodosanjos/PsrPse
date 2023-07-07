using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.Modalidade;
using PsrPse.Domain.Interfaces.Services.Base;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceModalidade : IServiceBase
{
    ModalidadeResponse Adicionar(AdicionarModalidadeRequest request, Guid idUsuario);
    IEnumerable<ModalidadeResponse> Listar(Guid idModalidade);
    Response Alterar(AdicionarModalidadeRequest request);
    Response Excluir(Guid id);
}

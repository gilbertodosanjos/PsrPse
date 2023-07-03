using PsrPse.Domain.Arguments.Base;
using PsrPse.Domain.Arguments.Modalidade;

namespace PsrPse.Domain.Interfaces.Services;

public interface IServiceModalidade : IServiceBase
{
    AdicionarModalidadeResponse Adicionar(AdicionarModalidadeRequest request, Guid idUsuario);
    IEnumerable<AdicionarModalidadeResponse> Listar(Guid idModalidade);
    Response Alterar(AdicionarModalidadeRequest request);
    Response Excluir(Guid id);
}

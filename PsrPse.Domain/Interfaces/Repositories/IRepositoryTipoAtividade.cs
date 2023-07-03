using PsrPse.Domain.Entities;

namespace PsrPse.Domain.Interfaces.Repositories;

public interface IRepositoryTipoAtividade
{
    IEnumerable<TipoAtividade> Listar(Guid idTipoAtividade);
    TipoAtividade Obter(Guid id);
    void Salvar(TipoAtividade tipoAtividade);
    void Alterar(TipoAtividade tipoAtividade);
    void Excluir(TipoAtividade tipoAtividade);
}

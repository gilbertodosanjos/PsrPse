using PsrPse.Domain.Entities;

namespace PsrPse.Domain.Interfaces.Repositories;

public interface IRepositoryGrupoAtividade
{
    IEnumerable<GrupoAtividade> Listar(Guid idGrupoAtividade);
    GrupoAtividade Obter(Guid id);
    void Salvar(GrupoAtividade grupoAtividade);
    void Alterar(GrupoAtividade grupoAtividade);
    void Excluir(GrupoAtividade grupoAtividade);
}

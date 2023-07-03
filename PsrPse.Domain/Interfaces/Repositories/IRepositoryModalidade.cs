using PsrPse.Domain.Entities;

namespace PsrPse.Domain.Interfaces.Repositories;

public interface IRepositoryModalidade
{
    IEnumerable<Modalidade> Listar(Guid idModalidade);
    Modalidade Obter(Guid id);
    void Salvar(Modalidade modalidade);
    void Alterar(Modalidade modalidade);
    void Excluir(Modalidade modalidade);
}

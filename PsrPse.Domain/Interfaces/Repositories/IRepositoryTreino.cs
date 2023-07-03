using PsrPse.Domain.Entities;

namespace PsrPse.Domain.Interfaces.Repositories;

public interface IRepositoryTreino
{
    IEnumerable<Treino> Listar(Guid idTreino);
    Treino Obter(Guid id);
    void Salvar(Treino treino);
    void Alterar(Treino treino);
    void Excluir(Treino treino);
}

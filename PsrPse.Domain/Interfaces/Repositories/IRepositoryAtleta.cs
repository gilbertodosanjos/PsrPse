using PsrPse.Domain.Entities;

namespace PsrPse.Domain.Interfaces.Repositories;

public interface IRepositoryAtleta
{
    IEnumerable<Atleta> Listar(Guid idAtleta);
    Atleta Obter(Guid id);
    void Salvar(Atleta atleta);
    void Alterar(Atleta atleta);
    void Excluir(Atleta atleta);
}

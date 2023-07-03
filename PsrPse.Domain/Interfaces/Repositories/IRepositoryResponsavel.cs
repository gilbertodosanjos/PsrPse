using PsrPse.Domain.Entities;

namespace PsrPse.Domain.Interfaces.Repositories;

public interface IRepositoryResponsavel
{
    IEnumerable<Responsavel> Listar(Guid idResponsavel);
    Responsavel Obter(Guid id);
    void Salvar(Responsavel responsavel);
    void Alterar(Responsavel responsavel);
    void Excluir(Responsavel responsavel);
}

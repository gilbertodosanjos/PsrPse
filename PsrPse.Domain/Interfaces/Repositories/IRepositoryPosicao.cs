using PsrPse.Domain.Entities;

namespace PsrPse.Domain.Interfaces.Repositories;

public interface IRepositoryPosicao
{
    IEnumerable<Posicao> Listar(Guid idPosicao);
    Posicao Obter(Guid id);
    void Salvar(Posicao posicao);
    void Alterar(Posicao posicao);
    void Excluir(Posicao posicao);
}

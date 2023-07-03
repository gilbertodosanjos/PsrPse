using PsrPse.Domain.Entities;

namespace PsrPse.Domain.Interfaces.Repositories;

public interface IRepositoryAtividade
{
   IEnumerable<Atividade> Listar(Guid idAtividade);
   Atividade Obter(Guid id);
   void Salvar(Atividade atividade);
   void Alterar(Atividade atividade);
   void Excluir(Atividade atividade);

}

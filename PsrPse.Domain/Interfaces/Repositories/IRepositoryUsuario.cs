using PsrPse.Domain.Entities;

namespace PsrPse.Domain.Interfaces.Repositories;

public interface IRepositoryUsuario
{
   Usuario Obter(Guid id);
   Usuario Obter(string email, string senha);
   void Salvar(Usuario usuario);
   void Alterar(Usuario usuario);
   bool Existe(string email);
}

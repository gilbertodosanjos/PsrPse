using prmToolkit.NotificationPattern;
using PsrPse.Domain.Entities.Base;
using PsrPse.Domain.ValueObjects;
using PsrPse.Domain.Extensions;
using PsrPse.Domain.Entities.ParcialModel;

namespace PsrPse.Domain.Entities;

public class Usuario : EntityBase
{
    protected Usuario()
    {

    }
    public Usuario(Email email, string senha)
    {
        Email = email;
        Senha = senha;

        //Criptografo a senha
        Senha = Senha.ConvertToMD5();

        AddNotifications(email);
    }

    public Usuario(Nome nome, Email email, string senha)
    {
        Nome = nome;
        Email = email;
        Senha = senha;

        new AddNotifications<Usuario>(this).IfNullOrInvalidLength(x => x.Senha, 3, 32);

        //Criptografo a senha
        Senha = Senha.ConvertToMD5();

        AddNotifications(nome, email);
    }

    public Usuario(Nome nome, Email email, Pessoa pessoa, string senha)
    {
        Nome = nome;
        Email = email;
        this.pessoa = pessoa;
        Senha = senha;
    }

    public Nome Nome { get; private set; }
    public Email Email { get; private set; }
    public Pessoa pessoa { get; private set; }
    public string Senha { get; private set; }
        
}



namespace PsrPse.Domain.Entities.ParcialModel;

public class Pessoa
{
    public Pessoa(string cpf, string cnpj, string logradouro, string numeroLogradouro, string bairro, string cidade, string estado, string responsavel, string cpfResponsavel)
    {
        Cpf = cpf;
        Cnpj = cnpj;
        Logradouro = logradouro;
        NumeroLogradouro = numeroLogradouro;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        Responsavel = responsavel;
        CpfResponsavel = cpfResponsavel;
    }

    public string Cpf { get; private set; }
    public string Cnpj { get; private set; }
    public string Logradouro { get; private set; }
    public string NumeroLogradouro { get; private set; }
    public string Bairro { get;private set; }
    public string Cidade { get; private set; }
    public string Estado { get;private set; }
    public string Responsavel { get; private set; }
    public string CpfResponsavel { get;  private set; }

}

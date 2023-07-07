namespace PsrPse.Domain.Arguments.Usuario;

public class AdicionarUsuarioRequest
{
    public string? PrimeiroNome { get; set; }
    public string? UltimoNome { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
    public string? Cpf { get; private set; }
    public string? Cnpj { get; private set; }
    public string? Logradouro { get; private set; }
    public string? NumeroLogradouro { get; private set; }
    public string? Bairro { get;private set; }
    public string? Cidade { get; private set; }
    public string? Estado { get;private set; }
    public string? Responsavel { get; private set; }
    public string? CpfResponsavel { get;  private set; }
}

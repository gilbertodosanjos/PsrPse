namespace PsrPse.Domain.Arguments.Responsavel;

public class AdicionarResponsavelRequest
{
    public int Id { get; set; }
    public string? Cpf { get; set; }
    public int IdUsuario { get; set; }
    public string?  Nome { get; set; }
}

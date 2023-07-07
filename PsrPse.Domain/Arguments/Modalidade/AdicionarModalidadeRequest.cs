namespace PsrPse.Domain.Arguments.Modalidade;

public class AdicionarModalidadeRequest
{
    public int Id { get; set; }
    public int IdTipoModalidade { get; set; }
    public string? Nome { get; set; }
}

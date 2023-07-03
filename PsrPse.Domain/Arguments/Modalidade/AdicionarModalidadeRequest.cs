namespace PsrPse.Domain.Arguments.Modalidade;

public class AdicionarModalidadeRequest
{
    public Guid Id { get; set; }
    public int IdTipoModalidade { get; set; }
    public string Nome { get; set; }
}

namespace PsrPse.Domain.Arguments.Atleta;

public class AdicionarAtletaRequest
{
    public int Id { get; set; }
    public int IdModalidade { get; set; }
    public int IdPosicao { get; set; }
    public int IdResponsavel { get; set; }
    public string? Cpf { get; set; }
    public string? Nome { get; set; }
    public string? Apelido { get; set; }
}

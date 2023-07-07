namespace PsrPse.Domain.Arguments.Atividade;

public class AdicionarAtividadeRequest
{
    public int Id { get; set; }
    public int IdGrupoAtividade { get; set; }
    public string? Nome { get; set; }
    public DateTime Data { get; set; }
    public string? Hora { get; set; }
    public string? CargaMinutos { get; set; }
}

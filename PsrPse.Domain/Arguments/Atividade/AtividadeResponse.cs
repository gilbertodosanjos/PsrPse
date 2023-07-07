namespace PsrPse.Domain.Arguments.Atividade;

public class AtividadeResponse
{
    public int Id { get; set; }
    public int IdGrupoAtividade { get; set; }
    public string? Nome { get; set; }
    public DateTime Data { get; set; }
    public string? Hora { get; set; }
    public string? CargaMinutos { get; set; }

     public static explicit operator AtividadeResponse(Entities.Atividade entidade)
     {
        return new AtividadeResponse()
        {
            Id = entidade.Id,
            IdGrupoAtividade =  entidade.IdGrupoAtividade,
            Nome = entidade.Nome,
            Data =  entidade.Data,
            Hora =  entidade.Hora,
            CargaMinutos =  entidade.CargaMinutos
        };
     }

}

namespace PsrPse.Domain.Arguments.Atleta;

public class AtletaResponse
{
   public int Id { get; set; }
    public int IdModalidade { get; set; }
    public int IdPosicao { get; set; }
    public int IdResponsavel { get; set; }
    public string? Cpf { get; set; }
    public string? Nome { get; set; }
    public string? Apelido { get; set; }

     public static explicit operator AtletaResponse(Entities.Atleta entidade)
     {
        return new AtletaResponse()
        {
            Id = entidade.Id,
            IdModalidade =  entidade.IdModalidade,
            IdPosicao = entidade.IdPosicao,
            IdResponsavel =  entidade.IdResponsavel,
            Cpf =  entidade.Cpf,
            Nome = entidade.Nome,
            Apelido =  entidade.Apelido
        };
     }
}

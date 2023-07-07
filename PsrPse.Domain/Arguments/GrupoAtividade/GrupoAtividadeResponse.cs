namespace PsrPse.Domain.Arguments.GrupoAtividade;

public class GrupoAtividadeResponse
{
    public int Id { get; set; }
    public string?  Nome { get; set; }

    public static explicit operator GrupoAtividadeResponse(Entities.GrupoAtividade entidade)
    {
        return new GrupoAtividadeResponse()
        {
            Id = entidade.Id,
            Nome  =  entidade.Nome
        };
    }

}

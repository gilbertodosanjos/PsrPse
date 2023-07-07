namespace PsrPse.Domain.Arguments.TipoAtividade;

public class TipoAtividadeResponse
{
    public int Id { get; set; }
    public string? Nome { get; set; }


    public static explicit operator TipoAtividadeResponse(Entities.TipoAtividade entidade)
    {
        return new TipoAtividadeResponse()
        {
            Id =  entidade.Id,
            Nome =  entidade.Nome
        };
    }
}

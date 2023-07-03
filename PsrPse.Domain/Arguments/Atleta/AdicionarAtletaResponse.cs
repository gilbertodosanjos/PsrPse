namespace PsrPse.Domain.Arguments.Atleta;

public class AdicionarAtletaResponse
{
    public AdicionarAtletaResponse(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}

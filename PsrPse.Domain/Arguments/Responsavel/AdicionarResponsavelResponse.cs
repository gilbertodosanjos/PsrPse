namespace PsrPse.Domain.Arguments.Responsavel;

public class AdicionarResponsavelResponse
{
    public AdicionarResponsavelResponse(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}

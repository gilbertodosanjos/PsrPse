namespace PsrPse.Domain.Arguments.Usuario;

public class AdicionarUsuarioResponse
{
    public AdicionarUsuarioResponse(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}

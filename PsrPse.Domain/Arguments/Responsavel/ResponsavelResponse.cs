namespace PsrPse.Domain.Arguments.Responsavel;

public class ResponsavelResponse
{
    public int Id { get; set; }
    public string? Cpf { get; set; }
    public int IdUsuario { get; set; }
    public string?  Nome { get; set; }

    public static explicit operator ResponsavelResponse(Entities.Responsavel entidade)
    {
        return new ResponsavelResponse()
        {
            Id  =  entidade.Id,
            Cpf = entidade.Cpf,
            IdUsuario = entidade.IdUsuario,
            Nome = entidade.Nome
        };
    }
}

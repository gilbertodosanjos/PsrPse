namespace PsrPse.Domain.Arguments.Modalidade;

public class ModalidadeResponse
{
    public int Id { get; set; }
    public int IdTipoModalidade { get; set; }
    public string? Nome { get; set; }

    public static explicit operator ModalidadeResponse(Entities.Modalidade entidade)
    {
        return new ModalidadeResponse()
        {
            Id = entidade.Id,
            IdTipoModalidade  = entidade.IdTipoModalidade,
            Nome =  entidade.Nome

        };
    }
}

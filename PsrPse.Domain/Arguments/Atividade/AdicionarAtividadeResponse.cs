namespace PsrPse.Domain.Arguments.Atividade;

public class AdicionarAtividadeResponse
{
     public Guid Id { get; set; }
     public string? Nome { get; set; }

     public static explicit operator AdicionarAtividadeResponse(Entities.Atividade entidade)
     {
        return new AdicionarAtividadeResponse()
        {
            Id = entidade.Id,
            Nome = entidade.Nome
        };
     }

}

using System.Reflection.Metadata;
namespace PsrPse.Domain.Arguments.Posicao;

public class PosicaoResponse
{
    public int Id { get; set; }
    public int IdModalidade { get; set; }
    public string?  Nome { get; set; }

    public static explicit operator PosicaoResponse(Entities.Posicao entidade)
    {
        return new PosicaoResponse()
        {
            Id =  entidade.Id,
            IdModalidade = entidade.IdModalidade,
            Nome  =  entidade.Nome
        };
    }
}

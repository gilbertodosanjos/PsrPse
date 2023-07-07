using PsrPse.Domain.Entities.ParcialModel;
using PsrPse.Domain.Enuns;

namespace PsrPse.Domain.Arguments.Treino;

public class TreinoResponse
{
    public int IdTreino { get; set; }
    public TipoDeTreino  tipoTreino { get;  set; }
    public PsrPse.Domain.Entities.Usuario? usuario { get;  set; }
    public int QuaoIntensaFoiSessaoDeTreinamento { get; set; }
    public PercepcaoDeDorArticular? percepcaoDeDorArticular { get;  set; }
    public PercepcaodeDorMuscular? percepcaodeDorMuscular { get;  set; }
    public DateTime Data { get; set; }
    public int Peso { get;  set; }
    public int SaltoContramovimentoCMJ { get;  set; }
    public int RMSSD { get; set; }
    public int LfHf { get; set; }


    public static explicit operator TreinoResponse(Entities.Treino entidade)
    {
        return new TreinoResponse()
        {
            IdTreino = entidade.IdTreino,
            tipoTreino = entidade.TipoTreino,
            usuario = entidade.Usuario,
            QuaoIntensaFoiSessaoDeTreinamento =  entidade.QuaoIntensaFoiSessaoDeTreinamento,
            percepcaoDeDorArticular =  entidade.PercepcaoDeDorArticular,
            percepcaodeDorMuscular =  entidade.PercepcaodeDorMuscular,
            Data =  entidade.Data,
            Peso =  entidade.Peso,
            SaltoContramovimentoCMJ =  entidade.SaltoContramovimentoCMJ,
            RMSSD =  entidade.RMSSD,
            LfHf =  entidade.LfHf
        };
    }
}

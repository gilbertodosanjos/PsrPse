using PsrPse.Domain.Entities.Base;
using PsrPse.Domain.Entities.ParcialModel;
using PsrPse.Domain.Enuns;
namespace PsrPse.Domain.Entities;

public class Treino : EntityBase
{
    public Treino(Guid IdTreino,TipoDeTreino tipoTreino, Usuario usuario, 
                    PercepcaoDeDorArticular percepcaoDeDorArticular,
                    PercepcaodeDorMuscular percepcaodeDorMuscular, 
                    DateTime data, int peso, int saltoContramovimentoCMJ, 
                    int rMSSD, int lfHf)
    {
        TipoTreino = tipoTreino;
        Usuario = usuario;
        PercepcaoDeDorArticular = percepcaoDeDorArticular;
        PercepcaodeDorMuscular = percepcaodeDorMuscular;
        Data = data;
        Peso = peso;
        SaltoContramovimentoCMJ = saltoContramovimentoCMJ;
        RMSSD = rMSSD;
        LfHf = lfHf;
    }
    public int IdTreino { get; set; }
    public TipoDeTreino  TipoTreino { get;  set; }
    public Usuario Usuario { get; private set; }
    public int QuaoIntensaFoiSessaoDeTreinamento { get; set; }
    public PercepcaoDeDorArticular? PercepcaoDeDorArticular { get;  set; }
    public PercepcaodeDorMuscular PercepcaodeDorMuscular { get;  set; }
    public DateTime Data { get; set; }
    public int Peso { get;  set; }
    public int SaltoContramovimentoCMJ { get;  set; }
    public int RMSSD { get; set; }
    public int LfHf { get; set; }

}

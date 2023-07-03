namespace PsrPse.Domain.Arguments.Treino;

public class AdicionarTreinoRequest
{
    public Guid IdUsuario{ get; set; }
    public int  TipoTreino { get; private set; }
    public int QuaoIntensaFoiSessaoDeTreinamento { get; set; }
    public DateTime Data { get; set; }
    public int Peso { get; private set; }
    public int SaltoContramovimentoCMJ { get; private set; }
    public int RMSSD { get; set; }
    public int LfHf { get; set; }

    //Inicio: percepção de dor articular
    public int PunhoDireito { get; private set; }
    public int CotoveloDireito { get;private  set; }
    public int OmbroDireito { get; private set; }
    public int OmbroEsquerdo { get; private set; }
    public int CotoveloEsquerdo { get;private  set; }
    public int PunhoEsquerdo { get; private set; }
    public int QuadrilDireito { get; private set; }
    public int QuadrilEsquerdo { get;private set; }
    public int JoelhoDireito { get; private set; }
    public int JoelhoEsquerdo { get; private set; }
    public int TornozeloDireito { get; private set; }
    public int TornozeloEsquerdo { get; private set; }
    //Final: percepção de dor articular


    // inicio:percepção de Dor Muscular 

    public int  BracoDireito { get; private set; }
    public int  BracoEsquerdo{ get; private set; }
    public int  Tronco{ get; private set; }
    public int  Abdomen{ get; private set; } 
    public int  CoxaDireita { get; private set; } 
    public int  CoxaEsquerda { get; private set; } 
    public int  ParteInternaDaCoxaDireitaAdutores { get; private set; }   
    public int  ParteInternaDaCoxaEsquerdaAdutores { get; private set; }    
    public int  CostasRegiaoLombar { get; private set; }  
    public int  Gluteos { get; private set; } 
    public int  PosterioresDeCoxaEsquerdaParteDeTrasDaCoxaEsquerda { get; private set; }     
    public int  PosterioresDeCoxaDireitaParteDetrasDaCoxaDireita { get; private set; }   
    public int  PanturrilhaEsquerda  { get; private set; }  
    public int  PanturrilhaDireita  { get;  private set; }  

     // final:percepção de Dor Muscular 

}

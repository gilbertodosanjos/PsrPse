using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using PsrPse.Domain.Resources;


namespace PsrPse.Domain.ValueObjects;

public class Nome: Notifiable
{
        protected Nome()
        {

        }
        
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)
            .IfNullOrInvalidLength(x=>x.PrimeiroNome,3,50,MSG.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Primeiro nome",1,50))
            .IfNullOrInvalidLength(x=>x.PrimeiroNome,3,50,MSG.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Ultimo nome",1,50));

        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
}

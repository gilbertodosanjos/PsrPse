using prmToolkit.NotificationPattern;

namespace PsrPse.Domain.Entities.Base;

public abstract  class EntityBase : Notifiable
{
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }
}


using Khn;

namespace LoggingMicroservice.Domain
{
    public abstract class Entity : IEntity
    {
        protected Entity() : base()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
    }
}

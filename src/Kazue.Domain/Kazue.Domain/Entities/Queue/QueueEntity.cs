using Kazue.Domain.Enums;

namespace Kazue.Domain.Entities.QueueEntity
{
    public class QueueEntity
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public long? BarberId { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

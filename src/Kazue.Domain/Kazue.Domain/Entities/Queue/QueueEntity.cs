using Kazue.Domain.Entities.Barber;
using Kazue.Domain.Entities.Cliient;
using Kazue.Domain.Enums;

namespace Kazue.Domain.Entities.QueueEntity
{
    public class QueueEntity
    {
        public long Id { get; set; }
        public ClientEntity Client { get; set; } = default!;
        public BarberEntity? Barber { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

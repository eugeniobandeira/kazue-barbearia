using Kazue.Domain.Enums;

namespace Kazue.Domain.Response.Queue
{
    public class QueueResponse
    {
        public long Id { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string BarberName { get; set; } = string.Empty;
        public StatusEnum Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

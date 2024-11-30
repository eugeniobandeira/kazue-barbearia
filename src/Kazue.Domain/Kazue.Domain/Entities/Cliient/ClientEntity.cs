namespace Kazue.Domain.Entities.Cliient
{
    public class ClientEntity
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime RegistrationTime { get; set; }
    }
}

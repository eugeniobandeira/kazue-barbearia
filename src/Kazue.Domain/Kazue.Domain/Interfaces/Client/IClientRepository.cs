using Kazue.Domain.Entities.Cliient;

namespace Kazue.Domain.Interfaces.Client
{
    public interface IClientRepository
    {
        Task<ClientEntity> GetByIdAsync(long id);
    }
}

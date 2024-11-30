using Kazue.Domain.Entities.Barber;

namespace Kazue.Domain.Interfaces.Barber
{
    public interface IBarberRepository
    {
        Task<BarberEntity> GetByIdAsync(long id);
    }
}

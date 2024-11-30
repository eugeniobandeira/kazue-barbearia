using Kazue.Domain.Entities.QueueEntity;

namespace Kazue.Domain.Interfaces.Queue
{
    public interface IQueueRepository
    {
        Task<QueueEntity> GetByIdAsync(long id);
        Task AddAsync(QueueEntity entity);
        Task UpdateAsync(QueueEntity entity);
    }
}

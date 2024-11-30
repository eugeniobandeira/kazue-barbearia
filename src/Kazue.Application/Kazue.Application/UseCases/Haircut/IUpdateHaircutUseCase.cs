using Kazue.Domain.Enums;

namespace Kazue.Domain
{
    public interface IUpdateHaircutUseCase
    {
        Task<bool> Execute(long queueEntryId, StatusEnum status);
    }
}

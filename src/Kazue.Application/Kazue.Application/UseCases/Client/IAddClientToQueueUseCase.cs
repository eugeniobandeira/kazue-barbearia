using Kazue.Domain.Response.Queue;

namespace Kazue.Application.UseCases.Client
{
    public interface IAddClientToQueueUseCase
    {
        Task<QueueResponse> Execute(long clientId);
    }
}

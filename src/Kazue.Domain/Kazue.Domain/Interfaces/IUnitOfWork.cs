namespace Kazue.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}

using DeveloperAssesment.Models;

namespace DeveloperAssesment.Repositories
{
    public interface IBookRepo
    {
        Task<IEnumerable<Book>> GetSortedByPublisher();
        Task<IEnumerable<Book>> GetSortedByAuthor();
        Task<decimal> GetTotalPrice();
        Task AddBooks(IEnumerable<Book> books);
        Task<IEnumerable<Book>> GetByStoredProc1();
        Task<IEnumerable<Book>> GetByStoredProc2();

    }
}

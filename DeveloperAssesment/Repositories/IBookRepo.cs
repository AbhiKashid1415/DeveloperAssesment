using DeveloperAssesment.Models;

namespace DeveloperAssesment.Repositories
{
    public interface IBookRepo
    {
        Task<IEnumerable<Book>> GetSortedByPublisherAsync();
        Task<IEnumerable<Book>> GetSortedByAuthorAsync();
        Task<decimal> GetTotalPriceAsync();
        Task AddBooksAsync(IEnumerable<Book> books);
        Task<IEnumerable<Book>> GetByStoredProc1Async();
        Task<IEnumerable<Book>> GetByStoredProc2Async();

    }
}

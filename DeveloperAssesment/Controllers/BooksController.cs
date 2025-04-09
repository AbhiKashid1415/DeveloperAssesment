using DeveloperAssesment.Models;
using DeveloperAssesment.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperAssesment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepo repo;

        public BooksController(IBookRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet("Sorted books by publisher")]
        public async Task<IActionResult> GetSortedByPublisher() =>
        Ok(await repo.GetSortedByPublisherAsync());

        [HttpGet("Books sorted by author")]
        public async Task<IActionResult> GetSortedByAuthor() =>
            Ok(await repo.GetSortedByAuthorAsync());

        [HttpGet("Total Price")]
        public async Task<IActionResult> GetTotalPrice() =>
            Ok(await repo.GetTotalPriceAsync());

        [HttpPost("Add Multiple Books")]
        public async Task<IActionResult> AddBooks([FromBody] IEnumerable<Book> books)
        {
            await repo.AddBooksAsync(books);
            return Ok();
        }


        [HttpGet("stored procedure sort by publisher")]
        public async Task<IActionResult> GetFromStoredProc1() =>
            Ok(await repo.GetByStoredProc1Async());

        [HttpGet("stored procedure sort by author")]
        public async Task<IActionResult> GetFromStoredProc2() =>
            Ok(await repo.GetByStoredProc2Async());

    }
}

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
        public async Task<IActionResult> GetSortedByPublisher()
        {
            return Ok(await repo.GetSortedByPublisher());
        }
        

        [HttpGet("Books sorted by author")]
        public async Task<IActionResult> GetSortedByAuthor()
        {
            return Ok(await repo.GetSortedByAuthor());
        }
            
        [HttpGet("Total Price")]
        public async Task<IActionResult> GetTotalPrice() 
        {
            return Ok(await repo.GetTotalPrice());
        }
           

        [HttpPost("Add Multiple Books")]
        public async Task<IActionResult> AddBooks([FromBody] IEnumerable<Book> books)
        {
            await repo.AddBooks(books);
            return Ok();
        }


        [HttpGet("stored procedure sort by publisher")]
        public async Task<IActionResult> GetFromStoredProc1()
        {
            return Ok(await repo.GetByStoredProc1());
        }

        [HttpGet("stored procedure sort by author")]
        public async Task<IActionResult> GetFromStoredProc2()
        {
            return Ok(await repo.GetByStoredProc2());
        }
            

    }
}

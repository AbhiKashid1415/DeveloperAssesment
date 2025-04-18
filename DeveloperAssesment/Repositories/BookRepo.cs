﻿using DeveloperAssesment.Models;
using Microsoft.EntityFrameworkCore;

namespace DeveloperAssesment.Repositories
{
    public class BookRepo : IBookRepo
    {
        private readonly Context cntx;

        public BookRepo(Context cntx)
        {
            this.cntx = cntx;   
        }


        public async Task<IEnumerable<Book>> GetSortedByAuthor()
        {
            return await cntx.Books
               .OrderBy(b => b.AuthorLastName)
               .ThenBy(b => b.AuthorFirstName)
               .ThenBy(b => b.Title)
               .ToListAsync();
        }
        public async Task<IEnumerable<Book>> GetSortedByPublisher()
        {
            return await cntx.Books
                .OrderBy(b => b.Publisher)
                .ThenBy(b => b.AuthorLastName)
                .ThenBy(b => b.AuthorFirstName)
                .ThenBy(b => b.Title)
                .ToListAsync();
        }

        public async Task<decimal> GetTotalPrice()
        {
            return await cntx.Books.SumAsync(b => b.Price);
        }

        public async Task AddBooks(IEnumerable<Book> books)
        {
            await cntx.Books.AddRangeAsync(books);
            await cntx.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetByStoredProc1()
        {
            return await cntx.Books
                .FromSqlRaw("EXEC GetBooksSortedByPublisherAuthorTitle")
                .ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetByStoredProc2()
        {
            return await cntx.Books
                .FromSqlRaw("EXEC GetBooksSortedByAuthorTitle")
                .ToListAsync();
        }
    }
}

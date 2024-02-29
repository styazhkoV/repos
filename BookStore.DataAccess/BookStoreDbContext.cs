using BookStore.DataAccess.Enties;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess;

public class BookStoreDbContext : DbContext
{
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
    : base(options)
    {
    }


public DbSet<BookEntity> Books { get; set; }
}

https://www.youtube.com/watch?v=X2-5mxFPvUM&t=3925s&ab_channel=KirillDeveloper
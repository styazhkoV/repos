
using BookStore.Core.Models;
using BookStore.DataAccess.Configurations;
using BookStore.DataAccess.Enties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace BookStore.DataAccess.Configurations
{
    public class BookConfigurations : IEntityTypeConfiguration<BookEntity>
    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(b => b.Title)
                .HasMaxLength(Book.MAX_TITLE_LENGTH)
                .IsRequired();
        }
    }
}

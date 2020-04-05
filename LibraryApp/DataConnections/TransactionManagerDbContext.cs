using ClassImplementation.Logic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataConnections
{
    public class TransactionManagerDbContext : DbContext
    {
        public TransactionManagerDbContext(DbContextOptions<TransactionManagerDbContext> options) : base(options)
        {

        }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}

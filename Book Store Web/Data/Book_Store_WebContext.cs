using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_Store_Web.Models;

namespace Book_Store_Web.Data
{
    public class Book_Store_WebContext : DbContext
    {
        public Book_Store_WebContext (DbContextOptions<Book_Store_WebContext> options)
            : base(options)
        {
        }

        public DbSet<Book_Store_Web.Models.book> book { get; set; } = default!;

        public DbSet<Book_Store_Web.Models.usersaccounts>? usersaccounts { get; set; }
    }
}

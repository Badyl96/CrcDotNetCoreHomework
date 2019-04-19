using CrcDotNetCoreHomeworkWebApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrcDotNetCoreHomeworkWebApi.DbContexts
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Library> Libraries { get; set; }
    }
}

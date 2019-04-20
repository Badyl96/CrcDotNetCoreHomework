using CrcDotNetCoreHomeworkWebApi.DbContexts;
using CrcDotNetCoreHomeworkWebApi.Model;
using CrcDotNetCoreHomeworkWebApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrcDotNetCoreHomeworkWebApi.UnitTests
{
    public static class LibraryContextMocker
    {
        public static ILibraryRepository<Library> GetInMemoryLibraryRepository(string dbName)
        {
            var options = new DbContextOptionsBuilder<LibraryContext>()
            .UseInMemoryDatabase(databaseName: dbName)
            .Options;

            LibraryContext libraryContext = new LibraryContext(options);
            libraryContext.FillDatabase();

            return new LibraryRepository(libraryContext);
        }

    }
}

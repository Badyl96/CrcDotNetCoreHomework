using CrcDotNetCoreHomeworkWebApi.DbContexts;
using CrcDotNetCoreHomeworkWebApi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrcDotNetCoreHomeworkWebApi.UnitTests
{
    public static class LibraryContextExtensions
    {
        public static void FillDatabase(this LibraryContext dbContext)
        {
            dbContext.Libraries.Add
            (
                new Library
                {
                    Id = 1,
                    Title = "Tytul 1",
                    Author = "Autor 1",
                    Isbn = "000001",
                    Year = Convert.ToDateTime("2019/03/25 01:00:00 PM")
                }

            );

            dbContext.Libraries.Add
            (
                new Library
                {
                     Id = 2,
                     Title = "Tytul 2",
                     Author = "Autor 1",
                     Isbn = "000002",
                     Year = Convert.ToDateTime("2019/03/25 01:00:00 PM")
                }

             );

            dbContext.Libraries.Add
            (
                 new Library
                 {
                     Id = 3,
                     Title = "Tytul 3",
                     Author = "Autor 1",
                     Isbn = "000003",
                     Year = Convert.ToDateTime("2019/03/25 01:00:00 PM")
                 }

            );

            dbContext.Libraries.Add
             (
                  new Library
                  {
                      Id = 4,
                      Title = "Tytul 4",
                      Author = "Autor 1",
                      Isbn = "000004",
                      Year = Convert.ToDateTime("2019/03/25 01:00:00 PM")
                  }

             );

            dbContext.Libraries.Add
             (
                  new Library
                  {
                      Id = 5,
                      Title = "Tytul 5",
                      Author = "Autor 1",
                      Isbn = "000005",
                      Year = Convert.ToDateTime("2019/03/25 01:00:00 PM")
                  }

             );

            dbContext.SaveChanges();
        }
    }
}

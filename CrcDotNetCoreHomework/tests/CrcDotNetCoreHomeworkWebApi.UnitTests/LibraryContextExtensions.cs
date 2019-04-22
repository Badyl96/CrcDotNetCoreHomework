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
                    Title = "Pan Tateusz",
                    Author = "Adam Mickiewicz",
                    Isbn = "9781296903633",
                    Year = Convert.ToDateTime("2012/03/25 01:00:00 PM")
                }

            );

            dbContext.Libraries.Add
            (
                new Library
                {
                     Id = 2,
                     Title = "Konrad Wallenrod",
                     Author = "Adam Mickiewicz",
                     Isbn = "781296903634",
                     Year = Convert.ToDateTime("2013/03/25 05:15:15 PM")
                }

             );

            dbContext.Libraries.Add
            (
                 new Library
                 {
                     Id = 3,
                     Title = "Ender na wygnaniu",
                     Author = "Orson Scott Card",
                     Isbn = "781296903639",
                     Year = Convert.ToDateTime("2013/09/10 12:36:00 AM")
                 }

            );

            dbContext.Libraries.Add
             (
                  new Library
                  {
                      Id = 4,
                      Title = "Antygona",
                      Author = "Sofokles",
                      Isbn = "781096903639",
                      Year = Convert.ToDateTime("2010/03/25 15:10:00 PM")
                  }

             );

            dbContext.Libraries.Add
             (
                  new Library
                  {
                      Id = 5,
                      Title = "Makbet",
                      Author = "William Shakespeare",
                      Isbn = "781096903633",
                      Year = Convert.ToDateTime("2011/03/25 01:00:00 PM")
                  }

             );

            dbContext.SaveChanges();
        }
    }
}

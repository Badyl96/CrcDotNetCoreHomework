using CrcDotNetCoreHomeworkWebApi.DbContexts;
using CrcDotNetCoreHomeworkWebApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrcDotNetCoreHomeworkWebApi.Repository
{
    public class LibraryRepository : ILibraryRepository<Library>
    {
        private readonly LibraryContext _libraryContext;

        public LibraryRepository(LibraryContext _libraryContext)
        {
            this._libraryContext = _libraryContext;

        }

        public async Task<IEnumerable<Library>> GetAll()
        {
            return await _libraryContext.Libraries.ToListAsync();
        }

        public async Task<Library> Get(long id)
        {
            return await _libraryContext.Libraries.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task Add(Library entity)
        {
            await _libraryContext.Libraries.AddAsync(entity);
            await _libraryContext.SaveChangesAsync();
        }

        public async Task Update(Library library, Library entity)
        {
            library.Title = entity.Title;
            library.Author = entity.Author;
            library.Isbn = entity.Isbn;
            library.Year = entity.Year;

            await _libraryContext.SaveChangesAsync();
        }

        public async Task Delete(Library library)
        {
            _libraryContext.Libraries.Remove(library);
            await _libraryContext.SaveChangesAsync();

        }
    }
}

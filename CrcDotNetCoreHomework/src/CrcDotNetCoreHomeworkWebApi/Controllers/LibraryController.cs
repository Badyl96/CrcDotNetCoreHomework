using CrcDotNetCoreHomeworkWebApi.Model;
using CrcDotNetCoreHomeworkWebApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrcDotNetCoreHomeworkWebApi.Controllers
{
    [Route("api/library")]
    [ApiController]
    public class LibraryController : Controller
    {
        public ILibraryRepository<Library> _libraryRepository { get; }

        public LibraryController(ILibraryRepository<Library> libraryRepository)
        {
            this._libraryRepository = libraryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var libraries = await _libraryRepository.GetAll();

            return Ok(libraries);
        }
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(long id)
        {
            var libraries = await _libraryRepository.Get(id);
            if (libraries == null)
            {
                return NotFound("The library record couldn't be found");
            }
            return Ok(libraries);

        }
        [HttpPost]
        public async Task<IActionResult> Post(Library library)
        {
            if (library == null)
            {
                return BadRequest("Library is null");
            }
            await _libraryRepository.Add(library);

            return CreatedAtAction(nameof(Get), new { id = library.Id }, library);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, Library library)
        {
            var libraryToUpdate = await _libraryRepository.Get(id);

            if (libraryToUpdate == null)
            {
                return NotFound("The library record couldn't be found");
            }

            await _libraryRepository.Update(libraryToUpdate, library);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var libraryToDelete = await _libraryRepository.Get(id);

            if (libraryToDelete == null)
            {
                return NotFound("The library record couldn't be found");
            }
            await _libraryRepository.Delete(libraryToDelete);
            return NoContent();
        }
    }
}

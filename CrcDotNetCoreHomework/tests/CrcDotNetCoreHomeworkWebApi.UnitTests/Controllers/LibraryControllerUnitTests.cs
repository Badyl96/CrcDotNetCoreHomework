using CrcDotNetCoreHomeworkWebApi.Controllers;
using CrcDotNetCoreHomeworkWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CrcDotNetCoreHomeworkWebApi.UnitTests.Controllers
{
    public class LibraryControllerUnitTests
    {
        [Fact]
        public async Task get_all_libraries()
        {
            var repository = LibraryContextMocker.GetInMemoryLibraryRepository(nameof(get_all_libraries));
            var controller = new LibraryController(repository);

            var response = await controller.GetAll() as ObjectResult;
            var measurements = response.Value as List<Library>;

            Assert.Equal(200, response.StatusCode);
            Assert.Equal(5, measurements.Count);

        }
        [Fact]
        public async Task get_library_with_existing_id()
        {
            var repository = LibraryContextMocker.GetInMemoryLibraryRepository(nameof(get_library_with_existing_id));
            var controller = new LibraryController(repository);
            var exceptedValue = "Pan Tateusz";

            var response = await controller.Get(1) as ObjectResult;
            var libraries = response.Value as Library;

            Assert.Equal(200, response.StatusCode);
            Assert.Equal(exceptedValue, libraries.Title);

        }
        

        [Fact]
        public async Task get_library_with_not_existing_id()
        {
       
            var repository = LibraryContextMocker.GetInMemoryLibraryRepository(nameof(get_library_with_not_existing_id));
            var controller = new LibraryController(repository);
            var expectedMessage = "The library record couldn't be found";

         
            var response = await controller.Get(10) as ObjectResult;

          
            Assert.Equal(404, response.StatusCode);
            Assert.Equal(expectedMessage, response.Value);
        }
        /*
        [Fact]
        public async Task check_post_library_with_not_existing_parameters()
        {

            var repository = LibraryContextMocker.GetInMemoryLibraryRepository(nameof(check_post_library_with_not_existing_parameters));
            var controller = new LibraryController(repository);
            var expectedMessage = "Library is null";
            Library library = null;
            var response = await controller.Post(library) as ObjectResult;

            Assert.Equal(404, response.StatusCode);
            Assert.Equal(expectedMessage, response.Value);
        }
        */
    }
}

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
            var exceptedValue = "Title 1";

            var response = await controller.Get(1) as ObjectResult;
            var libraries = response.Value as Library;

            Assert.Equal(200, response.StatusCode);
            Assert.Equal(exceptedValue, libraries.Title);

        }
    }
}

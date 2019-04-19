using CrcDotNetCoreHomeworkWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrcDotNetCoreHomeworkWebApi.Repository
{
    interface ILibraryRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> Get(long id);

        Task Add(TEntity entity);

        Task Update(Library library, TEntity entity);

        Task Delete(Library library);
    }
}

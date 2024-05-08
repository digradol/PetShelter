using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Repos.Contracts
{
    public interface IBaseRepository<TModel>
        where TModel : BaseModel
    {
        Task<IEnumerable<TModel>> GetAllAsyns();
        Task<TModel> GetByIdAsyns(int id);
        Task CreateAsyns(TModel model);
        Task UpdateAsyns(TModel model);
        Task SaveAsyns(TModel model);
        Task DeleteAsyns(int id);
        Task<bool> ExistsByIdAsyns(int id);
        Task<IEnumerable<TModel>> GetWithPaginationAsyns(int pageSize, int pageNumber);
    }
}

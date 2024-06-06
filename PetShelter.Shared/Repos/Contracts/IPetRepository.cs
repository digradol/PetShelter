using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Repos.Contracts
{
    public interface IPetRepository : IBaseRepository<PetDto>
    {
        Task GivePetAsync(int userId, int shelterId, PetDto pet);
        Task AdoptPetAsync(int userId, int petId);
    }
}

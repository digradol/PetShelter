using Microsoft.Identity.Client;
using PetShelter.Shared;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services
{
    [AutoBind]
    public class PetService : BaseCrudService<PetDto, IPetRepository>, IPetServices
    {
        public PetService(IPetRepository repository) : base(repository)
        {

        }
        public Task AdoptPetAsync(int userId, int petId)
        {
            return _repository.AdoptPetAsync( userId, petId);
        }

        public Task GivePetAsync(int userId, int shelterId, PetDto pet)
        {
            return _repository.GivePetAsync(userId, shelterId, pet);
        }

    }
}

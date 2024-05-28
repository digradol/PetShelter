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
    public class ShelterService : BaseCrudService<ShelterDto, IShelterRepository>, IShelterServices
    {
        public ShelterService(IShelterRepository repository) : base(repository)
        {

        }
    }
}

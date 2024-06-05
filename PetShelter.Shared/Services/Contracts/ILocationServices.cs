﻿using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Services.Contracts
{
    public interface ILocationServices : IBaseCrudService<LocationDto, ILocationRepository>
    {
        Task<IEnumerable<LocationDto>> GetAllActiveAsync();
    }
}

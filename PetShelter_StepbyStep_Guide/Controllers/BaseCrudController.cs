﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelter_StepbyStep_Guide.Controllers
{
    public abstract class BaseCrudController<TModel, TRepository, TService, TEditVM, TDetailsVM> : Controller
        where TModel : BaseModel
        where TRepository : BaseRepository<TModel>
        where TService : IBaseCrudService<TModel, TRepository>
        where TEditVM : BaseVM, new()
        where TDetailsVM : BaseVM
    {
        protected readonly TService _service;
        protected readonly IMapper _mapper;
    }

    protected BaseCrudController(TService service, IMapper mapper)
    {
        this._service = service;
        _mapper = mapper;
    }

    protected const int DefaultPageSize = 10;
    protected const int DefaultPageNumber = 1;
    protected const int MaxPageSize = 100;

    protected virtual Task<string?> Validate(TEditVM editVM)
    {
        return Task.FromResult<string?>(null);
    }

    protected virtual Task<TEditVM> PrePopulateVMAsync()
    {
        return Task.FromResult(new TEditVM());
    }

    [HttpGet]

    public virtual async Task<IActionResult> List(
        int pageSize = DefaultPageSize,
        int pageNumber = DefaultPageNumber)
    {
        if (pageSize <= 0 || pageSize > MaxPageSize || pageNumber <= 0 )
        {
            return BadRequest(Constants.InvalidPagination);
        }

        var models = await this._service.GetPaginationAsync(pageSize, pageNumber);
        var mapperModels = _mapper.Map<IEnumerable<TDetailsVM>>(models);
        return View(nameof(List), mapperModels);
    }

    [HttpGet]
    public virtual async Task<IActionResult> Details(int id)
    {
        var model = await this._service.GetByIdIfExistsAsync(id);

        if (modle == default)
        {
            return BadRequest(Constants.InvalidId);
        }

        var mapperModel = _mapper.Map<TDetailsVM>(model);
        return View(mapperModel);
    }

    [HttpGet]
    public virtual async Task<IActionResult> Create()
    {
        var editVM = await PrePopulateVMAsync();
        return View(editVM);
    }

    [HttpPost]
    public virtual async Task<IActionResult> Create(TEditVM editVM)
    {
        var errors = await Validate(editVM);
        if (errors != null)
        {
            return View(editVM);
        }

        var model = this._mapper.Map<TModel>(editVM);
        await this._service.SaveAsync(model);
        return await List();
    }

    [HttpGet]
    public virtual async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return BadRequest(Constants.InvalidId);
        }

        var model = await this._service.GetByIdIfExistsAsync(id.Value);

        if (model == default)
        {
            return BadRequest(Constants.InvalidId);
        }

        var mappedModel = _mapper.Map<TEditVM>(model);
        return View(mappedModel);
    }
}

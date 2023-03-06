﻿using Microsoft.AspNetCore.Mvc;
using SalesOrderAPI1.Container;
using SalesOrderAPI1.Entity;

namespace SalesOrderAPI1.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MasterController : ControllerBase
    {
        private readonly IMasterContainer _container;
        private readonly ILogger<MasterContainer> _logger;
        public MasterController(IMasterContainer container, ILogger<MasterContainer> _logger)
        {
            this._container = container;
            this._logger = _logger;
        }

        [HttpGet("GetAllVariant/{type}")]
        public async Task<List<VariantEntity>> GetAllVariant(string type)
        {

            return await this._container.GetAllVariant(type);

        }

        [HttpGet("GetCategory")]
        public async Task<List<CategoryEntity>> GetCategory()
        {

            return await this._container.GetCategory();

        }


    }
}

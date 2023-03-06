using Microsoft.AspNetCore.Mvc;
using SalesOrderAPI1.Container;
using SalesOrderAPI1.Entity;

namespace SalesOrderAPI1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerContainer _container;
        private readonly ILogger<CustomerContainer> _logger;
        public CustomerController(ICustomerContainer container, ILogger<CustomerContainer> _logger)
        {
            this._container = container;
            this._logger = _logger;
        }

        [HttpGet("GetAll")]
        public async Task<List<CustomerEntity>> GetAll()
        {
            this._logger.LogInformation("|Log ||Testing");
            return await this._container.Getall();

        }
        [HttpGet("GetByCode")]
        public async Task<CustomerEntity> GetByCode(string Code)
        {
            return await this._container.Getbycode(Code);

        }

    }
}

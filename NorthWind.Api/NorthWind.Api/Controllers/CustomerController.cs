using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.BL.Abstract;
using Northwind.Entites.Sakila;

namespace NorthWind.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(IManager<SakilaContext,Customer> manager) : ControllerBase
    {
        [HttpGet]
       public async Task<IActionResult> Index()
        {
            var result = await  manager.GetAllAsync(null);
            return Ok(result);
        }
    }
}

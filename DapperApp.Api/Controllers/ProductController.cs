using DapperApp.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DapperApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await unitOfWork.Products.GetAllAsync();
            // var data = await unitOfWork.Products.GetAllByCategoryId(1);
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.Products.GetAsync(id);
            if (data == null) return Ok();
            return Ok(data);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await unitOfWork.Products.DeleteRowAsync(id);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Dapper.Application.Entities.Product product)
        {
            await unitOfWork.Products.InsertAsync(product);
            return Ok();
        }
    }
}
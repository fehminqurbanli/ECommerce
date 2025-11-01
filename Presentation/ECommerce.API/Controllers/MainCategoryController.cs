using ECommerce.Application.Features.MainCategories.Queries.GetAllMainCategories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainCategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MainCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMainCategories()
        {
            var response = await _mediator.Send(new
                GetAllMainCategoriesQueryRequest());
            return Ok(response);
        }
    }
}

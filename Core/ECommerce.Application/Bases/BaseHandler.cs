using ECommerce.Application.AutoMapper;
using ECommerce.Application.Interfaces.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace ECommerce.Application.Bases
{
    public class BaseHandler
    {
        public readonly IMapper _mapper;
        public readonly IUnitOfWork _unitOfWork;
        public IHttpContextAccessor _httpContextAccessor;
        public readonly string userId;
        //public readonly Guid userId;

        public BaseHandler(
            IMapper mapper, 
            IUnitOfWork unitOfWork, 
            IHttpContextAccessor httpContextAccessor
            )
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }


    }
}

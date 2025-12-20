using ECommerce.Application.AutoMapper;
using ECommerce.Application.DTOs;
using ECommerce.Application.Interfaces.UnitOfWorks;
using ECommerce.Domain.Entities;
using MediatR;


namespace ECommerce.Application.Features.MainCategories.Queries.GetAllMainCategories
{
    public class GetAllMainCategoriesQueryHandler :
        IRequestHandler<GetAllMainCategoriesQueryRequest,
            IList<GetAllMainCategoriesQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllMainCategoriesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IList<GetAllMainCategoriesQueryResponse>> Handle(GetAllMainCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork
                .GetReadRepository<MainCategory>().GetAllAsync();

           _mapper.Map<SubCategoryDTO,SubCategory>(new SubCategory());

            var map = _mapper.Map<GetAllMainCategoriesQueryResponse, MainCategory>(products);

            return map;
        }
    }
}

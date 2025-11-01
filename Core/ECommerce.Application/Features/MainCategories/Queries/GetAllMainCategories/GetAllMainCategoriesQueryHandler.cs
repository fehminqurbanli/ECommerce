using ECommerce.Application.Interfaces.UnitOfWorks;
using ECommerce.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.MainCategories.Queries.GetAllMainCategories
{
    public class GetAllMainCategoriesQueryHandler :
        IRequestHandler<GetAllMainCategoriesQueryRequest,
            IList<GetAllMainCategoriesQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllMainCategoriesQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<GetAllMainCategoriesQueryResponse>> Handle(GetAllMainCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork
                .GetReadRepository<MainCategory>().GetAllAsync();

            List<GetAllMainCategoriesQueryResponse> response = new();

            foreach (var product in products)
            {
                response.Add(new GetAllMainCategoriesQueryResponse
                {
                    Name = product.Name,
                    Description = product.Description
                });
            }

            return response;
        }
    }
}

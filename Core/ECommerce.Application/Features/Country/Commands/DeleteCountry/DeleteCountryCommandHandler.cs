using ECommerce.Application.Interfaces.UnitOfWorks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Country.Commands.DeleteCountry
{
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCountryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(Domain.Entities.Country request, CancellationToken cancellationToken)
        {
            var country = await _unitOfWork.GetReadRepository<Domain.Entities.Country>().GetAsync(x => x.Id == request.Id && !request.IsDeleted);


        }
    }
}

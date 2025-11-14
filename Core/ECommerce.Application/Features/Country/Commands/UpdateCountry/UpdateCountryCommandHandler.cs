using ECommerce.Application.AutoMapper;
using ECommerce.Application.Interfaces.UnitOfWorks;
using ECommerce.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Country.Commands.UpdateCountry
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateCountryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Handle(UpdateCountryCommandRequest request, CancellationToken cancellationToken)
        {
            var country = await _unitOfWork.GetReadRepository<Domain.Entities.Country>()
                .GetAsync(x=>x.Id ==  request.Id && !x.IsDeleted);

            var map = _mapper.Map<UpdateCountryCommandRequest, Domain.Entities.Country>(country);

            await _unitOfWork.GetWriteRepository<Domain.Entities.Country>().UpdateAsync(country);
            await _unitOfWork.SaveAsync();
        }
    }
}

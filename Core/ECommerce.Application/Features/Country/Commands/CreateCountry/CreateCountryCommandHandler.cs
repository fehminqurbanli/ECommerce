using ECommerce.Application.Interfaces.UnitOfWorks;
using baseEntities = ECommerce.Domain.Entities;
using MediatR;

namespace ECommerce.Application.Features.Country.Commands.CreateCountry
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateCountryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateCountryCommandRequest request, CancellationToken cancellationToken)
        {
            baseEntities.Country country = new(request.NameAze, request.NameEng);
            await _unitOfWork.GetWriteRepository< baseEntities.Country >().AddAsync(country);
        }
    }
}

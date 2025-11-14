using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Country.Commands.UpdateCountry
{
    public class UpdateCountryCommandRequest: IRequest
    {
        public Guid Id { get; set; }
        public string NameAze { get; set; }
    }
}

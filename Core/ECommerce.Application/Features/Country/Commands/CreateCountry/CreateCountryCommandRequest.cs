using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Country.Commands.CreateCountry
{
    public class CreateCountryCommandRequest : IRequest
    {
        public string NameAze { get; set; }
        public string NameEng { get; set; }
    }
}

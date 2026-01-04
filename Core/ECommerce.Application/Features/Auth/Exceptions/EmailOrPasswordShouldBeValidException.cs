using ECommerce.Application.Bases;

namespace ECommerce.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldBeValidException: BaseException
    {
        public EmailOrPasswordShouldBeValidException(): base("Email or password should be valid.")
        {
        }
    }
}

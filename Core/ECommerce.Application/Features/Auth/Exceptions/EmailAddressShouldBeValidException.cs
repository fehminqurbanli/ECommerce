using ECommerce.Application.Bases;

namespace ECommerce.Application.Features.Auth.Exceptions
{
    public class EmailAddressShouldBeValidException: BaseException
    {
        public EmailAddressShouldBeValidException(): base("User doesn't exist") {}
    }
}

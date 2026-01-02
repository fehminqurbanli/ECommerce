using ECommerce.Application.Bases;

namespace ECommerce.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistException: BaseException
    {
        public UserAlreadyExistException() : base("User already exists.")
        {
        }
    }
}

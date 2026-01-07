using ECommerce.Application.Bases;
using ECommerce.Application.Features.Auth.Exceptions;
using ECommerce.Domain.Entities.User;

namespace ECommerce.Application.Features.Auth.Rules
{
    public class AuthRules: BaseRules
    {
        public Task UserShouldNotBeExist(User? user)
        {
            if (user is not null)
                throw new UserAlreadyExistException();
            
            return Task.CompletedTask;
        }

        public Task EmailOrPasswordShouldBeValid(User? user, bool checkPassword)
        {
            if(user == null || !checkPassword) throw new EmailOrPasswordShouldBeValidException();
            return Task.CompletedTask;
        }

        public Task RefreshTokenShouldNotBeExpired(DateTime? expiryDate)
        {
            if (expiryDate <= DateTime.Now) throw new RefreshTokenShouldNotBeExpiredException();
            return Task.CompletedTask;
        }
        public Task EmailAddressShouldBeValid(User? user)
        {
            if (user is null) throw new EmailAddressShouldBeValidException();
            return Task.CompletedTask;
        }
    }
}

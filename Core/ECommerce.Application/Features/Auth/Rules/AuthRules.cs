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
    }
}

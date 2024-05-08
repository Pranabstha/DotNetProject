using System.Threading.Tasks;
using BislariumCW.Dtos;
using Microsoft.AspNetCore.Identity;

namespace BislariumCW.Interfaces
{
    public interface IUserAuthenticationRepository
    {
        Task<IdentityResult> RegisterUserAsync(UserRegistrationDto userForRegistration);
        Task<bool> ValidateUserAsync(UserLoginDto loginDto);
        Task<string> GenerateTokenAsync();
        string GetUserId();
    }
}

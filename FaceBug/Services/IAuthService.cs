using FaceBug.Entities;
using FaceBug.Models;

namespace FaceBug.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string?> LoginAsync(UserDto request);
    }
}

using CoreAppArchitectureJWT.Core.DTO;

namespace CoreAppArchitectureJWT.Auth.Services.Interfaces
{
    public interface IAuthService
    {
        string GenerateJwtToken(UserDTO user);  // user contains id, email, role
    }
}

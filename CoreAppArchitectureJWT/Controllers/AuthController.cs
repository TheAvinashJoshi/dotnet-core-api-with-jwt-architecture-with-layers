using CoreAppArchitectureJWT.Auth.Services.Interfaces;
using CoreAppArchitectureJWT.Core.Constants;
using CoreAppArchitectureJWT.Core.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CoreAppArchitectureJWT.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public async Task<GenericAPIResponse<LoginResponseDTO>> Login([FromBody] LoginRequestDTO loginRequest)
        {
            GenericAPIResponse<LoginResponseDTO> response = new GenericAPIResponse<LoginResponseDTO>(false, Messages.INVALID_CREDENTIALS, null);

            // I am just mocking the user validation here. Real implementation should call a service to validate user credentials.
            // Response can be user data that we can pass as claims in JWT token.

            UserDTO user = new UserDTO()
            {
                UserId = Guid.NewGuid(),
                UserName = "TestUser",
                CreationDate = DateTime.UtcNow,
                Email = "testuser@yopmail.com",
                Role = "Admin",
                UpdationDate = DateTime.UtcNow
            };



            var token = _authService.GenerateJwtToken(user);
            var loginResponse = new LoginResponseDTO
            {
                Token = token
            };
            response = new GenericAPIResponse<LoginResponseDTO>(true, null, loginResponse);

            return response;
        }
    }
}

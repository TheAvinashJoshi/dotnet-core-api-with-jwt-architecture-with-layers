﻿namespace CoreAppArchitectureJWT.Core.DTO
{
    public class LoginResponseDTO
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}

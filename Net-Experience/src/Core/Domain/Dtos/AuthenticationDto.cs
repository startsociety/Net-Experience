﻿namespace Net.Experience.Domain.Dtos
{
    public class AuthenticationDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

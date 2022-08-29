﻿using System.ComponentModel.DataAnnotations;

namespace JwtToken.Models
{
    public class UserLoginRequest
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;
    }
}

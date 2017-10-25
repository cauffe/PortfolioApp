﻿using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords Must Match!!!" )]
        public string ConfirmPassword { get; set; }
    }
}
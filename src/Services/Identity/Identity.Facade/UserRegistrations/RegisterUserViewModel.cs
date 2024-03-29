﻿using System.ComponentModel.DataAnnotations;

namespace Identity.Facade.Models
{
    public sealed class RegisterUserViewModel
    {
        [MaxLength(200)]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [MaxLength(200)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Given name")]
        public string GivenName { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Family name")]
        public string FamilyName { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        public string ReturnUrl { get; set; }
    }
}
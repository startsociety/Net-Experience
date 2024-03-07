using System.ComponentModel.DataAnnotations;
using R = Net.Experience.Application.UseCases.Authentication.Login;

namespace Net_Experience.UseCases.Authentication.V1.Login
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }


        public R.LoginRequest ToLoginRequest() 
        {
            return new R.LoginRequest()
            {
                Email = this.Email,
                Password = this.Password,
                RememberMe = this.RememberMe
            };
        }
    }
}

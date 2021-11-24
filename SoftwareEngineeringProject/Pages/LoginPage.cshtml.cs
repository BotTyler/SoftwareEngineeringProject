using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SoftwareEngineeringProject.Pages.Database;
using SoftwareEngineeringProject.Pages.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages
{
    public class LoginPageModel : PageModel
    {

        [BindProperty]
        public UserInfoLogin user { get; set; }

        public string loginError { get; set; }

        private readonly IConfiguration _configuration;

        public LoginPageModel(IConfiguration _configuration)
        {
            this._configuration = _configuration;
        }


        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid) // Checks to see if all fields are filled properly
            {
               /* if (user.verifyUsernameIntegrity() == false || user.verifyPasswordIntegrity() == false)
                {
                    loginError = "Please only use characters a-z, 0-9, !, and @";

                }
                else
                {*/
                    Cipher cipher = new Cipher(new DESCryptoServiceProvider());
                    user.Password = cipher.Encrypt(user.Password, user.Password);

                    // init the database
                    UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);
                    if (db.validateUserInformation(user))
                    {
                        // account verified
                        login(user);
                        Response.Redirect("/HomePage");
                    }
                    else
                    {
                        // Account information is incorrect give error
                        loginError = "Invalid Login Information";
                    }
               // }
            }
        }

        // creates the cookies for a login
        private async void login(UserInfoLogin user)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim("username", user.Username));
            claims.Add(new Claim("ID", user._id));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Username));
            claims.Add(new Claim(ClaimTypes.Name, user.Username));
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimsPrincipal);
        }
    }
}

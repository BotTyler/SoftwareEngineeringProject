using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoftwareEngineeringProject.Pages.Database;
using SoftwareEngineeringProject.Pages.Encryption;

namespace SoftwareEngineeringProject.Pages
{
    public class SignupModel : PageModel
    {
        [BindProperty]
        public UserInfo user { get; set; }


        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (ModelState.IsValid) // Checks to see if all fields are filled properly
            {
                Cipher cipher = new Cipher(new DESCryptoServiceProvider());
                user.PWord = cipher.Encrypt(user.PWord, user.PWord);
                user.Confirm = "";

                // init the database
                UserInfoDB db = new UserInfoDB();
                db.getUsers();
                //Response.Redirect("/LoginPage");
            }
        }
    }
}

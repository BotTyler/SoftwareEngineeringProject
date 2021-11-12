using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoftwareEngineeringProject.Pages.Database;
using SoftwareEngineeringProject.Pages.HelperClasses;

namespace SoftwareEngineeringProject.Pages
{
    public class SignupModel : PageModel
    {
        private readonly DatabaseContext db;
        public SignupModel(DatabaseContext db)
        {
            this.db = db;
        }

        public void OnGet()
        {
        }

        public void OnPostSubmit(SignupHelper user)
        {
            string temp = "Username: " + user.UName + "\nPassword: " + user.PWord;


        }
        /*        [HttpPost]
                [ValidateAntiForgeryToken]
                public IActionResult Create(UserInfo user)
                {
                    IEnumerable<UserInfo> objList = db.UserInfo;
                    Console.WriteLine("OBJLIST: " + user);
                    return Page();
                }*/
    }
}

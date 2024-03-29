using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.DatabaseTestPages.User
{
    public class UserInsertModel : PageModel
    {
        [BindProperty]
        public Database.UserInfoLogin user { get; set; }

        public string statusMsg { get; set; }

        private readonly IConfiguration _configuration;
        public UserInsertModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);
                int isInserted = db.insertUser(user);
                if (isInserted == 0)
                {
                    statusMsg = "The registration was inserted";
                }
                else
                {
                    statusMsg = "The registration was not inserted";
                }
            }
        }
    }
}

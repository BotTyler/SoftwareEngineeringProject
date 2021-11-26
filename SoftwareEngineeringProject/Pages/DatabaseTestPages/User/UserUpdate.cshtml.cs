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
    public class UserUpdateModel : PageModel
    {
        [BindProperty]
        public Database.UserInfoLogin[] userList { get; set; }

        private readonly IConfiguration _configuration;
        public UserUpdateModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public void OnGet()
        {
            UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);

            userList = db.getAllUsers();
        }
    }
}

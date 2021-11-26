using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.DatabaseTestPages.User
{
    public class UserDeleteModel : PageModel
    {
        [BindProperty]
        public Database.UserInfoLogin[] userList { get; set; }

        private readonly IConfiguration _configuration;
        public UserDeleteModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public void OnGet()
        {
            UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);

            userList = db.getAllUsers();
        }

        public void OnPostDelete([FromUri] string id)
        {
            if (ModelState.IsValid)
            {
                UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);
                db.deleteUser(id);
                userList = db.getAllUsers();
            }
        }
    }
}

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
    public class UserUpdateHelperModel : PageModel
    {
        [BindProperty]
        public Database.UserInfoLogin user { get; set; }

        private readonly IConfiguration _configuration;
        public UserUpdateHelperModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public void OnGet([FromUri] string id)
        {
            UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);
            user = db.getUserByID(id);
        }

        public void OnPostUpdate()
        {
            if (ModelState.IsValid)
            {
                UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);
                db.updateuser(user);
                Response.Redirect("/DatabaseTestPages/User/UserUpdate");
            }
        }
    }
}

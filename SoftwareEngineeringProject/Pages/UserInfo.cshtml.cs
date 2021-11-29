using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.UserInfo
{
    public class UserInfoModel : PageModel
    {
        [BindProperty]
        public Database.UserInfoLogin userInfo { get; set; }

        private readonly IConfiguration _configuration;
        public UserInfoModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public void OnGet()
        {
            UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);

            userInfo = db.getUserByID(HttpContext.User.FindFirst("ID").Value);
        }

        public void OnPost()
        {

        }
    }
}
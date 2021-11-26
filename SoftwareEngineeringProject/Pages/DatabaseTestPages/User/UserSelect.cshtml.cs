using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.DatabaseTestPages.User
{
    public class UserSelectModel : PageModel
    {
        [BindProperty]
        public Database.UserInfoLogin[] userList { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter a word.")]
        public string searchText { get; set; }

        public string statusMsg { get; set; }
        private readonly IConfiguration _configuration;
        public UserSelectModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }


        public void OnGet()
        {
            UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);

            userList = db.getAllUsers();
        }

        public void OnPost()
        {
            UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);

            if (ModelState.IsValid)
            {


                userList = db.getUsersByUsername(searchText);


            }
            else
            {
                userList = db.getAllUsers();
            }
        }
    }
}

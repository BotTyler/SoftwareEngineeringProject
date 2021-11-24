using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.DatabaseTestPages
{
    public class RegistrationSelectModel : PageModel
    {
        [BindProperty]
        public Database.Registration[] regList { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage ="Please enter a word.")]
        public string searchText { get; set; }

        public string statusMsg { get; set; }
        private readonly IConfiguration _configuration;
        public RegistrationSelectModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        
        public void OnGet()
        {
            RegistrationDB db = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);
            //string a = Request.QueryString("searchText");
            
            //regList = db.selectUserRegisteredEvent(a);
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                
                RegistrationDB db = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);
                regList = db.selectUserRegisteredEvent(searchText);
            }
        }
    }
}

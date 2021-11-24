using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.DatabaseTestPages
{
    public class RegistrationInsertModel : PageModel
    {
        [BindProperty]
        public Database.Registration registration { get; set; }

        public string statusMsg { get; set; }

        private readonly IConfiguration _configuration;
        public RegistrationInsertModel(IConfiguration configuration)
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
                RegistrationDB db = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);
                bool isInserted = db.insertRegistration(registration);
                if (isInserted)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SoftwareEngineeringProject.Pages.LoggingOutPages
{
    public class LogOutProcessingModel : PageModel
    {
        public async Task<RedirectToPageResult> OnGetAsync()
        {
            await HttpContext.SignOutAsync();
            return RedirectToPage("/LoggingOutPages/LogoutPage");
        }
    }
}

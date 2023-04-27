using EmployeeManager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManager.Views.Home
{
    public class RegisterModel : PageModel
    {
        public Register Model { get; set; }

        public RegisterModel(UserManager<IdentityUser> userManager,SignInManager)
        public void OnGet()
        {
        }
    }
}

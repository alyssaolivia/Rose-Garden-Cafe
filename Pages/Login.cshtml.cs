using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rose_Garden_Cafe.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

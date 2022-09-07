using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class HellowebModel : PageModel
    {
        public string message { get; set; }
        public string Discount { get; set; }    
        public void OnGet()
        {
            message = "ASP.Net is Rocking ";
            Discount = "15";

        }
    }
}

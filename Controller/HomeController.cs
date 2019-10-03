using Microsoft.AspNetCore.Mvc;
namespace PortfolioOne
{
    public class HomeController: Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "This is my Index!";
        }

        [HttpGet]
        [Route("projects")]
        public ViewResult Projects()
        {
            // Views
            return View();
        }

        [HttpGet]
        [Route("contact")]
        public string Contact()
        {
            return "This is my contact ";
        }
    }
}


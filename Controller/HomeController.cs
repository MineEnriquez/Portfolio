using Microsoft.AspNetCore.Mvc;
namespace PortfolioOne
{
    public class HomeController: Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("projects")]
        public ViewResult Projects()
        {
            // Views
            return View("projects");
        }

        [HttpGet]
        [Route("contact")]
        public ViewResult Contact()
        {
            return View("contact");
        }
    }
}


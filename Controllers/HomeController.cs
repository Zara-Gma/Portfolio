using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     // index
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]       //type of request
        [Route("/projects")]     // index
        public ViewResult projects()
        {
            return View();
        }

        [HttpGet]       //type of request
        [Route("/contact")]     // index
        public ViewResult contact()
        {
            return View();
        }
    }
}

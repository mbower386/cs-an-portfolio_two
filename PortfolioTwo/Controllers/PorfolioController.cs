using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioTwo.Controllers
{
    public class PortfolioController : Controller
    {
        // Index
        [HttpGet]
        [Route ("")]
        public ViewResult Index ()
        {
            return View ();
        }

        // Projects
        [HttpGet]
        [Route ("projects")]
        public ViewResult Projects ()
        {
            return View ("Projects");
        }

        // Contacts
        [HttpGet]
        [Route ("contact")]
        public ViewResult Contacts ()
        {
            return View ("Contact");
        }
    }
}
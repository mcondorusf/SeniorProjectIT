using Microsoft.AspNetCore.Mvc;

namespace FloodProject.Controllers
{
    public class InfoController : Controller
    {
        /// <summary>
        /// This is the controller action for the Info page. 
        /// It returns the Info view. 
        /// </summary>
        public IActionResult Info()
        {
            return View();
        }
    }
}

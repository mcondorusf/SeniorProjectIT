using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FloodProject.Models;

namespace FloodProject.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// This view returns the ArcGIS Map of the Tampa Bay area. 
        /// This is the main view for the activity. 
        /// </summary>
        public IActionResult FloodMap()
        {
            return View();
        }

        /// <summary>
        /// This is the controller action for the About page. 
        /// It returns the About view. 
        /// </summary>
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

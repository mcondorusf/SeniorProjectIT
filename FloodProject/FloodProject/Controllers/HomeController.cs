using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FloodProject.Models;
using FloodDataAPI;
using System.Threading.Tasks;
using System;

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

        /// <summary>
        /// This is going to return flood data from the National Flood Data API. 
        /// It will get flood data by lat/long coordinates. 
        /// It will return a Flood Data Result model as JSON. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetFloodDataByCoordinates(double latitude, double longitude)
        {
            try
            {
                FloodDataResults flood_data_api = new FloodDataResults();

                var flood_data = await flood_data_api.Get_Flood_Data_Model_By_Coordiantes(latitude, longitude);

                return Json(new { data = flood_data });
            }
            catch (Exception ex)
            {
                return Json(new { data = "Unable to return flood data" });
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

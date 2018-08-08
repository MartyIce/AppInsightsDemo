using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppInsightsDemo.Controllers
{
    /// <summary>
    /// ViewModel for HomeController.Index, this will allow us to pass the app insights key from (secret) App Settings
    /// </summary>
    public class IndexModel
    {
        public string AppInsightsKey { get; set; }
        public string AppInsightsRestApiKey { get; set; }
        public string AppInsightsApplicationId { get; set; }
    }

    /// <summary>
    /// MVC Controller for Home views, this is mainly just to pass keys to javascript
    /// </summary>
    public class HomeController : Controller
    {
        private IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View(new IndexModel
            {
                AppInsightsKey = _configuration["AppInsightsKey"],
                AppInsightsRestApiKey = _configuration["AppInsightsRestApiKey"],
                AppInsightsApplicationId = _configuration["AppInsightsApplicationId"],
            });
        }
    }
}
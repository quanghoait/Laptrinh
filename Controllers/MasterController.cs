using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Laptrinh.Controllers
{
    public class Master : Controller
    {
        public IActionResult Index()
    {
        return View();
    }

    }
}
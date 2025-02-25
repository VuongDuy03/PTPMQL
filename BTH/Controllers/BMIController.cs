using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTH.Models;

namespace BTH.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult BMIIndex()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMIModel ps)
        {
            float BMI = ps.Weight / (ps.Height * ps.Height);
            ViewBag.Message = $"{ps.Name}, BMI: {BMI:0.##}";
            return View();
        }
        
    }
}
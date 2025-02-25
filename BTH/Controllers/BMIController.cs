using Microsoft.AspNetCore.Mvc;
using BMICalculator.Models;

namespace BMICalculator.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(BMIModel model)
        {
            if (ModelState.IsValid)
            {
                // Tính BMI
                model.BMI = model.Weight / (model.Height * model.Height);

                // Đánh giá kết quả BMI
                if (model.BMI < 18.5)
                    model.Result = "Nhẹ cân";
                else if (model.BMI < 24.9)
                    model.Result = "Cân nặng bình thường";
                else if (model.BMI < 30)
                    model.Result = "Thừa cân";
                else
                    model.Result = "Béo phì";

                ViewBag.BMI = model.BMI;
                ViewBag.Result = model.Result;
            }

            return View(model);
        }
    }
}

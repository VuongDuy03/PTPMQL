using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTH02.Models;

namespace BTH02.Controllers
{
    public class DiemmonhocController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(DiemmonhocModel ps)
        {
            ps.SubjectScore =((ps.DiemA*6 + ps.DiemB*4 + ps.DiemC*1)/10.0f);
            ViewBag.Message=$"{ps.Name}, {ps.Subject},Diem la: {ps.SubjectScore:F2} ";
            return View();
        }
    }
}
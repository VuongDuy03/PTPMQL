using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTH03.Models;
namespace BTH03.Controllers
{
    public class HoadonController : Controller
    {
        [HttpGet]
        public IActionResult HoadonIndex()
        {
            return View();

        }
        [HttpPost]
        public IActionResult HoadonIndex(HoadonModel ps)
        {
            float ThanhTien = ps.SoLuong * ps.GiaBan;
            ViewBag.Message= $"{ps.TenHang}, So Tien La: {ThanhTien}";
            return View();

        }
        

        
    }
}
using System.Diagnostics;
using EmyGrupWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmyGrupWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // 🏠 Ana Sayfa
        public IActionResult Index()
        {
            return View();
        }

        // 🔒 Gizlilik Politikası
        public IActionResult Privacy()
        {
            return View();
        }

        // 🧍 Hakkımızda
        public IActionResult About()
        {
            return View();
        }

        // 🤝 İş Birliklerimiz
        public IActionResult Partners()
        {
            return View();
        }

        // 📦 Ürünlerimiz
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Statistics()
        {
            return View();
        }

        public IActionResult FMCG()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Field()
        {
            return View();
        }

        // ❌ Hata Sayfası
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}

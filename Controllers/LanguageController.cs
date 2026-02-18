using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace EmyGrupWeb.Controllers
{
    public class LanguageController : Controller
    {
        [HttpGet]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            // Güvenlik: boşsa home'a yönlendir
            if (string.IsNullOrWhiteSpace(returnUrl))
                returnUrl = "/";

            // Cookie yaz
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1),
                    IsEssential = true,
                    HttpOnly = false
                }
            );

            return LocalRedirect(returnUrl);
        }
    }
}

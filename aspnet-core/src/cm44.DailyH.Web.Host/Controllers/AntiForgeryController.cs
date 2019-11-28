using Microsoft.AspNetCore.Antiforgery;
using cm44.DailyH.Controllers;

namespace cm44.DailyH.Web.Host.Controllers
{
    public class AntiForgeryController : DailyHControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

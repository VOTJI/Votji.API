using Microsoft.AspNetCore.Antiforgery;
using Votji.API.Controllers;

namespace Votji.API.Web.Host.Controllers
{
    public class AntiForgeryController : APIControllerBase
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

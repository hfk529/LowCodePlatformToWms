using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LowCodePlatformToWms.Controllers;

namespace LowCodePlatformToWms.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LowCodePlatformToWmsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

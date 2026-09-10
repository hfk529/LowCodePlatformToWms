using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LowCodePlatformToWms.Controllers;

namespace LowCodePlatformToWms.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : LowCodePlatformToWmsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.Services.InterFaces;

namespace TopLearn.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private ICourseService _CourseService;
        public HomeController(IUserService userService , ICourseService CourseService)
        {
            _userService = userService;
            _CourseService = CourseService;
        }
        public IActionResult Index() => View();

        [Route("OnlinePayment/{id}")]
        public IActionResult onlinePayment(int id)
        {
            if(HttpContext.Request.Query["Status"] != "" && 
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"
                && HttpContext.Request.Query["Authority"] != "")
            {
                string Authority = HttpContext.Request.Query["Authority"];

                var Wallet = _userService.GetWalletByWalletId(id);

                var Pyment = new ZarinpalSandbox.Payment(Wallet.Amount);
                var res = Pyment.Verification(Authority).Result;
                if(res.Status == 100)
                {
                    ViewBag.code = res.RefId;
                    ViewBag.IsSuccess = true;
                    Wallet.IsPay = true;
                    _userService.UpdateWallet(Wallet);
                }
            }

            return View();
        }

        public IActionResult GetSubGroups(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید" , Value = ""}
            };
            list.AddRange(_CourseService.GetSubGroupForManageCourse(id));
            return Json(new SelectList(list, "Value", "Text"));
        }
    }
}

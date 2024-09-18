using Microsoft.AspNetCore.Mvc;
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
        public HomeController(IUserService userService)
        {
            _userService = userService;
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
    }
}

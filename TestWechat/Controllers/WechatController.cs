using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWechat.Controllers
{
    public class WechatController : Controller
    {
        // GET: Wechat
        public ActionResult Index()
        {
            return Content("123");
        }
    }
}
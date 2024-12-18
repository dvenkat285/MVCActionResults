using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionResults.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Register()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Login() //default is get actionverb if donot keep http actionverb
        {
            return View();
        }
        //action methods(overloading ) examples -actionVERBs like get or post
        [HttpPost]//use same for get and post for validate with action methods like httpost
        public string Login(string txtUid, string txtPwd ) // <form> tag is compulsory for submit/post in view
        {
            if (txtUid == "admin" && txtPwd == "admin")
                return "Valid User";
            else
                return "Invalid User";
        }
        //view with different name in place of controller name and parameter used as view name
        public ViewResult ForgotPassword()
        {
            return View("ForgotPwd");
        }
        //view with different name in place of controller name & used path

        public ViewResult ResetPassword()
        {
            return View("~/Views/Home/ResetPwd.cshtml");
        }
        //view in shared folder
        public ViewResult Contact()
        {
            return View();
        }
        //view in different folder instead of shared or view/home
        public ViewResult Mission()
        {
            return View("~/Views/Test/Mission.cshtml");
        }

        // creating view with razor view and view with web farm and check which one will it call
        // so the default view engine is web farm cuz by default first web farm launches with the controller
        //if you want to launch Razor give path
        public ViewResult About()
        {
            return View(); //another way by adding clear() n add in global.asax

            //return View("~/Views/Home/About.cshtml");
        }
        //redirecting to different view with same controller- means possible to 2 or more different view from one controller
        public ViewResult Show(int id)
        {
            if(id == 1) 
            return View("Show1");
            else
                return View("Show2");
        }
    }
}
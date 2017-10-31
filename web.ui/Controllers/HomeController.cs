using com.alibaba.openapi.client;
using com.alibaba.openapi.client.policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.ui.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ClientPolicy clientPolicy = new ClientPolicy();
            clientPolicy.AppKey = "9769930";
            clientPolicy.SecretKey = "RkBsy8k9v5h";

            SyncAPIClient instance = new SyncAPIClient(clientPolicy);

            Model.CategoryGetParam categoryGetParam = new Model.CategoryGetParam();
            categoryGetParam.setCategoryID(2);
            categoryGetParam.setWebSite("1688");
            string category = instance.sendJson(categoryGetParam);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
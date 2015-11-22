using BedrockBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BedrockBankUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn(FormCollection collection)
        {
            var ssn = collection["TxtSSN"];
            int convertedSSN;
            if (int.TryParse(ssn, out convertedSSN))
            {
                var accounts = BankFactory.GetAllAccountsBySSN(convertedSSN);
                return View(accounts);
             }
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace ValentineStore.Controllers
{
    public class ValentineController : Controller
    {
        // POST: Valentine
        [HttpPost]
        public ActionResult Index()
        {//Navigate to https:xx/valentine/Index
            return View();
        }

        //Get request=> localhost : xxx/Valantine/Store
        public ActionResult Store()
        {
            return View();
        }

        //GET request => Localhost : xxx/Valantine/Checkout
        public ActionResult Checkout(string orderName, string OrderChocolate, string cardinclude )

        {
            Debug.WriteLine("The order name is: ");
            Debug.WriteLine(orderName);

            Debug.WriteLine("The order chocolate is: ");
            Debug.WriteLine(OrderChocolate);

            //Goal:
            //Pass the information to View/Valentine?checkout.cshtml
            ViewData["orderName"] = orderName;
            ViewData["OrderChocolate"]= OrderChocolate;

            //goal:
            //to total the order total
            decimal OrderTotal = 0;
            if (OrderChocolate == "S")
            {
                OrderTotal = 5;
            }
            else if(OrderChocolate =="M")
            {
                OrderTotal = 10;
            }
            else if(OrderChocolate=="L") 
            {
                OrderTotal = 15;
            }
            ViewData["OrderTotal"] = OrderTotal;

            Debug.WriteLine("hst is: ");
            ViewData["cardinclude"] = cardinclude;

            return View();
        }

       

    }
}
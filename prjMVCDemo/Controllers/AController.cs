using prjMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjMVCDemo.Controllers
{
    public class AController : Controller
    {
        public string sayHello()    
        {
            return "Hello~~~";
        }

        public string lotto()
        {
            return (new CLottoGen()).getNembers();
            
        }


        // GET: A  
        public ActionResult Index()
        {
            return View();
        }
    }
}
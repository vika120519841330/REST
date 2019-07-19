using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace RESTfullAPI.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "HOME PAGE";
        }
    }
}

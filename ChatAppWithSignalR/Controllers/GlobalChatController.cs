using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppWithSignalR.Controllers
{
    public class GlobalChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

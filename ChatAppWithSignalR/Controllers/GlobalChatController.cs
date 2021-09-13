using ChatAppWithSignalR.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppWithSignalR.Controllers
{
    public class GlobalChatController : Controller
    {
        private readonly IHubContext<MessageHub> _messageHubContext;

        public GlobalChatController(IHubContext<MessageHub> messageHubContext)
        {
            _messageHubContext = messageHubContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Announcement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Announcement(string message)
        {
            _messageHubContext.Clients.All.SendAsync("ReceiveMessage", message);
            return View();
        }
    }
}

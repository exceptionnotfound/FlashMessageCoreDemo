using FlashMessageCoreDemo.Models;
using FlashMessageCoreDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FlashMessageCoreDemo.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            HomeIndexVM model = new HomeIndexVM();
            return View(model);
        }

        [HttpPost("AddMessage")]
        public IActionResult AddMessage(string message, FlashMessageType type)
        {
            SetFlashMessage(message, type);
            return RedirectToAction("Index");
        }
    }
}

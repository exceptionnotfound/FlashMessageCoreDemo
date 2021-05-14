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
        public IActionResult FlashMessage()
        {
            MessageVM model = new MessageVM();
            return View(model);
        }

        [HttpPost("AddFlashMessage")]
        public IActionResult AddFlashMessage(string message, FlashMessageType type)
        {
            SetFlashMessage(message, type);
            return RedirectToAction("FlashMessage");
        }

        public IActionResult StatusMessage(string message)
        {
            MessageVM model = new MessageVM();
            model.Message = message;
            return View(model);
        }

        [HttpPost("AddStatusMessage")]
        public IActionResult AddStatusMessage(string message)
        {
            return RedirectToAction("StatusMessage", new { message = message });
        }
    }
}

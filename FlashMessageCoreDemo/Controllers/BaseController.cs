using FlashMessageCoreDemo;
using FlashMessageCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashMessageCoreDemo.Controllers
{
    public class BaseController : Controller
    {
        public void SetSuccessMessage(string message)
        {
            SetFlashMessage(message, FlashMessageType.Success);
        }

        public void SetWarningMessage(string message)
        {
            SetFlashMessage(message, FlashMessageType.Warning);
        }

        public void SetErrorMessage(string message)
        {
            SetFlashMessage(message, FlashMessageType.Error);
        }

        public void SetFlashMessage(string message, FlashMessageType type)
        {
            TempData[Constants.FlashMessageKey] = message;

            switch (type)
            {
                case FlashMessageType.Success:
                    TempData[Constants.FlashMessageTypeKey] = "alert-success";
                    break;

                case FlashMessageType.Warning:
                    TempData[Constants.FlashMessageTypeKey] = "alert-warning";
                    break;

                case FlashMessageType.Error:
                    TempData[Constants.FlashMessageTypeKey] = "alert-danger";
                    break;

                case FlashMessageType.Info:
                    TempData[Constants.FlashMessageTypeKey] = "alert-info";
                    break;
            }
        }
    }
}

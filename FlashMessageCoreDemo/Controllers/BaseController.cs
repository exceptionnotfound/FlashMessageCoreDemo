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

            string commonCSS = "rounded p-lg-3 "; //Note the trailing space

            switch (type)
            {
                case FlashMessageType.Success:
                    commonCSS += "alert-success";
                    break;

                case FlashMessageType.Warning:
                    commonCSS += "alert-warning";
                    break;

                case FlashMessageType.Error:
                    commonCSS += "alert-danger";
                    break;

                case FlashMessageType.Info:
                    commonCSS += "alert-info";
                    break;
            }

            TempData[Constants.FlashMessageTypeKey] = commonCSS;
        }
    }
}

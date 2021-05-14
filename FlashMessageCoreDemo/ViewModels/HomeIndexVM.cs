using FlashMessageCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FlashMessageCoreDemo.ViewModels
{
    public class HomeIndexVM
    {
        [DisplayName("Flash Message: ")]
        public string Message { get; set; }

        [DisplayName("Type: ")]
        public FlashMessageType Type { get; set; } = FlashMessageType.Success;
    }
}

using FlashMessageCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FlashMessageCoreDemo.ViewModels
{
    public class MessageVM
    {
        [DisplayName("Message: ")]
        public string Message { get; set; }

        [DisplayName("Type: ")]
        public FlashMessageType Type { get; set; } = FlashMessageType.Success;
    }
}

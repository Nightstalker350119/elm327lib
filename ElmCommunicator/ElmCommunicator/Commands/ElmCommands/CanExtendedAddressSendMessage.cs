﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanExtendedAddressSendMessage : SendMessage
    {
        public CanExtendedAddressSendMessage()
        {
            this.Command = "AT CEA";
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace JImage.Server.ViewModels.Helpers
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; }

        public MessageEventArgs(string message = null)
        {
            this.Message = message;
        }
    }
}

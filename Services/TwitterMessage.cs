using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using DependencyDemo.Interface;
using DependencyDemo.Models;

namespace DependencyDemo.Services
{
    public class TwitterMessage : ISendMessage
    {
        public string sendMessage(Message message)
        {
            return string.Format("Twitter message was sent to userID: {0}, send time {1}", message.MessageToID, message.SendTime);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using DependencyDemo.Interface;

namespace DependencyDemo.Models
{
    public class Person
    {
        public string Name;

        private ISendMessage _msgSender;

        public Person(ISendMessage msgSender)
        {
            _msgSender = msgSender;
        }

        public string SendMessage(Message message)
        {
           return _msgSender.sendMessage(message);
        }
    }
}
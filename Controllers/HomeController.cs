using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DependencyDemo.Models;
using DependencyDemo.Interface;
using DependencyDemo.Services;

namespace DependencyDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public string Index()
        {
            Message message = new Message
            {
                MessageToID = 2,
                Content = "Hi john",
                SendTime = DateTime.Now
            };

            //FacebookMessage fbMessage = new FacebookMessage(message);

            //TwitterMessage twitterMsg = new TwitterMessage();

            //SMTPMessage smtpMessage = new SMTPMessage();

            Person person = new Person(smtpMessage);

            return string.Format("The output is {0}", person.SendMessage(message));
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DependencyDemo.Models;

namespace DependencyDemo.Interface
{
    public interface ISendMessage
    {
        string sendMessage(Message message);
    }
}

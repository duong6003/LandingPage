using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Kernel.Commons.Response
{
    public class SuccessResponse
    {
        public SuccessResponse(string messages) : this(new List<string>() { messages }) { }
        public SuccessResponse(IEnumerable<string> messages)
        {
            Messages = messages;
        }
        IEnumerable<string> Messages { get; set; }
    }
}

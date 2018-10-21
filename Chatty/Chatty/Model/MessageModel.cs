using System;
using System.Collections.Generic;
using System.Text;

namespace Chatty.Model
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Sender { get; set; }
        public string Reciver { get; set; }
        
    }
}

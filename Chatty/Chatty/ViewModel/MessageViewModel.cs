using Chatty.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Chatty.ViewModel
{
    public class MessageViewModel : BaseViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public MessageViewModel()
        {
            Messages = new ObservableCollection<MessageModel>
            {
                new MessageModel
                {
                    Id=1,
                    Text = "asdsad",
                    Sender = "adssad",
                    Reciver = "sadsadsa"
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Chatty.Model;

namespace Chatty.ViewModel
{
    public class ContactViewModel : BaseViewModel
    {
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public ContactViewModel()
        {

            Contacts = new ObservableCollection<ContactModel>
            {
                new ContactModel
                {
                    Id = 1,
                    Me = "elo",
                    MyContact = "melo"
                }
            };
        }
    }
}

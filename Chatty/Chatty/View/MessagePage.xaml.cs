﻿using Chatty.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chatty
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessagePage : ContentPage
	{
        MessageViewModel messages = new MessageViewModel();
		public MessagePage ()
		{
			InitializeComponent ();
            BindingContext = messages;
		}
	}
}
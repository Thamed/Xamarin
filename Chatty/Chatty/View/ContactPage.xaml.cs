using Chatty.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chatty
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
        ContactViewModel contact = new ContactViewModel();
        public ContactPage ()
		{
			InitializeComponent ();
            BindingContext = contact;
        }

        private async void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new MessagePage());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TutorialDemo.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessagesView : ContentPage
	{
		public MessagesView ()
		{
			InitializeComponent ();
            BindingContext = new MessagesViewModel();
            MessagingCenter.Subscribe<MessagesViewModel>(new MessagesViewModel(), "Button clicked", (sender) =>
              {
                  DisplayAlert("Message", "Button clicked", "ok");
              });
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TutorialDemo.ViewModel
{
    class MessagesViewModel

    {
        public ICommand ButtonClickedCommand { get; set; }
        public MessagesViewModel()
        {
            ButtonClickedCommand = new Command(HandleButtonClick);
        }
        private void HandleButtonClick()
        {
            MessagingCenter.Send<MessagesViewModel>(this, "Button clicked");
        }
    }
}

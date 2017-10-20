using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDemo.Model;
using TutorialDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TutorialDemo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Displaylist : ContentPage
    {
        public Displaylist()
        {
            InitializeComponent();
            BindingContext = new ListPageViewModel();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }
            else
            {
                Person person = e.SelectedItem as Person;
                DisplayAlert("Selected", person.LastName, "ok");


            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDemo.Model;

namespace TutorialDemo.ViewModel
{
    class ListPageViewModel
    {
        public ObservableCollection<Person> People { get; set; } =
           new ObservableCollection<Person>();
        public ListPageViewModel()
        {
            for (int i = 1; i < 5; i++)
            {
                Person person = new Person();
                person.FirstName = "Aswani";
                person.LastName="Unni"+ i.ToString();
                person.Address = i.ToString() + "MainStreet";
                person.ImageSource = "a" + i.ToString() + ".jpg";
                People.Add(person);
            }
        }
    }
}

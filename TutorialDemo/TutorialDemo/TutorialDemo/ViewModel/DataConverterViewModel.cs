using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDemo.Model;
using static System.Math;

namespace TutorialDemo.ViewModel
{
    class DataConverterViewModel
    {
        public ObservableCollection<Person> People { get; set; } =
          new ObservableCollection<Person>();
        public DataConverterViewModel()
        {
            Random rand = new Random();
            for (int i = 1; i < 5; i++)
            {
                Person person = new Person();
                person.FirstName = "Aswani";
                person.Age = (decimal)(35 + rand.NextDouble());
                People.Add(person);
            }
        }
    }
}

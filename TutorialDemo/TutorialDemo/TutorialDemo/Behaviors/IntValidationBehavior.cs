using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TutorialDemo.Behaviors
{
    class IntValidationBehavior: Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += onEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= onEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        private void onEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            bool isValid = int.TryParse(e.NewTextValue, out int result);
            Entry entry = sender as Entry;
            entry.TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}

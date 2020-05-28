
using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.Windows;

namespace SpecialDays
{
    //public class SpecialDates : SpecialDatesCollection
    //{

    //}


    public class ViewModel : NotificationObject
    {
        private SpecialDatesCollection specialDates = new SpecialDatesCollection();
        public SpecialDatesCollection SpecialDates
        {
            get
            {
                return specialDates;
            }
            set
            {
                specialDates = value;
                this.RaisePropertyChanged(nameof(SpecialDates));
            }
        }
        public ViewModel()
        {
        }
    }
}

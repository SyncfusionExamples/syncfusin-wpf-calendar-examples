

using Syncfusion.Windows.Shared;
using System;

namespace MonthNames
{
    class ViewModel : NotificationObject
    {

        private bool disableDateSelection;
        private bool isReadOnly;
        private bool showPreviousMonthDays;
        private bool minMaxHidden;
        private bool showNextMonthDays;
        private DateTime minDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day -10);
        private DateTime maxDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 14);

        #region Restrict the DateTime selection

        public DateTime MinDateTime
        {
            get
            {
                return minDateTime;
            }
            set
            {
                minDateTime = value;
                this.RaisePropertyChanged(nameof(MinDateTime));
            }
        }
        public DateTime MaxDateTime
        {
            get
            {
                return maxDateTime;
            }
            set
            {
                maxDateTime = value;
                this.RaisePropertyChanged(nameof(MaxDateTime));
            }
        }

        public bool DisableDateSelection
        {
            get
            {
                return disableDateSelection;
            }
            set
            {
                disableDateSelection = value;
                this.RaisePropertyChanged(nameof(DisableDateSelection));
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return isReadOnly;
            }
            set
            {
                isReadOnly = value;
                this.RaisePropertyChanged(nameof(IsReadOnly));
            }
        }
        
        public bool MinMaxHidden
        {
            get
            {
                return minMaxHidden;
            }
            set
            {
                minMaxHidden = value;
                this.RaisePropertyChanged(nameof(MinMaxHidden));
            }
        }

        public bool ShowPreviousMonthDays
        {
            get
            {
                return showPreviousMonthDays;
            }
            set
            {
                showPreviousMonthDays = value;
                this.RaisePropertyChanged(nameof(ShowPreviousMonthDays));
            }
        }
        
        public bool ShowNextMonthDays
        {
            get
            {
                return showNextMonthDays;
            }
            set
            {
                showNextMonthDays = value;
                this.RaisePropertyChanged(nameof(ShowNextMonthDays));
            }
        }


        #endregion
    }
}

using Syncfusion.Windows.Shared;
using System;
using System.Windows.Media;

namespace Select_Date
{
    class ViewModel : NotificationObject
    {
        private DateTime selectedDate=DateTime.Now;
        private bool allowMultiplySelection=true;
        private bool todayRowIsVisible=true;
        private bool showAbbreviatedDayNames;
        private bool showAbbreviatedMonthNames;
        private Brush selectedDayCellBackground = Brushes.Yellow;
        private Brush selectedDayCellBorderBrush = Brushes.Blue;
        private Brush selectionForeground = Brushes.Red;
        private Brush selectedDayCellHoverBackground = Brushes.Green;
        private Brush selectionBorderBrush = Brushes.Red;
        private Brush todayCellSelectedBorderBrush = Brushes.Red;
        private Brush todayCellSelectedBackground= Brushes.Green;
        private Brush todayCellForeground= Brushes.Yellow;
        private Brush notCurrentMonthForeground = Brushes.Pink;
        private CalendarVisualMode visualMode = CalendarVisualMode.WeekNumbers;
        private bool showWeekNumbers= true;
        private Brush weekNumberBackground=Brushes.Red;
        private Brush weekNumberBorderBrush = Brushes.Green;
        private Brush weekNumberForeground = Brushes.Yellow;
        private Brush weekNumberHoverBackground=Brushes.Yellow;
        private Brush weekNumberHoverBorderBrush = Brushes.Blue;
        private Brush weekNumberHoverForeground = Brushes.Green;


        #region Highlight week numbers

        public bool ShowWeekNumbers
        {
            get
            {
                return showWeekNumbers;
            }
            set
            {
                showWeekNumbers = value;
                this.RaisePropertyChanged(nameof(ShowWeekNumbers));
            }
        }
        
        public Brush WeekNumberBackground
        {
            get
            {
                return weekNumberBackground;
            }
            set
            {
                weekNumberBackground = value;
                this.RaisePropertyChanged(nameof(WeekNumberBackground));
            }
        }
        
        public Brush WeekNumberBorderBrush
        {
            get
            {
                return weekNumberBorderBrush;
            }
            set
            {
                weekNumberBorderBrush = value;
                this.RaisePropertyChanged(nameof(WeekNumberBorderBrush));
            }
        }

        public Brush WeekNumberForeground
        {
            get
            {
                return weekNumberForeground;
            }
            set
            {
                weekNumberForeground = value;
                this.RaisePropertyChanged(nameof(WeekNumberForeground));
            }
        }
        public Brush WeekNumberHoverBackground
        {
            get
            {
                return weekNumberHoverBackground;
            }
            set
            {
                weekNumberHoverBackground = value;
                this.RaisePropertyChanged(nameof(WeekNumberHoverBackground));
            }
        }
        
        public Brush WeekNumberHoverBorderBrush
        {
            get
            {
                return weekNumberHoverBorderBrush;
            }
            set
            {
                weekNumberHoverBorderBrush = value;
                this.RaisePropertyChanged(nameof(WeekNumberHoverBorderBrush));
            }
        }

        public Brush WeekNumberHoverForeground
        {
            get
            {
                return weekNumberHoverForeground;
            }
            set
            {
                weekNumberHoverForeground = value;
                this.RaisePropertyChanged(nameof(WeekNumberHoverForeground));
            }
        }


        #endregion

        #region DateTime selection

        public DateTime SelectedDate
        {
            get
            {
                return selectedDate;
            }
            set
            {
                selectedDate = value;
                this.RaisePropertyChanged(nameof(SelectedDate));
            }
        }

        public bool AllowMultiplySelection
        {
            get
            {
                return allowMultiplySelection;
            }
            set
            {
                allowMultiplySelection = value;
                this.RaisePropertyChanged(nameof(AllowMultiplySelection));
            }
        }
        
        public bool TodayRowIsVisible
        {
            get
            {
                return todayRowIsVisible;
            }
            set
            {
                todayRowIsVisible = value;
                this.RaisePropertyChanged(nameof(TodayRowIsVisible));
            }
        }
        
        public bool ShowAbbreviatedDayNames
        {
            get
            {
                return showAbbreviatedDayNames;
            }
            set
            {
                showAbbreviatedDayNames = value;
                this.RaisePropertyChanged(nameof(ShowAbbreviatedDayNames));
            }
        }
        
        public bool ShowAbbreviatedMonthNames
        {
            get
            {
                return showAbbreviatedMonthNames;
            }
            set
            {
                showAbbreviatedMonthNames = value;
                this.RaisePropertyChanged(nameof(ShowAbbreviatedMonthNames));
            }
        }
        #endregion

        #region Highlight selected date
        public CalendarVisualMode VisualMode
        {
            get
            {
                return visualMode;
            }
            set
            {
                visualMode = value;
                this.RaisePropertyChanged(nameof(VisualMode));
            }
        } 
        
        public Brush SelectedDayCellBackground
        {
            get
            {
                return selectedDayCellBackground;
            }
            set
            {
                selectedDayCellBackground = value;
                this.RaisePropertyChanged(nameof(SelectedDayCellBackground));
            }
        } 
        
        public Brush NotCurrentMonthForeground
        {
            get
            {
                return notCurrentMonthForeground;
            }
            set
            {
                notCurrentMonthForeground = value;
                this.RaisePropertyChanged(nameof(NotCurrentMonthForeground));
            }
        }
        
        public Brush SelectedDayCellBorderBrush
        {
            get
            {
                return selectedDayCellBorderBrush;
            }
            set
            {
                selectedDayCellBorderBrush = value;
                this.RaisePropertyChanged(nameof(SelectedDayCellBorderBrush));
            }
        }

        public Brush SelectionForeground
        {
            get
            {
                return selectionForeground;
            }
            set
            {
                selectionForeground = value;
                this.RaisePropertyChanged(nameof(SelectionForeground));
            }
        }
        
        public Brush SelectedDayCellHoverBackground
        {
            get
            {
                return selectedDayCellHoverBackground;
            }
            set
            {
                selectedDayCellHoverBackground = value;
                this.RaisePropertyChanged(nameof(SelectedDayCellHoverBackground));
            }
        }
        
        public Brush SelectionBorderBrush
        {
            get
            {
                return selectionBorderBrush;
            }
            set
            {
                selectionBorderBrush = value;
                this.RaisePropertyChanged(nameof(SelectionBorderBrush));
            }
        }

        #endregion


        #region Highlight today date

        public Brush TodayCellSelectedBorderBrush
        {
            get
            {
                return todayCellSelectedBorderBrush;
            }
            set
            {
                todayCellSelectedBorderBrush = value;
                this.RaisePropertyChanged(nameof(TodayCellSelectedBorderBrush));
            }
        }
        public Brush TodayCellSelectedBackground
        {
            get
            {
                return todayCellSelectedBackground;
            }
            set
            {
                todayCellSelectedBackground = value;
                this.RaisePropertyChanged(nameof(TodayCellSelectedBackground));
            }
        }
        public Brush TodayCellForeground
        {
            get
            {
                return todayCellForeground;
            }
            set
            {
                todayCellForeground = value;
                this.RaisePropertyChanged(nameof(TodayCellForeground));
            }
        }
        #endregion

    }
}

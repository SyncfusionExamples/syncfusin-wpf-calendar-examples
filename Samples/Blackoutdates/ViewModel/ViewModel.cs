using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Blackoutdates
{
    class ViewModel : NotificationObject
    {
        private Brush blackoutDatesBackground = Brushes.Yellow;
        private Brush blackoutDatesBorderBrush = Brushes.Green;
        private Brush blackoutDatesCrossBrush = Brushes.Red;
        private Brush blackoutDatesForeground = Brushes.Blue;

        public Brush BlackoutDatesBackground
        {
            get
            {
                return blackoutDatesBackground;
            }
            set
            {
                blackoutDatesBackground = value;
                this.RaisePropertyChanged(nameof(BlackoutDatesBackground));
            }
        }

        public Brush BlackoutDatesBorderBrush
        {
            get
            {
                return blackoutDatesBorderBrush;
            }
            set
            {
                blackoutDatesBorderBrush = value;
                this.RaisePropertyChanged(nameof(BlackoutDatesBorderBrush));
            }
        }

        public Brush BlackoutDatesCrossBrush
        {
            get
            {
                return blackoutDatesCrossBrush;
            }
            set
            {
                blackoutDatesCrossBrush = value;
                this.RaisePropertyChanged(nameof(BlackoutDatesCrossBrush));
            }
        }

        public Brush BlackoutDatesForeground
        {
            get
            {
                return blackoutDatesForeground;
            }
            set
            {
                blackoutDatesForeground = value;
                this.RaisePropertyChanged(nameof(BlackoutDatesForeground));
            }
        }
    }
}

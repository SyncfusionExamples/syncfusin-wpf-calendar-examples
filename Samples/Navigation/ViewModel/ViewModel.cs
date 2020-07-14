using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Navigation 
{
    class ViewModel : NotificationObject
    {
        private Brush headerBackground= Brushes.Green;
        private Brush headerForeground = Brushes.Yellow;
        private int changeModeTime= 100;
        private int frameMovingTime= 100;
        private AnimationDirection monthChangeDirection= AnimationDirection.Vertical;

        public Brush HeaderBackground
        {
            get
            {
                return headerBackground;
            }
            set
            {
                headerBackground = value;
                this.RaisePropertyChanged(nameof(HeaderBackground));
            }
        }
        
        
        public Brush HeaderForeground
        {
            get
            {
                return headerForeground;
            }
            set
            {
                headerForeground = value;
                this.RaisePropertyChanged(nameof(HeaderForeground));
            }
        }

        public int ChangeModeTime
        {
            get
            {
                return changeModeTime;
            }
            set
            {
                changeModeTime = value;
                this.RaisePropertyChanged(nameof(ChangeModeTime));
            }
        }

        public AnimationDirection MonthChangeDirection
        {
            get
            {
                return monthChangeDirection;
            }
            set
            {
                monthChangeDirection = value;
                this.RaisePropertyChanged(nameof(MonthChangeDirection));
            }
        }

        public int FrameMovingTime
        {
            get
            {
                return frameMovingTime;
            }
            set
            {
                frameMovingTime = value;
                this.RaisePropertyChanged(nameof(FrameMovingTime));
            }
        }

        public ViewModel()
        {

        }

    }
}

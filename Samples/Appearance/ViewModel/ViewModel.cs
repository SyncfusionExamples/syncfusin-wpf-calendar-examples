using Syncfusion.Windows.Shared;
using System.Windows;
using System.Windows.Media;

namespace Themes
{
    class ViewModel : NotificationObject
    {
        private FlowDirection flowDirection;
        private Brush background = Brushes.Yellow;
        private Brush mouseOverForeground = Brushes.Orange;
        private Brush foreground = Brushes.Red;
        private Brush mouseOverBackground = Brushes.Red;
        private Brush mouseOverBorderBrush= Brushes.Blue;

        public Brush Background
        {
            get { return background; }
            set
            {
                background = value;
                this.RaisePropertyChanged(nameof(Background));
            }
        } 
        
        public Brush MouseOverBorderBrush
        {
            get { return mouseOverBorderBrush; }
            set
            {
                mouseOverBorderBrush = value;
                this.RaisePropertyChanged(nameof(MouseOverBorderBrush));
            }
        } 
        
        public Brush MouseOverBackground
        {
            get { return mouseOverBackground; }
            set
            {
                mouseOverBackground = value;
                this.RaisePropertyChanged(nameof(MouseOverBackground));
            }
        }

        public Brush MouseOverForeground
        {
            get { return mouseOverForeground; }
            set
            {
                mouseOverForeground = value;
                this.RaisePropertyChanged(nameof(MouseOverForeground));
            }
        }

        public Brush Foreground
        {
            get { return foreground; }
            set
            {
                foreground = value;
                this.RaisePropertyChanged(nameof(Foreground));
            }
        }

        public FlowDirection FlowDirection
        {
            get { return flowDirection; }
            set
            {
                flowDirection = value;
                this.RaisePropertyChanged(nameof(FlowDirection));
            }
        }

        public ViewModel()
        {

        }
    }
}
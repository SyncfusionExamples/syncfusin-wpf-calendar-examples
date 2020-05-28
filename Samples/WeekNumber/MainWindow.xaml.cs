using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalendarEdit_Weeknumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        void GetWeekNumber(CalendarEdit sender)
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            int weekNum = currentCulture.Calendar.GetWeekOfYear(sender.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
            label.Text = weekNum.ToString();
        }

        private void calendar_MouseDown(object sender, MouseButtonEventArgs e) {
            GetWeekNumber(sender as CalendarEdit);
        }

        private void calendar_Loaded(object sender, RoutedEventArgs e)
        {
            GetWeekNumber(sender as CalendarEdit);
        }

        private void calendar_PreviewKeyUp(object sender, KeyEventArgs e) {
            GetWeekNumber(sender as CalendarEdit);
        }
    }
}

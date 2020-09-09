using Syncfusion.Windows.Shared;
using System.Windows;
using System.Windows.Controls;

namespace CalenderEdit_DataTemplateSelector
{
    public class CalendarDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }

        //Day Cell Templates
        public DataTemplate DayCellTemplate1 { get; set; }
        public DataTemplate DayCellTemplate2 { get; set; }

        //DayName Cell Templates
        public DataTemplate DayNameCellTemplate1 { get; set; }
        public DataTemplate DayNameCellTemplate2 { get; set; }

        //Month Cell Templates
        public DataTemplate MonthCellTemplate1 { get; set; }
        public DataTemplate MonthCellTemplate2 { get; set; }

        //Year Cell Templates
        public DataTemplate YearCellTemplate1 { get; set; }
        public DataTemplate YearCellTemplate2 { get; set; }

        //Year range Cell Templates
        public DataTemplate YearRangeCellTemplate1 { get; set; }
        public DataTemplate YearRangeCellTemplate2 { get; set; }

        //Week numbers cell Templates
        public DataTemplate WeekNumberCellTemplate1 { get; set; }
        public DataTemplate WeekNumberCellTemplate2 { get; set; }


        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var cellInfo = item as CellInfo;

            //Day Cell Templates
            if (cellInfo.CellType == CellType.DayCell
                && string.Equals(cellInfo.Content.ToString(), "10"))
            {

                return DayCellTemplate1;
            }
            else if (cellInfo.CellType == CellType.DayCell
                && string.Equals(cellInfo.Content.ToString(), "25"))
            {

                return DayCellTemplate2;
            }

            //Day Name Cell Templates
            else if (cellInfo.CellType == CellType.DayNameCell && string.Equals(cellInfo.Content.ToString(), "Tu"))
            {

                return DayNameCellTemplate1;
            }
            else if (cellInfo.CellType == CellType.DayNameCell && string.Equals(cellInfo.Content.ToString(), "Fr"))
            {

                return DayNameCellTemplate2;
            }

            //Month Cell Templates
            else if (cellInfo.CellType == CellType.MonthCell && string.Equals(cellInfo.Content.ToString(), "May"))
            {
                return MonthCellTemplate1;
            }
            else if (cellInfo.CellType == CellType.MonthCell && string.Equals(cellInfo.Content.ToString(), "Aug"))
            {

                return MonthCellTemplate2;
            }

            //Year Cell Templates
            else if (cellInfo.CellType == CellType.YearCell && string.Equals(cellInfo.Content.ToString(), "2020"))
            {

                return YearCellTemplate1;
            }
            else if (cellInfo.CellType == CellType.YearCell && string.Equals(cellInfo.Content.ToString(), "2029"))
            {

                return YearCellTemplate2;
            }

            //Year range cell Templates
            else if (cellInfo.CellType == CellType.YearRangeCell && string.Equals(cellInfo.Content.ToString(), "2000-\n2009"))
            {

                return YearRangeCellTemplate1;
            }
            else if (cellInfo.CellType == CellType.YearRangeCell && string.Equals(cellInfo.Content.ToString(), "2090-\n2099"))
            {

                return YearRangeCellTemplate2;
            }

            //Week numbers cell Templates
            else if (cellInfo.CellType == CellType.WeekNumberCell && string.Equals(cellInfo.Content.ToString(), "6"))
            {

                return WeekNumberCellTemplate1;
            }
            else if (cellInfo.CellType == CellType.WeekNumberCell && string.Equals(cellInfo.Content.ToString(), "8"))
            {

                return WeekNumberCellTemplate2;
            }
            else
            {

                return DefaultTemplate;
            }
        }
    }
}

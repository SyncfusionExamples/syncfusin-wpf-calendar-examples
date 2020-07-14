
using Syncfusion.Windows.Shared;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace SpecialDays
{
	public class ViewModel
	{
		public ViewModel()
		{
			specialDays = new SpecialDatesCollection();
			PopulateData();
		}

		private void PopulateData()
		{
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 1, 12), CellTemplate = System.Windows.Application.Current.TryFindResource("NationalYouthDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 1, 15), CellTemplate = System.Windows.Application.Current.TryFindResource("ArmyDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 2, 4), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldCancerDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 2, 14), CellTemplate = System.Windows.Application.Current.TryFindResource("Valentine Day") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 12, 2), CellTemplate = System.Windows.Application.Current.TryFindResource("PollutionPreventionDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 3, 8), CellTemplate = System.Windows.Application.Current.TryFindResource("WomensDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 3, 21), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldForestryDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 3, 24), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldDayforWater") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 4, 7), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldHealthDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 4, 22), CellTemplate = System.Windows.Application.Current.TryFindResource("EarthDay") as DataTemplate });

			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 5, 1), CellTemplate = System.Windows.Application.Current.TryFindResource("WorkersDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 5, 31), CellTemplate = System.Windows.Application.Current.TryFindResource("Anti-tobaccoDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 6, 5), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldEnvironmentDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 6, 14), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldBloodDonorDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 6, 21), CellTemplate = System.Windows.Application.Current.TryFindResource("DayofYoga") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 7, 1), CellTemplate = System.Windows.Application.Current.TryFindResource("DoctorsDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 8, 6), CellTemplate = System.Windows.Application.Current.TryFindResource("HiroshimaDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 8, 19), CellTemplate = System.Windows.Application.Current.TryFindResource("PhotographyDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 8, 29), CellTemplate = System.Windows.Application.Current.TryFindResource("NationalSportsDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 9, 15), CellTemplate = System.Windows.Application.Current.TryFindResource("EngineersDay") as DataTemplate });

			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 9, 16), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldOzoneDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 9, 27), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldTourismDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 10, 9), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldPostOfficeDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 10, 16), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldFoodDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 11, 5), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldTsunamiDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 11, 14), CellTemplate = System.Windows.Application.Current.TryFindResource("ChildrensDay") as DataTemplate });

			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 12, 1), CellTemplate = System.Windows.Application.Current.TryFindResource("WorldAIDSDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 12, 22), CellTemplate = System.Windows.Application.Current.TryFindResource("NationalMathematicsDay") as DataTemplate });
			specialDays.Add(new SpecialDate() { Date = new System.DateTime(DateTime.Now.Year, 12, 25), CellTemplate = System.Windows.Application.Current.TryFindResource("Christmas") as DataTemplate });


		}
		private SpecialDatesCollection SpecialDaysCollection;
		public SpecialDatesCollection specialDays
		{
			get { return SpecialDaysCollection; }
			set { SpecialDaysCollection = value; }
		}

	}
}

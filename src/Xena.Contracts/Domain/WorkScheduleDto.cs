using System;
using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class WorkScheduleDto : EntityDto
    {
        public string Description { get; set; }

        public int? MondayStartTimeHours { get; set; }
        public int? MondayStartTimeMinutes { get; set; }
        public int MondayEndTimeHours { get; set; }
        public int MondayEndTimeMinutes { get; set; }

        private string _mondayStartTimeFriendly = null;
        [ReadOnly(true)]
        public string MondayStartTimeFriendly
        {
            get { return _mondayStartTimeFriendly ?? TimeFriendly(MondayStartTimeHours, MondayStartTimeMinutes); }
            set { _mondayStartTimeFriendly = value; }
        }

        private string _mondayEndTimeFriendly = null;
        [ReadOnly(true)]
        public string MondayEndTimeFriendly
        {
            get { return _mondayEndTimeFriendly ?? TimeFriendly(MondayEndTimeHours, MondayEndTimeMinutes); }
            set { _mondayEndTimeFriendly = value; }
        }


        public int? TuesdayStartTimeHours { get; set; }
        public int? TuesdayStartTimeMinutes { get; set; }
        public int TuesdayEndTimeHours { get; set; }
        public int TuesdayEndTimeMinutes { get; set; }
        private string _tuesdayStartTimeFriendly = null;
        [ReadOnly(true)]
        public string TuesdayStartTimeFriendly
        {
            get { return _tuesdayStartTimeFriendly ?? TimeFriendly(TuesdayStartTimeHours, TuesdayStartTimeMinutes); }
            set { _tuesdayStartTimeFriendly = value; }
        }

        private string _tuesdayEndTimeFriendly = null;
        [ReadOnly(true)]
        public string TuesdayEndTimeFriendly
        {
            get { return _tuesdayEndTimeFriendly ?? TimeFriendly(TuesdayEndTimeHours, TuesdayEndTimeMinutes); }
            set { _tuesdayEndTimeFriendly = value; }
        }


        public int? WednesdayStartTimeHours { get; set; }
        public int? WednesdayStartTimeMinutes { get; set; }
        public int WednesdayEndTimeHours { get; set; }
        public int WednesdayEndTimeMinutes { get; set; }
        private string _wednesdayStartTimeFriendly = null;
        [ReadOnly(true)]
        public string WednesdayStartTimeFriendly
        {
            get { return _wednesdayStartTimeFriendly ?? TimeFriendly(WednesdayStartTimeHours, WednesdayStartTimeMinutes); }
            set { _wednesdayStartTimeFriendly = value; }
        }

        private string _wednesdayEndTimeFriendly = null;
        [ReadOnly(true)]
        public string WednesdayEndTimeFriendly
        {
            get { return _wednesdayEndTimeFriendly ?? TimeFriendly(WednesdayEndTimeHours, WednesdayEndTimeMinutes); }
            set { _wednesdayEndTimeFriendly = value; }
        }


        public int? ThursdayStartTimeHours { get; set; }
        public int? ThursdayStartTimeMinutes { get; set; }
        public int ThursdayEndTimeHours { get; set; }
        public int ThursdayEndTimeMinutes { get; set; }
        private string _thursdayStartTimeFriendly = null;
        [ReadOnly(true)]
        public string ThursdayStartTimeFriendly
        {
            get { return _thursdayStartTimeFriendly ?? TimeFriendly(ThursdayStartTimeHours, ThursdayStartTimeMinutes); }
            set { _thursdayStartTimeFriendly = value; }
        }

        private string _thursdayEndTimeFriendly = null;
        [ReadOnly(true)]
        public string ThursdayEndTimeFriendly
        {
            get { return _thursdayEndTimeFriendly ?? TimeFriendly(ThursdayEndTimeHours, ThursdayEndTimeMinutes); }
            set { _thursdayEndTimeFriendly = value; }
        }

        public int? FridayStartTimeHours { get; set; }
        public int? FridayStartTimeMinutes { get; set; }
        public int FridayEndTimeHours { get; set; }
        public int FridayEndTimeMinutes { get; set; }
        private string _fridayStartTimeFriendly = null;
        [ReadOnly(true)]
        public string FridayStartTimeFriendly
        {
            get { return _fridayStartTimeFriendly ?? TimeFriendly(FridayStartTimeHours, FridayStartTimeMinutes); }
            set { _fridayStartTimeFriendly = value; }
        }

        private string _fridayEndTimeFriendly = null;
        [ReadOnly(true)]
        public string FridayEndTimeFriendly
        {
            get { return _fridayEndTimeFriendly ?? TimeFriendly(FridayEndTimeHours, FridayEndTimeMinutes); }
            set { _fridayEndTimeFriendly = value; }
        }

        public int? SaturdayStartTimeHours { get; set; }
        public int? SaturdayStartTimeMinutes { get; set; }
        public int SaturdayEndTimeHours { get; set; }
        public int SaturdayEndTimeMinutes { get; set; }
        private string _saturdayStartTimeFriendly = null;
        [ReadOnly(true)]
        public string SaturdayStartTimeFriendly
        {
            get { return _saturdayStartTimeFriendly ?? TimeFriendly(SaturdayStartTimeHours, SaturdayStartTimeMinutes); }
            set { _saturdayStartTimeFriendly = value; }
        }

        private string _saturdayEndTimeFriendly = null;
        [ReadOnly(true)]
        public string SaturdayEndTimeFriendly
        {
            get { return _saturdayEndTimeFriendly ?? TimeFriendly(SaturdayEndTimeHours, SaturdayEndTimeMinutes); }
            set { _saturdayEndTimeFriendly = value; }
        }

        public int? SundayStartTimeHours { get; set; }
        public int? SundayStartTimeMinutes { get; set; }
        public int SundayEndTimeHours { get; set; }
        public int SundayEndTimeMinutes { get; set; }
        private string _sundayStartTimeFriendly = null;
        [ReadOnly(true)]
        public string SundayStartTimeFriendly
        {
            get { return _sundayStartTimeFriendly ?? TimeFriendly(SundayStartTimeHours, SundayStartTimeMinutes); }
            set { _sundayStartTimeFriendly = value; }
        }

        private string _sundayEndTimeFriendly = null;
        [ReadOnly(true)]
        public string SundayEndTimeFriendly
        {
            get { return _sundayEndTimeFriendly ?? TimeFriendly(SundayEndTimeHours, SundayEndTimeMinutes); }
            set { _sundayEndTimeFriendly = value; }
        }

        [ReadOnly(true)]
        public bool IsCompanyDefault { get; set; }

        private string TimeFriendly(int? hours, int? minutes)
        {
            return $"{hours?.ToString("D2") ?? 0.ToString("D2")}:{minutes?.ToString("D2") ?? 0.ToString("D2")}";
        }

    }

}
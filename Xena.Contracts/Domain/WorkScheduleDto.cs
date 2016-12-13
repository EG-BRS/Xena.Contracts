using System;

namespace Xena.Contracts.Domain
{
    public class WorkScheduleDto : EntityDto
    {
        public string Description { get; set; }

        public int? MondayStartTimeHours { get; set; }
        public int? MondayStartTimeMinutes { get; set; }
        public int MondayEndTimeHours { get; set; }
        public int MondayEndTimeMinutes { get; set; }

        public string MondayStartTimeFriendly
        {
            get { return TimeFriendly(MondayStartTimeHours, MondayStartTimeMinutes); }
        }
        public string MondayEndTimeFriendly
        {
            get { return TimeFriendly(MondayEndTimeHours, MondayEndTimeMinutes); }
        }



        public int? TuesdayStartTimeHours { get; set; }
        public int? TuesdayStartTimeMinutes { get; set; }
        public int TuesdayEndTimeHours { get; set; }
        public int TuesdayEndTimeMinutes { get; set; }
        public string TuesdayStartTimeFriendly
        {
            get { return TimeFriendly(TuesdayStartTimeHours, TuesdayStartTimeMinutes); }
        }
        public string TuesdayEndTimeFriendly
        {
            get { return TimeFriendly(TuesdayEndTimeHours, TuesdayEndTimeMinutes); }
        }


        public int? WednesdayStartTimeHours { get; set; }
        public int? WednesdayStartTimeMinutes { get; set; }
        public int WednesdayEndTimeHours { get; set; }
        public int WednesdayEndTimeMinutes { get; set; }
        public string WednesdayStartTimeFriendly
        {
            get { return TimeFriendly(WednesdayStartTimeHours, WednesdayStartTimeMinutes); }
        }
        public string WednesdayEndTimeFriendly
        {
            get { return TimeFriendly(WednesdayEndTimeHours, WednesdayEndTimeMinutes); }
        }


        public int? ThursdayStartTimeHours { get; set; }
        public int? ThursdayStartTimeMinutes { get; set; }
        public int ThursdayEndTimeHours { get; set; }
        public int ThursdayEndTimeMinutes { get; set; }
        public string ThursdayStartTimeFriendly
        {
            get { return TimeFriendly(ThursdayStartTimeHours, ThursdayStartTimeMinutes); }
        }
        public string ThursdayEndTimeFriendly
        {
            get { return TimeFriendly(ThursdayEndTimeHours, ThursdayEndTimeMinutes); }
        }

        public int? FridayStartTimeHours { get; set; }
        public int? FridayStartTimeMinutes { get; set; }
        public int FridayEndTimeHours { get; set; }
        public int FridayEndTimeMinutes { get; set; }
        public string FridayStartTimeFriendly
        {
            get { return TimeFriendly(FridayStartTimeHours, FridayStartTimeMinutes); }
        }
        public string FridayEndTimeFriendly
        {
            get { return TimeFriendly(FridayEndTimeHours, FridayEndTimeMinutes); }
        }

        public int? SaturdayStartTimeHours { get; set; }
        public int? SaturdayStartTimeMinutes { get; set; }
        public int SaturdayEndTimeHours { get; set; }
        public int SaturdayEndTimeMinutes { get; set; }
        public string SaturdayStartTimeFriendly
        {
            get { return TimeFriendly(SaturdayStartTimeHours, SaturdayStartTimeMinutes); }
        }
        public string SaturdayEndTimeFriendly
        {
            get { return TimeFriendly(SaturdayEndTimeHours, SaturdayEndTimeMinutes); }
        }

        public int? SundayStartTimeHours { get; set; }
        public int? SundayStartTimeMinutes { get; set; }
        public int SundayEndTimeHours { get; set; }
        public int SundayEndTimeMinutes { get; set; }
        public string SundayStartTimeFriendly
        {
            get { return TimeFriendly(SundayStartTimeHours, SundayStartTimeMinutes); }
        }
        public string SundayEndTimeFriendly
        {
            get { return TimeFriendly(MondayEndTimeHours, MondayEndTimeMinutes); }
        }

        private string TimeFriendly(int? hours, int? minutes)
        {
            return string.Format("{0}:{1}", (hours.HasValue ? hours.Value.ToString("D2") : 0.ToString("D2")), (minutes.HasValue ? minutes.Value.ToString("D2") : 0.ToString("D2")));
        }

    }

}
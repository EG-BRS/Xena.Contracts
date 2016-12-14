namespace Xena.Contracts.Helpers
{
    public class SettingData
    {
        public bool NewValue { get; set; }
        public string Setting { get; set; }

        public SettingData()
        {

        }

        public SettingData(bool newValue, string setting)
        {
            NewValue = newValue;
            Setting = setting;
        }
    }
}
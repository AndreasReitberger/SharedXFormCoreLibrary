namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    // Source: https://github.com/AndreasReitberger/SharedMauiCoreLibrary/blob/main/source/SharedMauiCoreLibrary/SharedMauiCoreLibrary/Converters/UnixDoubleHoursToTimeSpanConverter.cs
    public sealed class UnixDoubleHoursToTimeSpanConverter : IValueConverter
    {
        public bool WithMiliSeconds { get; set; } = false;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                TimeSpan ts = TimeSpan.FromSeconds(System.Convert.ToDouble(value));
                if (WithMiliSeconds)
                    ts = new TimeSpan(ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
                return ts;
            }
            catch (Exception)
            {
                return TimeSpan.Zero;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TimeSpan ts = (TimeSpan)value;
            return ts.TotalSeconds;
        }
    }
}

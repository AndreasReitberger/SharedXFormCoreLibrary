namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    public sealed class DoubleHoursToTimeSpanConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            try
            {
                TimeSpan ts = TimeSpan.FromHours(System.Convert.ToDouble(value));
                return ts;
            }
            catch (Exception)
            {
                return TimeSpan.Zero;
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            TimeSpan ts = (TimeSpan)value;
            if (ts == null)
                return 0;
            return ts.TotalHours;
        }
    }
}

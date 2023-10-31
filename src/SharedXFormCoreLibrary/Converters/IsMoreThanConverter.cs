namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    public sealed class IsMoreThanConverter : IValueConverter
    {
        public double Limit { get; set; } = 0;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double val = System.Convert.ToDouble(value);
            double limit = parameter != null ? System.Convert.ToDouble(parameter) : Limit;
            return (val > limit);
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

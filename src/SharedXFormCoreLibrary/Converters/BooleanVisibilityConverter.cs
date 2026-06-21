namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    public sealed class BooleanVisibilityConverter : IValueConverter
    {

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value is bool visible && visible;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
            //return value is bool visible && !visible;
        }
    }
}

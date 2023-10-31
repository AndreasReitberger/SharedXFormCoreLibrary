namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    public sealed class BooleanReverseVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var returnValue = value is bool visible && !visible;
            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
            //return value is bool visible && visible ? true : false;
        }
    }
}

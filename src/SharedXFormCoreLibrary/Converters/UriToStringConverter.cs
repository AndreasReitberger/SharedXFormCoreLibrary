namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    public sealed class UriToStringConverter : IValueConverter
    {

        public object? Convert(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Uri uri)
            {
                string local = uri.OriginalString;
                return local;
            }
            else return "";
        }

        public object? ConvertBack(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

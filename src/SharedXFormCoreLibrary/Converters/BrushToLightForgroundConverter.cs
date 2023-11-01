namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    /// <summary>
    /// Returns true, if the passed Color needs a light foreground
    /// </summary>
    public sealed class BrushToLightForgroundConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SolidColorBrush color)
            {
                double mean = (color.Color.R + color.Color.G + color.Color.B) / 3;
                return mean < 0.5;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

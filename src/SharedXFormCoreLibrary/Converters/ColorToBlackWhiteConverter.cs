namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    public sealed class ColorToBlackWhiteConverter : IValueConverter
    {

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            Color opposite = Color.Black;
            if (value is Color color)
            {
                double mean = (color.R + color.G + color.B) / 3;
                opposite = mean < 0.5 ? Color.White : Color.Black;
            }
            return opposite;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

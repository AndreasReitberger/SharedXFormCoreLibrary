namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    public sealed class BrushToBlackWhiteConverter : IValueConverter
    {
        public Color White { get; set; } = Color.White;
        public Color Black { get; set; } = Color.Black;

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            Color opposite = Color.Black;
            if (value is SolidColorBrush color)
            {
                double mean = (color.Color.R + color.Color.G + color.Color.B) / 3;
                opposite = mean < 0.5 ?
                    White : Black;
            }
            return opposite;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

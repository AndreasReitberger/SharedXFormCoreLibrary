namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    public class SwipingBoolToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return ImageSource.FromResource("SfListViewSample.Images.Favorites1.png");
            else
                return ImageSource.FromResource("SfListViewSample.Images.InboxIcon.png");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

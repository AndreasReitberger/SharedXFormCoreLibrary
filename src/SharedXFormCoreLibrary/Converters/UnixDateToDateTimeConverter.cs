﻿namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    // Source: https://github.com/AndreasReitberger/SharedMauiCoreLibrary/blob/main/source/SharedMauiCoreLibrary/SharedMauiCoreLibrary/Converters/UnixDateToDateTimeConverter.cs
    public sealed class UnixDateToDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                DateTime dt = DateTime.MinValue;
                TimeSpan ts = TimeSpan.FromSeconds(System.Convert.ToDouble(value));
                dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).Add(ts).ToLocalTime();
                return dt;
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

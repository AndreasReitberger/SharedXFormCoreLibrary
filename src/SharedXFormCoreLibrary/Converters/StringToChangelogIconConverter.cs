using AndreasReitberger.Shared.Core.Enums;
using Xamarin.Forms.Internals;

namespace AndreasReitberger.Shared.XForm.Core.Converters
{
    [Preserve(AllMembers = true)]
    public class StringToChangelogIconConverter : IValueConverter
    {

        public const string Bug = "\U000f00e4";
        public const string CogRefreshOutline = "\U000f145f";
        public const string Autorenew = "\U000f006a";
        public const string PlaylistPlus = "\U000f0412";

        public object? Convert(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            ChangelogType type = ChangelogType.New;
            if (value is string enumString)
            {
                Enum.TryParse(enumString, out type);
                string glyp = PlaylistPlus;
                glyp = type switch
                {
                    ChangelogType.New => PlaylistPlus,
                    ChangelogType.BugFix => Bug,
                    ChangelogType.Changed => Autorenew,
                    ChangelogType.Updated => CogRefreshOutline,
                    _ => PlaylistPlus,
                };
                return glyp;
            }
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

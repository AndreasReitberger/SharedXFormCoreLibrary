using CommunityToolkit.Mvvm.ComponentModel;
using System.Linq;

namespace AndreasReitberger.Shared.XForm.Core.Theme
{
    public partial class DefaultThemeManager : ObservableObject
    {

        #region Instance
        static DefaultThemeManager? _instance = null;
        static readonly object Lock = new();
        public static DefaultThemeManager Instance
        {
            get
            {
                lock (Lock)
                {
                    _instance ??= new DefaultThemeManager();
                }
                return _instance;
            }
            set
            {
                if (_instance == value) return;
                lock (Lock)
                {
                    _instance = value;
                }
            }
        }
        #endregion

        #region Properties
        [ObservableProperty]
        public partial List<ThemeColorInfo> AvailableColors { get; set; } =
        [
            new ThemeColorInfo() { ThemeName = "XForm", PrimaryColor = Color.FromHex("#2196F3"), IsAppDefault = true },
            new ThemeColorInfo() { ThemeName = Color.Gray.ToHex(), PrimaryColor = Color.Gray },
            new ThemeColorInfo() { ThemeName = Color.Brown.ToHex(), PrimaryColor = Color.Brown },
            new ThemeColorInfo() { ThemeName = Color.Green.ToHex(), PrimaryColor = Color.Green },
            new ThemeColorInfo() { ThemeName = Color.Red.ToHex(), PrimaryColor = Color.Red },
            new ThemeColorInfo() { ThemeName = Color.Orange.ToHex(), PrimaryColor = Color.Orange },
            new ThemeColorInfo() { ThemeName = Color.Blue.ToHex(), PrimaryColor = Color.Blue },
            new ThemeColorInfo() { ThemeName = Color.LightGray.ToHex(), PrimaryColor = Color.LightGray },
            new ThemeColorInfo() { ThemeName = Color.Teal.ToHex(), PrimaryColor = Color.Teal },
            new ThemeColorInfo() { ThemeName = Color.Purple.ToHex(), PrimaryColor = Color.Purple },
            new ThemeColorInfo() { ThemeName = Color.Pink.ToHex(), PrimaryColor = Color.Pink },
            new ThemeColorInfo() { ThemeName = Color.Beige.ToHex(), PrimaryColor = Color.Beige },
            new ThemeColorInfo() { ThemeName = Color.Violet.ToHex(), PrimaryColor = Color.Violet },
            new ThemeColorInfo() { ThemeName = Color.Silver.ToHex(), PrimaryColor = Color.Silver },
            new ThemeColorInfo() { ThemeName = Color.Gold.ToHex(), PrimaryColor = Color.Gold },
        ];

        public ThemeColorInfo ActiveTheme => AvailableColors.FirstOrDefault(themeInfo => themeInfo.IsAppDefault);
        #endregion
    }
}

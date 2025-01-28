using CommunityToolkit.Mvvm.ComponentModel;

namespace AndreasReitberger.Shared.XForm.Core.Theme
{
    public partial class ColorInfo : ObservableObject
    {
        #region Properties
        /// <summary>
        /// A matching name for the color information.
        /// </summary>
        [ObservableProperty]
        public partial string Name { get; set; } = string.Empty;

        /// <summary>
        /// The color for this info.
        /// </summary>
        [ObservableProperty]
        public partial Color Color { get; set; }
        partial void OnColorChanged(Color value)
        {
            if (string.IsNullOrEmpty(Name))
                Name = value.ToHex();
        }

        #endregion

        #region Ctor
        public ColorInfo() { }
        public ColorInfo(string colorName, Color color)
        {
            Name = colorName;
            Color = color;
        }
        #endregion
    }
}

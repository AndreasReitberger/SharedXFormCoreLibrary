namespace AndreasReitberger.Shared.XForm.Core.Utilities
{
    public partial class TypeConvertHelper
    {
        #region Converts
        public static T ConvertObject<T>(object input) => (T)Convert.ChangeType(input, typeof(T));
        
        #endregion
    }
}

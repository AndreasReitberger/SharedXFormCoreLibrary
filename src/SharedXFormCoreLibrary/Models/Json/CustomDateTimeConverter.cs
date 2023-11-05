using Newtonsoft.Json.Converters;

namespace AndreasReitberger.Shared.XForm.Core.Models.Json
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Source: https://stackoverflow.com/a/18639829/10083577
        /// License: CC BY-SA 3.0
        /// </summary>
        public CustomDateTimeConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}

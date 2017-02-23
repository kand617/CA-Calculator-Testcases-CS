using Newtonsoft.Json.Converters;

namespace APIMATICCalculatorTestcases.PCL.Utilities
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
using System.ComponentModel;

namespace CurrencyConversion.Models
{
    public enum Currencies
    {
        [Description("British Pounds")]
        GBP,
        [Description("US Dollars")]
        USD,
        [Description("Australian Dollars")]
        AUD,
    }
}
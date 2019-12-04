using System.Threading.Tasks;
using CurrencyConversion.ExternalModels;

namespace CurrencyConversion.Services
{
    public interface IRepository
    {
        Task<RootObject> GetConversion(string source, string target);
    }
}
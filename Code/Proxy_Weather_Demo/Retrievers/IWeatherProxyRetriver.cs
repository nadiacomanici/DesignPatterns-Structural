using System;

namespace Proxy_Weather_Demo.Retrievers
{
    public interface IWeatherProxyRetriver
    {
        double? GetPredictionForDate(string cityId, DateTime referenceDate);
    }
}
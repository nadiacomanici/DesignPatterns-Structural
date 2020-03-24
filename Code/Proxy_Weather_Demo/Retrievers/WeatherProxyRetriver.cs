using System;
using System.Collections.Generic;
using System.Configuration;
using Proxy_Weather_Demo.Helpers;
using Proxy_Weather_Demo.Models;

namespace Proxy_Weather_Demo.Retrievers
{
    public class WeatherProxyRetriver : IWeatherProxyRetriver
    {
        private WeatherApiRetriever _realWeatherApiRetriever;
        private readonly string _apiKey;

        private List<Prediction> _cachedPredictions;
        private DateTime _cachedExpirationTimestamp;

        private WeatherApiRetriever WeatherApiRetriever
        {
            get
            {
                if (_realWeatherApiRetriever == null)
                {
                    _realWeatherApiRetriever = new WeatherApiRetriever(_apiKey);
                }
                return _realWeatherApiRetriever;
            }
        }

        public WeatherProxyRetriver()
        {
            _apiKey = ConfigurationManager.AppSettings.Get("weatherApiKey");
        }

        private bool IsCachedExpired
        {
            get { return _cachedPredictions == null || _cachedPredictions.Count == 0 || _cachedExpirationTimestamp < DateTime.Now; }
        }

        public double? GetPredictionForDate(string cityId, DateTime referenceDate)
        {
            if (IsCachedExpired)
            {
                _cachedPredictions = WeatherApiRetriever.GetPredictionsForCity(cityId);
                _cachedExpirationTimestamp = DateTime.Now.AddMinutes(1);
            }
            return _cachedPredictions.GetPredictionByDate(referenceDate)?.TemperatureInCelsius;
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather.Models
{
    /// <summary> The DailyForecastDetail. </summary>
    public partial class DailyForecastDetail
    {
        /// <summary> Initializes a new instance of <see cref="DailyForecastDetail"/>. </summary>
        internal DailyForecastDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DailyForecastDetail"/>. </summary>
        /// <param name="iconCode"> Numeric value representing an image that displays the `iconPhrase`. Please refer to [Weather services in Azure Maps](/azure/azure-maps/weather-services-concepts#weather-icons) for details. </param>
        /// <param name="iconPhrase"> Phrase description of the icon. Displayed in specified language. For example, 'Sunny'. </param>
        /// <param name="localSource"> Local weather data provider information. </param>
        /// <param name="hasPrecipitation"> Indicates the presence or absence of precipitation. True indicates the presence of precipitation, false indicates the absence of precipitation. </param>
        /// <param name="precipitationType"> Specifies the type of precipitation ("Rain" "Snow" "Ice" or "Mix"). If dbz is zero, precipitationType is not present in the response. </param>
        /// <param name="precipitationIntensity"> Description of the intensity. </param>
        /// <param name="shortDescription"> Phrase description of the forecast in specified language. Azure Maps attempts to keep this phrase under 30 characters in length, but some languages/weather events may result in a longer phrase length, exceeding 30 characters. </param>
        /// <param name="longPhrase"> Phrase description of the forecast in specified language. Azure Maps attempts to keep this phrase under 100 characters in length, but some languages/weather events may result in a longer phrase length, exceeding 100 characters. </param>
        /// <param name="precipitationProbability"> Percent representing the probability of precipitation. For example, '20'. </param>
        /// <param name="thunderstormProbability"> Percent representing the probability of a thunderstorm. For example, '80'. </param>
        /// <param name="rainProbability"> Percent representing the probability of rain. For example, '40'. </param>
        /// <param name="snowProbability"> Percent representing the probability of snow. For example, '30'. </param>
        /// <param name="iceProbability"> Percent representing the probability of ice. For example, '30'. </param>
        /// <param name="wind"> Wind details being returned including speed and direction. </param>
        /// <param name="windGust"> Wind gust. Wind gust is a sudden, brief increase in speed of the wind. </param>
        /// <param name="totalLiquid"> Total liquid equivalent of precipitation during the forecast period. </param>
        /// <param name="rain"> Rain. </param>
        /// <param name="snow"> Snow. </param>
        /// <param name="ice"> Ice. </param>
        /// <param name="hoursOfPrecipitation"> Hours of precipitation. </param>
        /// <param name="hoursOfRain"> Hours of rain. </param>
        /// <param name="hoursOfSnow"> Hours of snow. </param>
        /// <param name="hoursOfIce"> Hours of ice. </param>
        /// <param name="cloudCover"> Percent representing cloud cover. </param>
        internal DailyForecastDetail(IconCode? iconCode, string iconPhrase, LocalSource localSource, bool? hasPrecipitation, PrecipitationType? precipitationType, string precipitationIntensity, string shortDescription, string longPhrase, int? precipitationProbability, int? thunderstormProbability, int? rainProbability, int? snowProbability, int? iceProbability, WindDetails wind, WindDetails windGust, WeatherValue totalLiquid, WeatherValue rain, WeatherValue snow, WeatherValue ice, float? hoursOfPrecipitation, float? hoursOfRain, float? hoursOfSnow, float? hoursOfIce, int? cloudCover)
        {
            IconCode = iconCode;
            IconPhrase = iconPhrase;
            LocalSource = localSource;
            HasPrecipitation = hasPrecipitation;
            PrecipitationType = precipitationType;
            PrecipitationIntensity = precipitationIntensity;
            ShortDescription = shortDescription;
            LongPhrase = longPhrase;
            PrecipitationProbability = precipitationProbability;
            ThunderstormProbability = thunderstormProbability;
            RainProbability = rainProbability;
            SnowProbability = snowProbability;
            IceProbability = iceProbability;
            Wind = wind;
            WindGust = windGust;
            TotalLiquid = totalLiquid;
            Rain = rain;
            Snow = snow;
            Ice = ice;
            HoursOfPrecipitation = hoursOfPrecipitation;
            HoursOfRain = hoursOfRain;
            HoursOfSnow = hoursOfSnow;
            HoursOfIce = hoursOfIce;
            CloudCover = cloudCover;
        }

        /// <summary> Numeric value representing an image that displays the `iconPhrase`. Please refer to [Weather services in Azure Maps](/azure/azure-maps/weather-services-concepts#weather-icons) for details. </summary>
        public IconCode? IconCode { get; }
        /// <summary> Phrase description of the icon. Displayed in specified language. For example, 'Sunny'. </summary>
        public string IconPhrase { get; }
        /// <summary> Local weather data provider information. </summary>
        public LocalSource LocalSource { get; }
        /// <summary> Indicates the presence or absence of precipitation. True indicates the presence of precipitation, false indicates the absence of precipitation. </summary>
        public bool? HasPrecipitation { get; }
        /// <summary> Specifies the type of precipitation ("Rain" "Snow" "Ice" or "Mix"). If dbz is zero, precipitationType is not present in the response. </summary>
        public PrecipitationType? PrecipitationType { get; }
        /// <summary> Description of the intensity. </summary>
        public string PrecipitationIntensity { get; }
        /// <summary> Phrase description of the forecast in specified language. Azure Maps attempts to keep this phrase under 30 characters in length, but some languages/weather events may result in a longer phrase length, exceeding 30 characters. </summary>
        public string ShortDescription { get; }
        /// <summary> Phrase description of the forecast in specified language. Azure Maps attempts to keep this phrase under 100 characters in length, but some languages/weather events may result in a longer phrase length, exceeding 100 characters. </summary>
        public string LongPhrase { get; }
        /// <summary> Percent representing the probability of precipitation. For example, '20'. </summary>
        public int? PrecipitationProbability { get; }
        /// <summary> Percent representing the probability of a thunderstorm. For example, '80'. </summary>
        public int? ThunderstormProbability { get; }
        /// <summary> Percent representing the probability of rain. For example, '40'. </summary>
        public int? RainProbability { get; }
        /// <summary> Percent representing the probability of snow. For example, '30'. </summary>
        public int? SnowProbability { get; }
        /// <summary> Percent representing the probability of ice. For example, '30'. </summary>
        public int? IceProbability { get; }
        /// <summary> Wind details being returned including speed and direction. </summary>
        public WindDetails Wind { get; }
        /// <summary> Wind gust. Wind gust is a sudden, brief increase in speed of the wind. </summary>
        public WindDetails WindGust { get; }
        /// <summary> Total liquid equivalent of precipitation during the forecast period. </summary>
        public WeatherValue TotalLiquid { get; }
        /// <summary> Rain. </summary>
        public WeatherValue Rain { get; }
        /// <summary> Snow. </summary>
        public WeatherValue Snow { get; }
        /// <summary> Ice. </summary>
        public WeatherValue Ice { get; }
        /// <summary> Hours of precipitation. </summary>
        public float? HoursOfPrecipitation { get; }
        /// <summary> Hours of rain. </summary>
        public float? HoursOfRain { get; }
        /// <summary> Hours of snow. </summary>
        public float? HoursOfSnow { get; }
        /// <summary> Hours of ice. </summary>
        public float? HoursOfIce { get; }
        /// <summary> Percent representing cloud cover. </summary>
        public int? CloudCover { get; }
    }
}

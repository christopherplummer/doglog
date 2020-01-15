﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DogLog.API.Providers.Weather.Weatherbit.Models
{
    public class DailyForecast
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }
    }

    public class Datum
    {
        [JsonProperty("moonrise_ts")]
        public long? MoonriseTs { get; set; }

        [JsonProperty("wind_cdir")]
        public string WindCdir { get; set; }

        [JsonProperty("rh")]
        public long? Rh { get; set; }

        [JsonProperty("pres")]
        public double? Pres { get; set; }

        [JsonProperty("high_temp")]
        public double? HighTemp { get; set; }

        [JsonProperty("sunset_ts")]
        public long? SunsetTs { get; set; }

        [JsonProperty("ozone")]
        public double? Ozone { get; set; }

        [JsonProperty("moon_phase")]
        public double? MoonPhase { get; set; }

        [JsonProperty("wind_gust_spd")]
        public double? WindGustSpd { get; set; }

        [JsonProperty("snow_depth")]
        public long? SnowDepth { get; set; }

        [JsonProperty("clouds")]
        public long? Clouds { get; set; }

        [JsonProperty("ts")]
        public long? Ts { get; set; }

        [JsonProperty("sunrise_ts")]
        public long? SunriseTs { get; set; }

        [JsonProperty("app_min_temp")]
        public double? AppMinTemp { get; set; }

        [JsonProperty("wind_spd")]
        public double? WindSpd { get; set; }

        [JsonProperty("pop")]
        public long? Pop { get; set; }

        [JsonProperty("wind_cdir_full")]
        public string WindCdirFull { get; set; }

        [JsonProperty("slp")]
        public double? Slp { get; set; }

        [JsonProperty("valid_date")]
        public DateTimeOffset? ValidDate { get; set; }

        [JsonProperty("app_max_temp")]
        public double? AppMaxTemp { get; set; }

        [JsonProperty("vis")]
        public double? Vis { get; set; }

        [JsonProperty("dewpt")]
        public double? Dewpt { get; set; }

        [JsonProperty("snow")]
        public long? Snow { get; set; }

        [JsonProperty("uv")]
        public double? Uv { get; set; }

        [JsonProperty("weather")]
        public Weather Weather { get; set; }

        [JsonProperty("wind_dir")]
        public long? WindDir { get; set; }

        [JsonProperty("max_dhi")]
        public object MaxDhi { get; set; }

        [JsonProperty("clouds_hi")]
        public long? CloudsHi { get; set; }

        [JsonProperty("precip")]
        public double? Precip { get; set; }

        [JsonProperty("low_temp")]
        public double? LowTemp { get; set; }

        [JsonProperty("max_temp")]
        public double? MaxTemp { get; set; }

        [JsonProperty("moonset_ts")]
        public long? MoonsetTs { get; set; }

        [JsonProperty("datetime")]
        public DateTimeOffset? Datetime { get; set; }

        [JsonProperty("temp")]
        public double? Temp { get; set; }

        [JsonProperty("min_temp")]
        public double? MinTemp { get; set; }

        [JsonProperty("clouds_mid")]
        public long? CloudsMid { get; set; }

        [JsonProperty("clouds_low")]
        public long? CloudsLow { get; set; }
    }

    public class Weather
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("code")]
        public long? Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

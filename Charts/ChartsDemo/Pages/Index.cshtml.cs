﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartsDemo.Models;
using ChartsDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ChartsDemo.Pages
{
    public class IndexModel : PageModel
    {
        public JsonFileWeatherService WeatherService;
        public List<Weatherforecast> WeatherforecastList { get; private set; }
        public IndexModel(JsonFileWeatherService weatherService)
        {
            WeatherService = weatherService;
        }

        public void OnGet()
        {
            WeatherforecastList = WeatherService.GetWeatherforecasts().ToList<Weatherforecast>();
        }

        public JsonResult OnGetWeatherforecastChartData()
        {
            WeatherforecastList = WeatherService.GetWeatherforecasts().ToList<Weatherforecast>();
            var weatherChart = new CategoryChart();
            weatherChart.AmountList = new List<double>();
            weatherChart.CategoryList = new List<string>();

            foreach (var weather in WeatherforecastList)
            {
                weatherChart.AmountList.Add(weather.TemperatureC);
                weatherChart.CategoryList.Add(weather.Day);
            }

            return new JsonResult(weatherChart);
        }

        public JsonResult OnGetWeatherforecastTempFData()
        {
            WeatherforecastList = WeatherService.GetWeatherforecasts().ToList<Weatherforecast>();
            var weatherChart = new CategoryChart();
            weatherChart.DateList = new List<DateTime>();
            weatherChart.TempFList = new List<Double>();

            foreach (var weather in WeatherforecastList)
            {
                weatherChart.DateList.Add(weather.Date);
                weatherChart.TempFList.Add(weather.TemperatureF);
            }

            return new JsonResult(weatherChart);
        }

    }
}

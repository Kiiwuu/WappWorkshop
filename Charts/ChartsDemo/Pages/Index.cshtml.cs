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
        private readonly ILogger<IndexModel> _logger;
        public JsonFileWeatherService WeatherService;
        public List<Weatherforecast> WeatherforecastList { get; private set; }
        public IndexModel(ILogger<IndexModel> logger, JsonFileWeatherService weatherService)
        {
            _logger = logger;
            WeatherService = weatherService;
        }

        public void OnGet()
        {
            WeatherforecastList = WeatherService.GetWeatherforecasts().ToList<Weatherforecast>();
        }

        public JsonResult OnGetWeatherforecastChartData()
        {
            WeatherforecastList = WeatherService.GetWeatherforecasts().ToList<Weatherforecast>();
            Console.WriteLine($"LIJST: {WeatherforecastList}");
            var weatherChart = new CategoryChartModel();
            weatherChart.AmountList = new List<double>();
            weatherChart.CategoryList = new List<string>();

            foreach (var weather in WeatherforecastList)
            {
                weatherChart.AmountList.Add(weather.TemperatureC);
                weatherChart.CategoryList.Add(weather.Day);
            }

            return new JsonResult(weatherChart);
        }

    }
}

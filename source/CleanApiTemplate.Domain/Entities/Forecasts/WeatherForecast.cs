﻿using System;
using CleanApiTemplate.Domain.Common;
using CleanApiTemplate.Domain.Entities.Locations;

namespace CleanApiTemplate.Domain.Entities.Forecasts
{
    public class WeatherForecast : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public int Temperature { get; set; }
        public string Wind { get; set; }
        public string Clouds { get; set; }
        public DateTime TakeInDate { get; set; }
        public string Summary { get; set; }

        public Location Location { get; set; }
        public Guid LocationId { get; set; }
    }
}

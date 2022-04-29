﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinGreatCircle.Model;

namespace XamarinGreatCircle.ViewModels
{
    public class DistanceThroughEarthViewModel
    {
        public ObservableCollection<LocationInfo> LocationInformation { get; set; }

        public DistanceThroughEarthViewModel()
        {
            LocationInformation = new ObservableCollection<LocationInfo>()
            {
                new LocationInfo() { Id = 1, Name = "Eustis, Florida", Latitude = 28.881541, Longitude = -81.703742},
                new LocationInfo() { Id = 2, Name = "Los Angeles", Latitude = 34.05349, Longitude = -118.24532},
                new LocationInfo() { Id = 3, Name = "Miami", Latitude = 25.775084, Longitude = -80.1947},
                new LocationInfo() { Id = 4, Name = "New York City", Latitude = 40.71455, Longitude = -74.00712},
                new LocationInfo() { Id = 5, Name = "London England", Latitude = 51.500153, Longitude = -0.1262362},
                new LocationInfo() { Id = 6, Name = "Frankfurt Germany", Latitude = 50.11208, Longitude = 8.68341},
                new LocationInfo() { Id = 7, Name = "Chicago", Latitude = 41.88425, Longitude = -87.63245},
                new LocationInfo() { Id = 8, Name = "Singapore", Latitude = 1.29016, Longitude = 103.852},
                new LocationInfo() { Id = 9, Name = "Brazil", Latitude = -10.8104515, Longitude = -52.973118},
                new LocationInfo() { Id = 10, Name = "Galápagos Islands", Latitude = -0.43609226, Longitude = -90.59137},
                new LocationInfo() { Id = 11, Name = "Hilo Hawaii", Latitude = 19.724876, Longitude = 155.08868},
                new LocationInfo() { Id = 12, Name = "Dubai", Latitude = 25.20498, Longitude = 55.271057},
                new LocationInfo() { Id = 13, Name = "Juneau Alaska", Latitude = 58.300323, Longitude = -134.41763},
                new LocationInfo() { Id = 14, Name = "Bolivar Ohio", Latitude = 40.65014, Longitude = -81.45259}
            };
        }
    }
}

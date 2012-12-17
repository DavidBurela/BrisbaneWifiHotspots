using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrisbaneWifiHotspots.WinRT.Models;

namespace BrisbaneWifiHotspots.WinRT.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<LocationData> Locations { get; set; }

        public MainViewModel()
        {
            Locations = new ObservableCollection<LocationData>();

            PopulateLocationData();
        }

        private void PopulateLocationData()
        {
            Locations.Add(new LocationData{LocationName = "Test 1", Address = "1234 lala"});
        }
    }
}

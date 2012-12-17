using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BrisbaneWifiHotspots.WinRT.Helpers;
using BrisbaneWifiHotspots.WinRT.Models;

namespace BrisbaneWifiHotspots.WinRT.ViewModels
{
    public class MainViewModel
    {
        public SortedObservableCollection<LocationData> Locations { get; set; }

        public MainViewModel()
        {
            Locations = new SortedObservableCollection<LocationData>();

            PopulateLocationData();
        }

        private void PopulateLocationData()
        {
            Locations.Add(new LocationData { LocationName = "Annerley Library Wifi", Address = "450 Ipswich Road", Latitude = -27.50942285, Longitude = 153.0333218 });
            Locations.Add(new LocationData { LocationName = "Ashgrove Library Wifi", Address = "87 Amarina Avenue", Latitude = -27.44394629, Longitude = 152.9870981 });
            Locations.Add(new LocationData { LocationName = "Banyo Library Wifi", Address = "284 St. Vincents Road", Latitude = -27.37396641, Longitude = 153.0783234 });
            Locations.Add(new LocationData { LocationName = "Bracken Ridge Library Wifi", Address = "Corner Bracken and Barrett Street", Latitude = -27.31797261, Longitude = 153.0378735 });
            Locations.Add(new LocationData { LocationName = "Brisbane Square Library Wifi", Address = "Brisbane Square, 266 George Street", Latitude = -27.47091173, Longitude = 153.0224598 });
            Locations.Add(new LocationData { LocationName = "Bulimba Library Wifi", Address = "Corner Riding Road & Oxford Street", Latitude = -27.45203086, Longitude = 153.0628242 });
            Locations.Add(new LocationData { LocationName = "Carina Library Wifi", Address = "Corner Mayfield Road & Nyrang Street", Latitude = -27.49169314, Longitude = 153.0912127 });
            Locations.Add(new LocationData { LocationName = "Carindale Library Wifi", Address = "The Home and Leisure Centre, Corner Carindale Street  & Banchory Court, Westfield Carindale Shopping Centre", Latitude = -27.50475928, Longitude = 153.1003965 });
            Locations.Add(new LocationData { LocationName = "Chermside Library Wifi", Address = "375 Hamilton  Road", Latitude = -27.3856032, Longitude = 153.0349028 });
            Locations.Add(new LocationData { LocationName = "Coopers Plains Library Wifi", Address = "107 Orange Grove Road", Latitude = -27.56510509, Longitude = 153.0403183 });
            Locations.Add(new LocationData { LocationName = "Corinda Library Wifi", Address = "641 Oxley Road", Latitude = -27.53880237, Longitude = 152.9809091 });
            Locations.Add(new LocationData { LocationName = "Everton Park Library Wifi", Address = "561 South Pine Road", Latitude = -27.4053336, Longitude = 152.9904205 });
            Locations.Add(new LocationData { LocationName = "Fairfield Library Wifi", Address = "Fairfield Gardens Shopping Centre, 180 Fairfield Road", Latitude = -27.50909038, Longitude = 153.0259709 });
            Locations.Add(new LocationData { LocationName = "Garden City Library Wifi", Address = "Garden City Shopping Centre, Corner Logan and Kessels Road", Latitude = -27.56244221, Longitude = 153.0809183 });
            Locations.Add(new LocationData { LocationName = "Grange Library Wifi", Address = "79 Evelyn Street", Latitude = -27.42531193, Longitude = 153.0174728 });
            Locations.Add(new LocationData { LocationName = "Hamilton Library Wifi", Address = "Corner Racecourt Road and Rossiter Parade", Latitude = -27.43790137, Longitude = 153.0642227 });
            Locations.Add(new LocationData { LocationName = "Holland Park Library Wifi", Address = "81 Seville Road", Latitude = -27.52292286, Longitude = 153.0722921 });
            Locations.Add(new LocationData { LocationName = "Inala Library Wifi", Address = "Inala Shopping centre, Corsair Ave", Latitude = -27.59828574, Longitude = 152.9735217 });
            Locations.Add(new LocationData { LocationName = "Indooroopilly Library Wifi", Address = "Indrooroopilly Shopping centre, Level 4, 322 Moggill Road", Latitude = -27.49764287, Longitude = 152.9736471 });
            Locations.Add(new LocationData { LocationName = "Kenmore Library Wifi", Address = "Kenmore Village Shopping Centre, Brookfield Road", Latitude = -27.50592852, Longitude = 152.9386437 });
            Locations.Add(new LocationData { LocationName = "Mitchelton Library Wifi", Address = "37 Helipolis Parada", Latitude = -27.41704165, Longitude = 152.9783402 });
            Locations.Add(new LocationData { LocationName = "Mt Coot-tha Botanic Gardens Library Wifi", Address = "Administration Building, Brisbane Botanic Gardens (Mt Coot-tha), Mt Coot-tha Road", Latitude = -27.47529908, Longitude = 152.9760412 });
            Locations.Add(new LocationData { LocationName = "Mt Gravatt Library Wifi", Address = "8 Creek Road", Latitude = -27.53855482, Longitude = 153.0802628 });
            Locations.Add(new LocationData { LocationName = "Mt Ommaney Library Wifi", Address = "Mt Ommaney Shopping Centre, 171 Dandenong Road", Latitude = -27.54824198, Longitude = 152.9378099 });
            Locations.Add(new LocationData { LocationName = "New Farm Library Wifi", Address = "135 Sydney Street", Latitude = -27.46736574, Longitude = 153.0495841 });
            Locations.Add(new LocationData { LocationName = "Nundah Library Wifi", Address = "1 Bage Street", Latitude = -27.40125908, Longitude = 153.0583751 });
            Locations.Add(new LocationData { LocationName = "Sandgate Library Wifi", Address = "Seymour Street", Latitude = -27.32060523, Longitude = 153.0704927 });
            Locations.Add(new LocationData { LocationName = "Stones Corner Library Wifi", Address = "280 Logan Road", Latitude = -27.49803575, Longitude = 153.043655 });
            Locations.Add(new LocationData { LocationName = "Sunnybank Hills Library Wifi", Address = "Sunnybank Hills Shopping Centre, Corner Compton and Calam Roads", Latitude = -27.6109253, Longitude = 153.0550706 });
            Locations.Add(new LocationData { LocationName = "Toowong Library Wifi", Address = "Toowon Village Shopping Centre, Sherwood Road", Latitude = -27.48505116, Longitude = 152.9925091 });
            Locations.Add(new LocationData { LocationName = "West End Library Wifi", Address = "178 - 180 Boundary Street", Latitude = -27.48245078, Longitude = 153.0120763 });
            Locations.Add(new LocationData { LocationName = "Wynnum Library Wifi", Address = "Wynnum Civic Centre, 66 Bay Terrace", Latitude = -27.44244894, Longitude = 153.1731968 });
            Locations.Add(new LocationData { LocationName = "Zillmere Library Wifi", Address = "Corner Jennings Street and Zillmere Road", Latitude = -27.36014232, Longitude = 153.0407898 });
            Locations.Add(new LocationData { LocationName = "New Farm Park Wifi", Address = "Brunswick Street", Latitude = -27.47046, Longitude = 153.05223 });
            Locations.Add(new LocationData { LocationName = "City Botanic Gardens Wifi", Address = "Alice Street", Latitude = -27.47561, Longitude = 153.03005 });
        }
    }
}

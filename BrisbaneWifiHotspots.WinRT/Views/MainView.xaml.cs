using System.Linq;
using Bing.Maps;
using BrisbaneWifiHotspots.WinRT.Models;
using Windows.UI.Xaml.Controls;

namespace BrisbaneWifiHotspots.WinRT.Views
{
    public sealed partial class MainView
    {
        public MainView()
        {
            this.InitializeComponent();

            var sydneyLocation = new Location(-27.4610936817092, 153.07195080023348);
            map.ZoomLevel = 12;
            map.Center = sydneyLocation;
            map.SetView(sydneyLocation);    // Workaround: There is an issue with the map. Images won't display until you move the map.

            map.RightTapped += MapRightTapped;  // for debugging
        }

        private void LocationsListOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Any())
            {
                var clickedBeach = e.AddedItems[0] as LocationData;
                if (clickedBeach != null)
                {
                    map.SetView(new Location(clickedBeach.Latitude, clickedBeach.Longitude), 15);
                }
            }
        }

        void MapRightTapped(object sender, Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e)
        {
            // development helper, allows me to grab coordinates.
            var coordinates = map.Center;
            e.Handled = false; // still allow the app bar to come up.
        }
    }
}

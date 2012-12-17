using System.Linq;
using Bing.Maps;
using BrisbaneWifiHotspots.WinRT.Models;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BrisbaneWifiHotspots.WinRT.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainView : Page
    {
        public MainView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
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
    }
}

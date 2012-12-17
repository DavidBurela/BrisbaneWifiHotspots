using System;
using System.ComponentModel;
using System.Linq;

namespace BrisbaneWifiHotspots.WinRT.Models
{
    public class LocationData : INotifyPropertyChanged, IComparable
    {
        private double _latitude;
        public double Latitude
        {
            get { return _latitude; }
            set
            {
                _latitude = value;
                NotifyPropertyChanged("Latitude");
            }
        }

        private double _longitude;
        public double Longitude
        {
            get { return _longitude; }
            set
            {
                _longitude = value;
                NotifyPropertyChanged("Longitude");
            }
        }

        private string _locationName;
        public string LocationName
        {
            get { return _locationName; }
            set
            {
                _locationName = value;
                NotifyPropertyChanged("LocationName");
            }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                NotifyPropertyChanged("Address");
            }
        }

        public int CompareTo(object obj)
        {
            var locationData = obj as LocationData;
            return string.CompareOrdinal(LocationName, locationData.LocationName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (null != PropertyChanged)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

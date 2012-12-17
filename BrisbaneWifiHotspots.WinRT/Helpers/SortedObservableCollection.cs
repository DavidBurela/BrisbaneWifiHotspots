// Code from http://www.xamlplayground.org/post/2010/04/27/Keeping-an-ObservableCollection-sorted-with-a-method-override.aspx

using System;
using System.Collections.ObjectModel;

namespace BrisbaneWifiHotspots.WinRT.Helpers
{
    public class SortedObservableCollection<T> : ObservableCollection<T>
       where T : IComparable
    {
        protected override void InsertItem(int index, T item)
        {
            for (int i = 0; i < Count; i++)
            {
                switch (Math.Sign(this[i].CompareTo(item)))
                {
                    case 0:
                        throw new InvalidOperationException("Cannot insert duplicated items");
                    case 1:
                        base.InsertItem(i, item);
                        return;
                    case -1:
                        break;
                }
            }

            base.InsertItem(Count, item);
        }
    }
}

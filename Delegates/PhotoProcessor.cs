using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class PhotoProcessor
    {
        public delegate void FilterDelegate(Photo photo);
        public static void ApplyFilter(Photo photo, Action<Photo> someFilter)
        {
            someFilter(photo);
        }

        public static void ApplyFilter2(Photo photo, FilterDelegate filterDelegate)
        {
            filterDelegate(photo);
        }
    }
}

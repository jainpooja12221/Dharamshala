using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Dharamshala.Model
{

    public class Cities
    {
        public City[] CityList { get; set; }
    }

    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
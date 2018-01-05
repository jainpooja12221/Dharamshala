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
    internal class Constants
    {
        public const string SAVE_PROFILE_URL = "http://DharamshalaServices.akritrim.com/DharamshalaServices.svc/SaveProfile/";
        public const string GET_CITIES_URL = "http://DharamshalaServices.akritrim.com/DharamshalaServices.svc/GetCities";
    }
}
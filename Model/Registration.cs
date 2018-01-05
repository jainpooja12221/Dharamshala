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
    class Registration
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public long Phone { get; set; }
    }
}
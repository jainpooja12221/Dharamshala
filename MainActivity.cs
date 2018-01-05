using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Net;
using System.IO;
using Utility;
using Dharamshala.Model;
using Newtonsoft.Json;

namespace Dharamshala
{
    [Activity(Label = "Dharamshala", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private static EditText nameEditText;
        private static EditText emailEditText;
        private static EditText phoneEditText;
        private static EditText cityEditText;


        public Android.Widget.Button submitButton { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource  
            //Pooja: SetContent.. is bydefault
            SetContentView(Resource.Layout.Main);

            nameEditText = FindViewById<EditText>(Resource.Id.nameEditText);
            emailEditText = FindViewById<EditText>(Resource.Id.emailEditText);
            phoneEditText = FindViewById<EditText>(Resource.Id.phoneEditText);
            cityEditText = FindViewById<EditText>(Resource.Id.cityEditText);

            submitButton = FindViewById<Android.Widget.Button>(Resource.Id.submitBtn);
            submitButton.Click += SubmitButton_Click;

        }

        private async void SubmitButton_Click(object sender, System.EventArgs e)
        {
            Registration registration = new Registration();
            registration.Name = nameEditText.Text;
            registration.Email = emailEditText.Text;
            registration.Phone = Convert.ToInt64(phoneEditText.Text);

            registration.City = cityEditText.Text;

            try
            {
                //var transactionRequest = string.Format(nameEditText.Text, emailEditText.Text, phoneEditText.Text, cityEditText.Text);

                var tokenJSONResponse = await ServiceHandler.Call(Constants.GET_CITIES_URL,"GET",null);
                var transResponse = JsonConvert.DeserializeObject<City[]>(tokenJSONResponse);
                // Deserilize the token response in object format
                // var response = JsonConvert.DeserializeObject<TokenResponse[]>(tokenJSONResponse);

                // Get transaction details by calling webservive and passing the token
                // string transactionResponse = await ServiceHandler.Call(transactionRequest);
            }

            catch (Exception ex)
            {
                
            }
        }


    }
}


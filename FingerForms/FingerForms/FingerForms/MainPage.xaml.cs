using Plugin.Fingerprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FingerForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var result = await CrossFingerprint.Current.AuthenticateAsync("Prove you have fingers!");
                //if (result.Authenticated)
                //{
                //    await Application.Current.MainPage.DisplayAlert("Message", "Success", "Ok");
                //}
                //else
                //{
                //    await Application.Current.MainPage.DisplayAlert("Message", "Incorrect", "Ok");
                //}
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Message",ex.Message,"Ok");
            }
        }
    }
}

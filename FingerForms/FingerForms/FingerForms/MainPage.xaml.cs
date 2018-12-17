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

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                bool statics = DependencyService.Get<IFingerService>().Auth();

                //if (statics)
                //{
                //    Application.Current.MainPage.DisplayAlert("ok", "true", "Ok");
                //}
                //else
                //{
                //    Application.Current.MainPage.DisplayAlert("ok", "false", "Ok");
                //}
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("ok",ex.Message,"Ok");
            }
        }
    }
}

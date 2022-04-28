using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolarSystem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Planets : ContentPage
    {
        public Planets()
        {
            InitializeComponent();
        }

        private void Mercury_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MercuryPage());
        }

        private void Venus_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VenusPage());
        }

        private void Earth_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EarthPage());
        }

        private void Mars_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MarsPage());
        }

        private void Jupiter_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JupiterPage());
        }

        private void Saturn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SaturnPage());
        }

        private void Uranus_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UranusPage());
        }

        private void Neptune_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NeptunPage());
        }
    }
}
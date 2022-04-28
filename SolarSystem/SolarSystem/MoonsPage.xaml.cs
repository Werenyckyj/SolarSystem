using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using System.Diagnostics;
using Rg.Plugins.Popup.Contracts;
using Xamarin.Forms.Xaml;

namespace SolarSystem
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class Moon
    {
        public string Name { get; set; }
        public string MotherPlanet { get; set; }
    }
    public partial class MoonsPage : ContentPage
    {
        public static ObservableCollection<Moon> MoonsList { get; set; }
        public MoonsPage()
        {
            InitializeComponent();
            MoonsList = new ObservableCollection<Moon>(
                new Moon[]
                {
                    new Moon {Name="Moon", MotherPlanet="Earth"},
                    new Moon {Name="Phobos", MotherPlanet="Mars"},
                    new Moon {Name="Deimos", MotherPlanet="Mars"},
                }
                );
            MoonsListView.ItemsSource = MoonsList;
        }


        private void MoonsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert((MoonsListView.SelectedItem as Moon).Name, "Mother planet: " + (MoonsListView.SelectedItem as Moon).MotherPlanet, "OK");
        }

        private async void AddMoon_Clicked(object sender, EventArgs e)
        {
            MoonPopup mp = new MoonPopup();
            await PopupNavigation.Instance.PushAsync(mp, animate:true);
        }

        private void DeleteMoon_Clicked(object sender, EventArgs e)
        {
            ImageButton butt = sender as ImageButton;
            MoonsList.Remove(butt.CommandParameter as Moon);
        }
    }
}
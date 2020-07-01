using ProbeTeam.Application.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProbeTeamApp.Views.Scout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListScouts(App.Service.GetAllScouts());


        }

        public void ListScouts(IEnumerable<ScoutViewModel> scouts)
        {
            FlexLayoutScouts.Children.Clear();

            foreach(var scout in scouts)
            {
                var scoutStackLayout = new StackLayout();
                scoutStackLayout.WidthRequest = 300;
                scoutStackLayout.HeightRequest = 400;

                var labelTypeOfScout = new Label();
                labelTypeOfScout.HorizontalOptions = LayoutOptions.CenterAndExpand;
                labelTypeOfScout.VerticalOptions = LayoutOptions.Start;
                labelTypeOfScout.Text = scout.TypeOfScout;

                scoutStackLayout.Children.Add(labelTypeOfScout);

                var labelLocality = new Label();
                labelLocality.HorizontalOptions = LayoutOptions.CenterAndExpand;
                labelLocality.VerticalOptions = LayoutOptions.Start;
                labelLocality.Text = scout.Locality;

                scoutStackLayout.Children.Add(labelTypeOfScout);

                var labelQuantityInField = new Label();
                labelQuantityInField.HorizontalOptions = LayoutOptions.CenterAndExpand;
                labelQuantityInField.VerticalOptions = LayoutOptions.Start;
                labelQuantityInField.Text = scout.QuantityInField.ToString();

                scoutStackLayout.Children.Add(labelTypeOfScout);

                var labelScoutRegistrationDate = new Label();
                labelScoutRegistrationDate.HorizontalOptions = LayoutOptions.CenterAndExpand;
                labelScoutRegistrationDate.VerticalOptions = LayoutOptions.Start;
                labelScoutRegistrationDate.Text = scout.ScoutRegistrationDate.ToString();

                scoutStackLayout.Children.Add(labelTypeOfScout);

                FlexLayoutScouts.Children.Add(scoutStackLayout);
            }
        }

        //private async Task EditScoutAsync(ScoutViewModel scout)
        //{
        //    await Navigation.PushModalAsync(new EditScoutPage(scout), true);
        //}

        private void BtAddScout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddScoutPage(), true);
        }
    }
}
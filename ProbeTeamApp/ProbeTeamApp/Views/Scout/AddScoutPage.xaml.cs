using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class AddScoutPage : ContentPage
    {
        public AddScoutPage()
        {
            InitializeComponent();
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            var typeOfScout = EntryTypeOfScout.Text;
            var locality = EntryLocality.Text;
            var quantityInField = EntryQuantityInField.Text;

            DateTime scoutRegistrationDate = DateTime.ParseExact(EntryScoutRegistrationDate.Text, "dd/MM/yyyy", null);
            

            var scout = new ScoutViewModel
            {
                TypeOfScout = typeOfScout,
                Locality = locality,
                QuantityInField = Convert.ToInt32(quantityInField),
                ScoutRegistrationDate = scoutRegistrationDate
            };

            App.Service.AddScout(scout);
            Navigation.PopModalAsync(true);
        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}
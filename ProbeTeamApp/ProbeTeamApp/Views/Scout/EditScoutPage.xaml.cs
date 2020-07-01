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
    public partial class EditScoutPage : ContentPage
    {
        private ScoutViewModel scout;
        public EditScoutPage(ScoutViewModel scout)
        {
            InitializeComponent();
            this.scout = scout;
            FillFields(scout);
        }

        private void FillFields(ScoutViewModel scout)
        {
            EntryTypeOfScout.Text = scout.TypeOfScout;
            EntryLocality.Text = scout.Locality;
            EntryQuantityInField.Text = scout.QuantityInField.ToString();
            EntryScoutRegistrationDate.Text = scout.ScoutRegistrationDate.ToString();
        }

        private void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            var typeOfScout = EntryTypeOfScout.Text;
            var locality = EntryLocality.Text;
            var quantityInField = EntryQuantityInField.Text;
            var scoutRegistrationDate = EntryScoutRegistrationDate.Text;

            scout.TypeOfScout = typeOfScout;
            scout.Locality = locality;
            scout.QuantityInField = Convert.ToInt32(quantityInField);
            scout.ScoutRegistrationDate = Convert.ToDateTime(scoutRegistrationDate);

            App.Service.UpdateScout(scout);
            Navigation.PopModalAsync(true);
        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}
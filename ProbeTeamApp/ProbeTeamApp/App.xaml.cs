using ProbeTeam.Application.Services;
using ProbeTeam.Domain.Services;
using ProbeTeam.Infra.DataAccess.Repositories.Scouts;
using ProbeTeamApp.Views.Scout;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProbeTeamApp
{
    public partial class App : Application
    {
        public static ScoutAppService Service { get; set; }

        public App()
        {
            InitializeComponent();
            var domainService = new ScoutService(new SQLiteScoutsRepository(Device.RuntimePlatform));
            Service = new ScoutAppService(domainService);
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

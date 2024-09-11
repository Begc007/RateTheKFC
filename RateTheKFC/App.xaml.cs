using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RateTheKFC.Data;
using RateTheKFC.Services;
using RateTheKFC.ViewModels;
using RateTheKFC.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace RateTheKFC {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        public static IHost? AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) => {
                services.AddSingleton<AppDbContext>();
                services.AddSingleton<CompanyService>();
                services.AddSingleton<MainWindowVM>();
                services.AddSingleton<MainWindow>();
            }).Build();


        }

        protected override async void OnStartup(StartupEventArgs e) {
            await AppHost!.StartAsync();
            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm.Show();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e) {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }
    }

}

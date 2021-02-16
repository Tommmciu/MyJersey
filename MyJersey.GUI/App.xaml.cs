using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyJersey.Database;
using MyJersey.GUI.Pages;
using MyJersey.Service.Implementation;
using MyJersey.Service.Interfaces;

namespace MyJersey.GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<MyJerseyDbContext>(options =>
                options.UseSqlServer(ConfigurationManager.ConnectionStrings["MyJerseyDb"].ConnectionString));
            services.AddSingleton<IJerseyService,JerseyService>();

            services.AddSingleton<MainWindow>();
            services.AddSingleton<JerseyListPage>();
            services.AddSingleton<TeamList>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}

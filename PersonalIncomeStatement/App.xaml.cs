using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersonalIncomeStatement.Database;
using PersonalIncomeStatement.Repositories;
using PersonalIncomeStatement.Services;
using PersonalIncomeStatement.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalIncomeStatement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost _host;
        public App()
        {
           
        }

        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            _host = new HostBuilder().
                  ConfigureAppConfiguration((context, configurationBuilder) =>
                  {
                      configurationBuilder.SetBasePath(context.HostingEnvironment.ContentRootPath);
                      configurationBuilder.AddJsonFile("appsettings.json", optional: false);
                  })
                  .ConfigureServices((context, services) =>
                  {
                      services.AddScoped<IRepositoryManager, RepositoryManager>();
                      services.AddScoped<MainWindowViewModel, MainWindowViewModel>();
                      services.AddScoped<IIncomeService, IncomeService>();
                      services.AddSingleton<MainWindow>();
                      services.AddDbContext<DatabaseContext>(options =>
                   options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
                  }).Build();

            using (var serviceScope = _host.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DatabaseContext>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                //context.Database.Migrate();
            }

            await _host.StartAsync();
            var mainWindow = _host.Services.GetService<MainWindow>();
           
            mainWindow.Show();
        }
    }
}

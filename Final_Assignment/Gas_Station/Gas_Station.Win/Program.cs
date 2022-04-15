using Gas_Station.EF.Context;
using Gas_Station.EF.Repos;
using Handlers;
using Microsoft.Extensions.DependencyInjection;
using Model;

namespace Gas_Station.Win
{
    internal static class Program
    {
        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
          
            var myHandler = new TransactionHandler();

            //AddScopeRepos(services);

            //using var serviceProvider = services.BuildServiceProvider();
            //var mainForm = serviceProvider.GetRequiredService<HomeF>();
            Application.Run(new HomeF(myHandler));
        }
    }
}
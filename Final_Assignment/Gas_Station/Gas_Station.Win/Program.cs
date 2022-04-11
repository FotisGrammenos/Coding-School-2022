using Gas_Station.EF.Repos;
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

             var services = new ServiceCollection();

            //AddScopeRepos(services);

            //using var serviceProvider = services.BuildServiceProvider();
            //var mainForm = serviceProvider.GetRequiredService<HomeF>();
            Application.Run(new HomeF());
        }

        private static void AddScopeRepos(IServiceCollection service)
        {

            // Actual Service
            //services.AddSingleton<IEntityRepo<Todo>, TodoRepo>()
            //    .AddSingleton<IEntityRepo<TodoComment>, TodoCommentRepo>()
            //    .AddSingleton<Main>();


            service.AddScoped<IEntityRepo<Customer>, CustomerRepo>();
        }
    }
}
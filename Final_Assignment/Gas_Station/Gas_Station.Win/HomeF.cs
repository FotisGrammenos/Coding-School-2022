
using Gas_Station.EF.Repos;
using Microsoft.Extensions.DependencyInjection;
using Model;

namespace Gas_Station.Win
{
    public partial class HomeF : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;

        private HttpClient _httpClient;
        public HomeF()
        {
            InitializeComponent();
            
            var services = new ServiceCollection();

            AddScopeRepos(services);

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7097/");


        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCustomerList = new CustomerListF( _httpClient);
            frmCustomerList.ShowDialog();
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
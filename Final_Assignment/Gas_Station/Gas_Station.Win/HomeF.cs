
using Gas_Station.EF.Repos;
using Gas_Station.Win.CustomerForms;
using Gas_Station.Win.ItemForms;
using Gas_Station.Win.TransactionFomrs;
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

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7097/");
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCustomerList = new CustomersListF( _httpClient);
            frmCustomerList.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCustomerList = new ItemListF(_httpClient);
            frmCustomerList.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCustomerList = new TransactionList(_httpClient);
            frmCustomerList.ShowDialog();
        }
    }
}
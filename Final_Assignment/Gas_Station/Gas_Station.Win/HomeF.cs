
using Gas_Station.EF.Repos;
using Gas_Station.Shared;
using Gas_Station.Win.CustomerForms;
using Gas_Station.Win.ItemForms;
using Gas_Station.Win.TransactionFomrs;
using Handlers;
using Microsoft.Extensions.DependencyInjection;
using Model;

namespace Gas_Station.Win
{
    public partial class HomeF : Form
    {
       
        private HttpClient _httpClient;
        private TransactionHandler _handler;
        private UserViewModel _user; 
        
        public HomeF(TransactionHandler handler)
        {
            InitializeComponent();
            
            var services = new ServiceCollection();
            
            _handler= handler;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7097/");

            LogIn();
            
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
            var frmCustomerList = new TransactionList(_httpClient,_handler);
            frmCustomerList.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void LogIn()
        {
            ResetButtons();
            this.Visible = false;
            _user = new();

            var Loginform = new LoginForm(_httpClient);
            Loginform.ShowDialog();
            _user = Loginform._user;

            if(Loginform._user == null)
            {
                this.Close();
                return;
            }
                
            this.Visible = true;
            SetRole();

        }

        private void SetRole()
        {
            if (_user.Role == Enums.EmployeeType.Cashier)
            {
                itemsToolStripMenuItem.Visible = false;
            }
            else if(_user.Role == Enums.EmployeeType.Staff)
            {
                customersToolStripMenuItem.Visible = false;
                transactionsToolStripMenuItem.Visible=false;
            }
        }

        private void ResetButtons()
        {
            itemsToolStripMenuItem.Visible = true;
            customersToolStripMenuItem.Visible = true;
            transactionsToolStripMenuItem.Visible = true;
        }
    }
}
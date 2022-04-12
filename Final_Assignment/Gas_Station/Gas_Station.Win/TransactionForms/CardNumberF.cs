using Gas_Station.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gas_Station.Win.TransactionForms
{
    public partial class CardNumberF : Form
    {
        
        private string _cardNumber;
        private HttpClient _client;

        public CardNumberF(HttpClient client)
        {
            InitializeComponent();
            _client = client;
        }

        private async void bntContiue_Click(object sender, EventArgs e)
        {
            _cardNumber = txtName.Text;

            if (! IsValid(_cardNumber)) 
            {
                MessageBox.Show("Invalid CardNumber", "Error",MessageBoxButtons.OKCancel);
                return;
            }

            this.Close();

            var customers = await _client.GetFromJsonAsync<List<CustomerListViewModel>>("customer");
            var existingCustomer = customers.SingleOrDefault(c => c.CardNumber.Equals(_cardNumber));
            if (existingCustomer is null)
            {
                var newCustomer = new CustomerListViewModel()
                {
                    CardNumber = _cardNumber,
                };
                var frameNewCustomer = new CustomerForms.CustomerEditF(_client, newCustomer);
                frameNewCustomer.ShowDialog();
                OpenTransaction(newCustomer);

            }
            else
            {
                OpenTransaction(existingCustomer);
            }
        }

        private bool IsValid(string code)
        {
            if (code[0]!='A')
                return false;
            if(code.Length!=8)
                return false;
            return true;
        }

        private void OpenTransaction(CustomerListViewModel mycustomer)
        {
            var transaction = new TransactionEditViewModel()
            {
                CustomerID = mycustomer.Id,
                TotalValue = 0
            };
            var frameNewCustomer = new TransactionEditF(_client, transaction);
            frameNewCustomer.ShowDialog();
        }
    }
}

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
using static Model.Enums;

namespace Gas_Station.Win.TransactionForms
{
    public partial class TransactionEditF : Form
    {
        private HttpClient _client;
        private TransactionEditViewModel _transaction;
        private List<EmployeeListViewModel> _currEmployees;
        public TransactionEditF(HttpClient httpClient)
        {
            InitializeComponent();
            _client = httpClient;   
        }

        public TransactionEditF(HttpClient httpClient, TransactionEditViewModel transaction): this(httpClient)
        {
            _transaction = transaction;
        }

        private async void TransactionEditF_Load(object sender, EventArgs e)
        {
            if(_transaction == null)
            {
                _transaction =new TransactionEditViewModel();
            }
            bsTransaction.DataSource = _transaction;
            await LoadItemsFromServer();
            SetReadOnlyFields();


            SetDataBindings();
        }

        private void SetDataBindings()
        {
            
            txtCustomerName.DataBindings.Add(new Binding("Text", bsTransaction, "CustomerFullName", true));
            txtTotalValue.DataBindings.Add(new Binding("Text", bsTransaction, "TotalValue"));

            RefreshEmployeeList();
            ctrEmployee.DataBindings.Add(new Binding("Text", bsTransaction, "EmployeeFullName", true));

            string[] payMethod = Enum.GetNames(typeof(PayMentMethod));
            ctrPayMethod.Items.AddRange(payMethod);

            ctrPayMethod.DataBindings.Add(new Binding("Text", bsTransaction, "PayMentMethod", true));
        }

        private async Task LoadItemsFromServer()
        {
            var employees = await _client.GetFromJsonAsync<List<EmployeeListViewModel>>("employee");
            _currEmployees = employees.Where(e=> e.HireDateStart<= DateTime.Now &&
                                             e.HireDateEnd>DateTime.Now).ToList();

            var tmp = await _client.GetFromJsonAsync<CustomerListViewModel>($"customer/{_transaction.CustomerID}");
            if (tmp is null) return;
            _transaction.CustomerFullName = $"{tmp.Name} {tmp.Surname}"; 
        }

        private void SetReadOnlyFields()
        {
            txtCustomerName.ReadOnly = true;
            txtTotalValue.ReadOnly = true;
        }

        private void RefreshEmployeeList()
        {
            ctrEmployee.DataSource = null;
            ctrEmployee.DataSource = _currEmployees;
            ctrEmployee.DisplayMember = "FullName";
            ctrEmployee.ValueMember = "Id";
        }

        private async void bntRefresh_Click(object sender, EventArgs e)
        {
            await LoadItemsFromServer();
            RefreshEmployeeList();
        }
    }
}

using Gas_Station.Shared;
using Gas_Station.Win.TransactionLineForms;
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
        private TransactionLineEditViewModel _selectedTransactionLine;
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
                _transaction.TransactionLineList = new();
               // await _client.PostAsJsonAsync("transaction", _transaction);
            }
            await LoadFormServerEmployeeList();
            await LoadFromServerCustomer();

            bsTransaction.DataSource = _transaction;
            bsTransactionLine.DataSource = _transaction.TransactionLineList;
            
            SetReadOnlyFields();


            SetDataBindings();
        }

        private void SetDataBindings()
        {
            
            txtCustomerName.DataBindings.Add(new Binding("Text", bsTransaction, "CustomerFullName", true));
            txtTotalValue.DataBindings.Add(new Binding("Text", bsTransaction, "TotalValue"));


            //TODO elen3e an ta bindings einai swsta
            RefreshEmployeeList();
            ctrEmployee.DataBindings.Add(new Binding("Text", bsTransaction, "EmployeeFullName", true));

            string[] payMethod = Enum.GetNames(typeof(PayMentMethod));
            ctrPayMethod.Items.AddRange(payMethod);

            ctrPayMethod.DataBindings.Add(new Binding("Text", bsTransaction, "PayMentMethod", true));
        }

        private async Task LoadFormServerEmployeeList()
        {
            var employees = await _client.GetFromJsonAsync<List<EmployeeListViewModel>>("employee");
            _currEmployees = employees.Where(e=> e.HireDateStart<= DateTime.Now &&
                e.HireDateEnd > DateTime.Now && e.Role!=EmployeeType.Staff).ToList();
            
        }

        private async Task LoadFromServerCustomer()
        {
            var tmp = await _client.GetFromJsonAsync<CustomerListViewModel>($"customer/{_transaction.CustomerID}");
            if (tmp is null) return;
            _transaction.CustomerFullName = $"{tmp.Name} {tmp.Surname}";
        }

        private EmployeeListViewModel LoadSelectedEmployee(int selectedIndex)
        {
            return _currEmployees.ElementAt(selectedIndex);
        }

        private void SetReadOnlyFields()
        {
            txtCustomerName.ReadOnly = true;
            txtTotalValue.ReadOnly = true;
            grvTransactionLine.ReadOnly = true;
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
            await LoadFormServerEmployeeList();
            RefreshEmployeeList();
            RefreshGridViewTransactionList();
        }

        private async void bntSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(ctrEmployee.Text) ||
                string.IsNullOrWhiteSpace(ctrPayMethod.Text))
                return;
            //TODO Bgale ena minima lathous
            HttpResponseMessage response;
            _transaction.EmployeeID = LoadSelectedEmployee(ctrEmployee.SelectedIndex).Id;
            if (_transaction.ID == Guid.Empty)
            {
                _transaction.ID = Guid.NewGuid();
                _transaction.TotalValue = 1;
                response = await _client.PostAsJsonAsync("transaction", _transaction);
            }
            else
            {
                response = await _client.PutAsJsonAsync("transaction", _transaction);
            }
            response.EnsureSuccessStatusCode();
            Close();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void bntAddTL_Click(object sender, EventArgs e)
        {
            var transacationLineF = new TransactionLineF(_client, _transaction);
            transacationLineF.ShowDialog();
            await RefreshGridViewTransactionList();
        }

        private async void bntEditTL_Click(object sender, EventArgs e)
        {
            if (grvTransactionLine.SelectedRows.Count != 1)
                return;

           // var tmpTransactionLine = (TransactionLineEdViewModel)grvTransactionLine.SelectedRows[index: 0].DataBoundItem;
            //var transacationLineF = new TransactionLineF(_client, _selectedTransactionLine);
            //transacationLineF.ShowDialog();
            await RefreshGridViewTransactionList();
        }

        private async void bntDeleteTL_Click(object sender, EventArgs e)
        {
            if (grvTransactionLine.SelectedRows.Count != 1)
                return;

            var tmpTransactionLine = (TransactionLineEditViewModel)grvTransactionLine.SelectedRows[index: 0].DataBoundItem;
            await _client.DeleteAsync($"transactionLine/{tmpTransactionLine.ID}");
            await RefreshGridViewTransactionList();
        }

        private async Task RefreshGridViewTransactionList()
        {
            grvTransactionLine.DataSource = null;
            grvTransactionLine.DataSource = bsTransactionLine;
            grvTransactionLine.Update();
            grvTransactionLine.Refresh();
            grvTransactionLine.Columns["TransactionID"].Visible = false;
        }
    }
}

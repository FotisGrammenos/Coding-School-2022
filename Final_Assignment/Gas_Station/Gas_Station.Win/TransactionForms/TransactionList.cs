using Gas_Station.Shared;
using Gas_Station.Win.TransactionForms;
using Handlers;
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

namespace Gas_Station.Win.TransactionFomrs
{
    public partial class TransactionList : Form
    {
        private TransactionEditViewModel? _selectedTransaction;
        private List<TransactionListViewModel> _transactionList;
        private HttpClient _client;
        private TransactionHandler _handler;
        public TransactionList(HttpClient httpClient, TransactionHandler handler)
        {
            InitializeComponent();
            _client = httpClient;
            _handler = handler;
        }

        private async Task LoadItemsFromServer()
        {
            _transactionList =await _client.GetFromJsonAsync<List<TransactionListViewModel>>("transaction");
        }

        private async void RefreshTransactionList()
        {
            grvTransactionList.DataSource = null;

            await LoadItemsFromServer();
            grvTransactionList.DataSource = _transactionList;

            grvTransactionList.Update();
            grvTransactionList.Refresh();
            grvTransactionList.Columns["ID"].Visible = false;
            SetCollumsGridView();
        }

        private async void TransactionListF_Load(object sender, EventArgs e)
        {
            RefreshTransactionList();

            grvTransactionList.ReadOnly = true;
        }

        private async void bntRefresh_Click(object sender, EventArgs e)
        {
            RefreshTransactionList();
        }

        private async void btnAddTransaction_Click(object sender, EventArgs e)
        {
            var carNumber = new CardNumberF(_client,_handler);
            carNumber.ShowDialog();
            RefreshTransactionList();
        }

        private async void btnEditTransaction_Click(object sender, EventArgs e)
        {
            if (grvTransactionList.SelectedRows.Count != 1)
                return;

            var tmpTransaction = (TransactionListViewModel)grvTransactionList.SelectedRows[index: 0].DataBoundItem;
            _selectedTransaction =await _client.GetFromJsonAsync<TransactionEditViewModel>($"transaction/{tmpTransaction.Id}");
            var frmTransactionEdit=new TransactionEditF(_client, _selectedTransaction, _handler);
            frmTransactionEdit.ShowDialog();
            RefreshTransactionList();
        }

        private async void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (grvTransactionList.SelectedRows.Count != 1)
                return;

            var tmpTransaction = (TransactionListViewModel)grvTransactionList.SelectedRows[index: 0].DataBoundItem;
            _client.DeleteAsync($"transaction/{tmpTransaction.Id}");
            RefreshTransactionList();
        }

        private void SetCollumsGridView()
        { 
            grvTransactionList.Columns["CustomerFullName"].HeaderText = "Customer";
  
            grvTransactionList.Columns["EmployeeFullName"].HeaderText = "Employee";

            grvTransactionList.Columns["PayMentMethod"].HeaderText = "Payment-Method";
         
            grvTransactionList.Columns["TotalValue"].HeaderText = "Total Value";
             
        }

    }
}

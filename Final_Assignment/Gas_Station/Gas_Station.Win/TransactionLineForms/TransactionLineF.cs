using Gas_Station.Shared;
using Model;
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

namespace Gas_Station.Win.TransactionLineForms
{
    public partial class TransactionLineF : Form
    {
        private TransactionLineViewModels _transactionLine;
        private TransactionEditViewModel _transaction;
        private HttpClient _client;
        private List<ItemListViewModel> _items;
        public TransactionLineF(HttpClient http)
        {
            InitializeComponent();
            _client = http;
        }

        public TransactionLineF(HttpClient http,TransactionLineViewModels transactionLine) : this(http)
        {
            _transactionLine = transactionLine;
        }

        private async void TransactionLineF_Load(object sender, EventArgs e)
        {
            if (_transactionLine is null)
            {
                _transactionLine = new TransactionLineViewModels();
            }
            bsTransactionLine.DataSource = _transactionLine;
            await LoadItemFromServer();

            SetDataBindigs();
        }

        private void SetDataBindigs()
        {
            RefreshItemList();

            ctrItem.DataBindings.Add(new Binding("EditValue",bsTransactionLine, "ItemDescription",true));

            ctrQuantity.DataBindings.Add(new Binding("EditValue", bsTransactionLine, "Quentity", true));
        }

        private async Task LoadItemFromServer()
        {
            _items = await _client.GetFromJsonAsync<List<ItemListViewModel>>("item");
        }

        private void RefreshItemList()
        {
            ctrItem.DataSource = null;
            ctrItem.DataSource = _items;
            ctrItem.DisplayMember = "Description";
            ctrItem.ValueMember = "Id";
        }

        private async void bntRefresh_Click(object sender, EventArgs e)
        {
            await LoadItemFromServer();
            RefreshItemList();
            //TODO na balw se ola ta refresh ena Message oti egine refresh i lista
        }

        private async void bntSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ctrItem.Text) || ctrQuantity.Value >= 0)
                return;
            if(_transactionLine.ID== Guid.Empty)
            {

                _transaction.TransactionLineList.Add(ConvertToTransactionLine(_transactionLine));
                //var response = await _client.PostAsJsonAsync("transactionline", _transactionLine);
            }
            else
            {
               var item=_transaction.TransactionLineList.FirstOrDefault(tl => tl.ID == _transactionLine.ID);
                item = ConvertToTransactionLine(_transactionLine);
                //_transaction.TransactionLineList.Find(ConvertToTransactionLine(_transactionLine));
                // var response = await _client.PutAsJsonAsync("transactionline", _transactionLine);
            }
            Close();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private TransactionLine ConvertToTransactionLine( TransactionLineViewModels model) 
        {
            return new TransactionLine()
            {
                ID = model.ID,
                DiscountPercent = model.DiscountPercent,
                DiscountValue = model.DiscountValue,
                ItemID = _items.ElementAt(ctrItem.SelectedIndex).Id,
                Quantity=model.Quentity,
                ItemPrice=model.ItemPrice,
                NetValue=model.NetValue,
                TotalValue=model.TotalValue, 
            };
        }
    }
}

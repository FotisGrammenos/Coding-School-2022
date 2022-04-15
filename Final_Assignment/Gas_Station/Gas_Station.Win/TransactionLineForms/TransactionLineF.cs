using Gas_Station.Shared;
using Handlers;
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
        private TransactionHandler _handler;
        private List<ItemListViewModel> _items;

      
        public TransactionLineF(HttpClient http , TransactionEditViewModel transaction , TransactionHandler transactionHandler)
        {
            InitializeComponent();
            _client = http;
            _transaction = transaction;
            _handler = transactionHandler;
        }

        public TransactionLineF(HttpClient http,TransactionLineViewModels transactionLine, TransactionEditViewModel transaction, TransactionHandler transactionHandler) : this(http,transaction, transactionHandler)
        {
            _transactionLine = transactionLine;
            _handler = transactionHandler;
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

            ctrItem.DataBindings.Add(new Binding("Text",bsTransactionLine, "ItemDescription",true));

            ctrQuantity.DataBindings.Add(new Binding("Text", bsTransactionLine, "Quentity", true));
        }

        private async Task LoadItemFromServer()
        {
            _items = await _client.GetFromJsonAsync<List<ItemListViewModel>>("item");
            if (_handler.CheckFuelExist(_transaction.TransactionLineList, _items))
            {
                _items=_items.Where(i=>i.Type !=Enums.ItemType.Fuel).ToList();
            }
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
            MessageBox.Show("Τhe list of items has been updated ", "Help Caption", MessageBoxButtons.OK);
        }

        private async void bntSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ctrItem.Text) || ctrQuantity.Value <= 0)
            {
                MessageBox.Show("Invalid Inputs", "Error", MessageBoxButtons.OKCancel);
                return;
            }

            if (_transactionLine.ID== Guid.Empty)
            {
                //-----business Rule-------------------------------------------------//
                _transactionLine.ItemPrice = _items.ElementAt(ctrItem.SelectedIndex).Price;
                _transactionLine.NetValue = _handler.CalculateNetValue(_transactionLine.Quentity, _transactionLine.ItemPrice);

                if (_items.ElementAt(ctrItem.SelectedIndex).Type == Enums.ItemType.Fuel)
                {
                    _transactionLine.DiscountValue = _handler.ApplyTenPercentDiscount(_transactionLine.NetValue);
                    if (_transactionLine.DiscountValue > 0) _transactionLine.DiscountPercent = 0.1m;
                }

                _transactionLine.TotalValue = _handler.CalculateLineTotalValue(_transactionLine.DiscountValue, _transactionLine.NetValue);


                _transaction.TransactionLineList.Add(ConvertToTransactionLine(_transactionLine));
                
            }
            else
            {
               var item=_transaction.TransactionLineList.FirstOrDefault(tl => tl.ID == _transactionLine.ID);
                item = ConvertToTransactionLine(_transactionLine);
            }
            Close();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private TransactionLineEditViewModel ConvertToTransactionLine( TransactionLineViewModels model) 
        {
            return new TransactionLineEditViewModel()
            {
                ID = model.ID,
                DiscountPercent = model.DiscountPercent,
                DiscountValue = model.DiscountValue,
                ItemID = _items.ElementAt(ctrItem.SelectedIndex).Id,
                Quentity=model.Quentity,
                ItemPrice=model.ItemPrice,
                NetValue=model.NetValue,
                TotalValue=model.TotalValue, 
                ItemDescription=model.ItemDescription,
            };
        }

        
    }
}

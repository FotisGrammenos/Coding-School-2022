﻿using Gas_Station.EF.Repos;
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
using static System.Net.Http.HttpClient;

namespace Gas_Station.Win
{
    public partial class CustomerListF : Form
    {
        
        private HttpClient _client;
        private List<CustomerListViewModel> _customerList;
        private CustomerListViewModel? _selectedCustomer;

        public CustomerListF(HttpClient myhttpClient)
        {
            InitializeComponent();
            _client = myhttpClient;
            
        }

        private async Task LoadItemsFromServer()
        {
            _customerList = await _client.GetFromJsonAsync<List<CustomerListViewModel>>("customer");
        }

        private async Task RefreshCustomerList()
        {
            grvCustomerList.DataSource = null;
            
            await LoadItemsFromServer();
            grvCustomerList.DataSource = _customerList;

            grvCustomerList.Update();
            grvCustomerList.Refresh();
            grvCustomerList.Columns["ID"].Visible = false;
            grvCustomerList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grvCustomerList.Columns["Surname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grvCustomerList.Columns["CardNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private async void CustomerListF_Load(object sender, EventArgs e)
        {
            await RefreshCustomerList();
            
            grvCustomerList.ReadOnly = true;
           
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var frmCustomerList = new CustomerEditF(_client);
            frmCustomerList.ShowDialog();
            await RefreshCustomerList();
        }

        private async void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (grvCustomerList.SelectedRows.Count != 1)
                return;

            _selectedCustomer = (CustomerListViewModel)grvCustomerList.SelectedRows[index:0].DataBoundItem;
            var frmCustomerList = new CustomerEditF(_client, _selectedCustomer);
            frmCustomerList.ShowDialog();
            await RefreshCustomerList();
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (grvCustomerList.SelectedRows.Count != 1)
                return;

            _selectedCustomer = (CustomerListViewModel)grvCustomerList.SelectedRows[index: 0].DataBoundItem;
            _client.DeleteAsync($"customer/{_selectedCustomer.Id}");
            await RefreshCustomerList();
        }

    }
}

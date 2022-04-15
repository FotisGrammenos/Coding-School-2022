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

namespace Gas_Station.Win
{
    public partial class LoginForm : Form
    {
        private HttpClient _client;
        public UserViewModel _user;

        public LoginForm(HttpClient client)
        {
            InitializeComponent();
            _client = client;
            _user = null;
        }

        private async void bntSave_Click(object sender, EventArgs e)
        {
            _user = await _client.GetFromJsonAsync<UserViewModel>($"users/{txtName.Text}/{txtPassword.Text}");
            if (_user.IsAuth)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OKCancel);
                return;
            }
        }
    }
}

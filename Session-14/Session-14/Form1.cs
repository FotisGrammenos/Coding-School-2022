using App.EF.Repositories;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_14
{
    public partial class Form1 : Form
    {

        private readonly IEntityRepo<Car> _carRepo;

        private List<Car> _carList = new List<Car>();

        public Form1(IEntityRepo<Car> carRepo)
        {
            InitializeComponent();
            _carRepo = carRepo;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshTodos();
        }

        private void RefreshTodos()
        {
            _carList = _carRepo.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _carList;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Brand = textBox1.Text;
            if (string.IsNullOrEmpty(Brand))
                return;
            var myCar = new Car();
            myCar.Brand = Brand;
            _carRepo.Create(myCar);
            textBox1.Text = String.Empty;
            RefreshTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedTodo = selectedRow.DataBoundItem as Car;
                if (selectedTodo is not null)
                {
                    selectedTodo.Model = "2022";
                    _carRepo.Update(selectedTodo.ID, selectedTodo);
                    RefreshTodos();
                }
            }
        }       
    }
}

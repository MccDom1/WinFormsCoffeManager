using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp2;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Coffee> _coffees = new BindingList<Coffee>();

        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            // Fill dropdowns
            cmbSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cmbRoast.Items.AddRange(new object[] { "Light", "Medium", "Dark" });

            cmbSize.SelectedIndex = 0;
            cmbRoast.SelectedIndex = 0;

            // Grid binding
            dgvCoffees.AutoGenerateColumns = true;
            dgvCoffees.DataSource = _coffees;
            dgvCoffees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCoffees.MultiSelect = false;
            dgvCoffees.ReadOnly = true;
            dgvCoffees.AllowUserToAddRows = false;

            // Button events (works even if Designer event wiring is missing)
            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;

            // Optional starter data
            _coffees.Add(new Coffee
            {
                Name = "Latte",
                Size = "Medium",
                Price = 4.50m,
                IsIced = false,
                Roast = "Medium",
                Shots = 2,
                HasMilk = true
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            // Price parse
            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal price))
            {
                MessageBox.Show("Enter a valid price (example: 4.50).");
                return;
            }

            string size = cmbSize.SelectedItem?.ToString() ?? "Medium";
            string roast = cmbRoast.SelectedItem?.ToString() ?? "Medium";

            int shots = (int)numShots.Value;

            var coffee = new Coffee
            {
                Name = name,
                Size = size,
                Price = price,
                IsIced = chkIced.Checked,
                Roast = roast,
                Shots = shots,
                HasMilk = chkMilk.Checked
            };

            _coffees.Add(coffee);
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCoffees.CurrentRow?.DataBoundItem is Coffee selected)
            {
                _coffees.Remove(selected);
            }
            else
            {
                MessageBox.Show("Select a coffee row to delete.");
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtPrice.Clear();
            chkIced.Checked = false;
            chkMilk.Checked = false;
            numShots.Value = 1;
            cmbSize.SelectedIndex = 0;
            cmbRoast.SelectedIndex = 0;
            txtName.Focus();
        }
    }
}

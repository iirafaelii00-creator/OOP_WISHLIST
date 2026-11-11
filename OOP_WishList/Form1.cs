
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OOP_WishList
{
    public partial class MainForm : Form
    {
        string connectionString = "server=localhost;database=wishlist_db;uid=root;pwd=;";

        public MainForm()
        {
            InitializeComponent();
            LoadWishlist();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
       
        private void LoadWishlist()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT
                                    id,
                                    name,
                                    item1,
                                    item1_price,
                                    item2,
                                    item2_price,
                                    (item1_price + item2_price) AS total
                                    FROM wishlist";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvWishlist.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load your wishlist right now. Please check the database connection.\n\n" + ex.Message);
            }
        }

       
        private void btnAddWish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtItem1.Text) ||
                string.IsNullOrWhiteSpace(txtItem1Price.Text) ||
                string.IsNullOrWhiteSpace(txtItem2.Text) ||
                string.IsNullOrWhiteSpace(txtItem2Price.Text))
            {
                MessageBox.Show("Please complete every field before saving your wishlist item.");
                return;
            }

            decimal price1;
            decimal price2;

            if (!decimal.TryParse(txtItem1Price.Text, out price1) ||
                !decimal.TryParse(txtItem2Price.Text, out price2) ||
                price1 < 0 || price2 < 0)
            {
                MessageBox.Show("Please enter valid prices for both items.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO wishlist
                                    (name, item1, item1_price, item2, item2_price)
                                    VALUES
                                    (@name, @item1, @price1, @item2, @price2)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@item1", txtItem1.Text.Trim());
                        cmd.Parameters.AddWithValue("@price1", price1);
                        cmd.Parameters.AddWithValue("@item2", txtItem2.Text.Trim());
                        cmd.Parameters.AddWithValue("@price2", price2);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Your wishlist item was saved successfully!");

                LoadWishlist();

                txtName.Clear();
                txtItem1.Clear();
                txtItem1Price.Clear();
                txtItem2.Clear();
                txtItem2Price.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving your item.\n\n" + ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtItem1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtItem1Price_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtItem2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtItem2Price_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvWishlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

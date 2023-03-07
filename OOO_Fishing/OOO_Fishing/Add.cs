using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOO_Fishing
{
    public partial class Add : Form
    {
        public SqlConnection connection;
        bool AddRegime;
        public Add(SqlConnection conn, bool regime)
        {
            AddRegime = regime;
            connection = conn;
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }

            if (AddRegime)
            {
                Add2_button.Text = "Добавить";
                //textBox10.Visible = true;
                //label10.Visible = true;
            }

            else
            {
                Add2_button.Text = "Изменить";
                //textBox10.Visible = false;
                //label10.Visible = false;
             }
        }

        private void add2_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            if (AddRegime)
            {
                command.CommandText = "Add";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", TextBoxName.Text);
                command.Parameters.AddWithValue("@category", ComboBoxCategory.Text);
                command.Parameters.AddWithValue("@quantity", Convert.ToInt32(TextBoxQuantity.Text));
                command.Parameters.AddWithValue("@unit", TextBoxUnit.Text);
                command.Parameters.AddWithValue("@supplier", TextBoxSupplier.Text);
                command.Parameters.AddWithValue("@cost", Convert.ToInt32(TextBoxCost.Text));
                command.Parameters.AddWithValue("@description", TextBoxDescription.Text);


            }

            else
            {
                command.CommandText = "UpdateProduct";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", TextBoxName.Text);
                command.Parameters.AddWithValue("@category", TextBoxQuantity.Text);
                command.Parameters.AddWithValue("@manufacturer", TextBoxUnit.Text);
                command.Parameters.AddWithValue("@cost", TextBoxSupplier.Text);
                command.Parameters.AddWithValue("@discount_amount", TextBoxCost.Text);
                command.Parameters.AddWithValue("@quantity_in_stock", TextBoxDescription.Text);
            }

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            ProductsView fm2 = new ProductsView(connection);
            fm2.Show();

        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

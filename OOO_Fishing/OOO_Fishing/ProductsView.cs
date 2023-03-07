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
    public partial class ProductsView : Form
    {

        public SqlConnection connection;
        Color col = ColorTranslator.FromHtml("#808080");

        public ProductsView(SqlConnection conn)
        {
            connection = conn;
            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            LabelDescription_2.Text = "";
            LabelMaker_2.Text = "";
            LabelCost_2.Text = "";
            LabelQuantity_2.Text = "";
            LabelName_2.Text = "";
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            productsGrid.DataSource = dataset.Tables[0];

            productsGrid.Columns[0].Visible = false;
            connection.Close();

            label16.Text = (productsGrid.Rows.Count - 1).ToString();
        }

        private void productsGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (productsGrid.Rows[e.RowIndex].Cells[0].Value != DBNull.Value)
            //{
                int valu = Convert.ToInt32(productsGrid.Rows[e.RowIndex].Cells[10].Value);

                if (valu == 0)  //количество на складе
                {
                    productsGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = col; //красим запись
                }
            //}
        }

        private void productsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LabelName_2.Text = productsGrid.CurrentRow.Cells[1].Value.ToString();
            LabelDescription_2.Text = productsGrid.CurrentRow.Cells[2].Value.ToString();
            LabelMaker_2.Text = productsGrid.CurrentRow.Cells[5].Value.ToString();
            LabelCost_2.Text = productsGrid.CurrentRow.Cells[7].Value.ToString();
            LabelQuantity_2.Text = productsGrid.CurrentRow.Cells[10].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductName LIKE '%{TextBoxSearch.Text}%'";
            label15.Text = (productsGrid.Rows.Count - 1).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxFilter.SelectedIndex)
            {
                case 0:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
                case 1:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'SevereLand'";
                    break;
                case 2:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'Kuusamo'";
                    break;
                case 3:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'Gamma'";
                    break;
                case 4:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'Westin'";
                    break;
                case 5:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'Aquatech'";
                    break;
                case 6:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'Stinger'";
                    break;
                case 7:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'LumiCom'";
                    break;
                case 8:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'Usami'";
                    break;
                case 9:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'Ultron'";
                    break;
                case 10:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'Balsax'";
                    break;
                case 11:
                    (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductManufacturer LIKE 'Momoi'";
                    break;
            }
            //change_count();
            //switch (comboBox1.SelectedIndex)
            //{
            //    case 0:
            //        (productsGrid.DataSource as DataTable).DefaultView.RowFilter = "";
            //        break;
            //    case 1:
            //        (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductDiscountAmount >=0 and ProductDiscountAmount <=5 ";
            //        break;
            //    case 2:
            //        (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductDiscountAmount >5 and ProductDiscountAmount <=15 ";
            //        break;
            //    case 3:
            //        (productsGrid.DataSource as DataTable).DefaultView.RowFilter = $"ProductDiscountAmount >=15 ";
            //        break;

            //}
            LabelQuantity_2.Text = (productsGrid.Rows.Count - 1).ToString();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Add Add = new Add(connection, true);
            Add.Show();
            Hide();
        }

        private void productsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Add add = new Add(connection, false);
            add.Show();
            Hide();
        }

        private void ProductsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization auth = new Authorization();
            auth.Show();
        }
    }
}

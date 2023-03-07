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
using System.IO;

namespace OOO_Fishing
{
    public partial class Authorization : Form
    {
        static string connection = "Data Source=DESKTOP-R43QGNG\\SQLEXPRESS;Initial Catalog=Trade_PRO2;Integrated Security=True";
        private string text = String.Empty; //пустая строка для капчи
       public SqlConnection conn = new SqlConnection(connection);


        public Authorization()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {

            SqlCommand sqlCommand =  conn.CreateCommand();
            sqlCommand.CommandText = $"SELECT * FROM [User] WHERE UserLogin='{TextBox_login.Text}' and UserPassword = '{TextBox_password.Text }'";
            sqlCommand.Connection = conn;

            if (conn.State==ConnectionState.Closed)
                conn.Open();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                {
                    reader["UserLogin"].ToString();
                    reader["UserPassword"].ToString();
                }
                switch (reader.GetInt32(6))
                {
                    case 1:
                        Form Form2 = new ProductsView(conn);
                        Hide();
                        Form2.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ошибка");
                PictureBox_captcha.Image = this.CreateImage(PictureBox_captcha.Width, PictureBox_captcha.Height);
                textBoxCaptcha.Visible = true;
            }
        }
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(0, 30);
            int Ypos = rnd.Next(0, 30);

            Brush[] colors =
            {
                Brushes.Black,
                Brushes.Red,
                Brushes.RoyalBlue,
                Brushes.Green
            };

            Graphics g = Graphics.FromImage((Image)result);

            g.Clear(Color.Gray);

            Text = String.Empty;
            String alf = "4565657676778HYYRFIOV";
            for (int i = 0; i < 5; ++i)
                Text += alf[rnd.Next(alf.Length)];

            g.DrawString(Text, new Font("Arial", 15), colors[rnd.Next(colors.Length)], new PointF(Xpos, Ypos));


            g.DrawLine(Pens.Black, new Point(rnd.Next(0, 30), rnd.Next(0, 30)), new Point(rnd.Next(30, 60), rnd.Next(30, 60)));
            g.DrawLine(Pens.Black, new Point(rnd.Next(0, 30), rnd.Next(0, 30)), new Point(rnd.Next(30, 60), rnd.Next(30, 60)));

            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;

        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

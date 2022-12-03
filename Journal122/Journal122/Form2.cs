using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Journal122
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"L:\\Visual Code\\Project\\Journal\\Journal122\\Journal122\\Database1.mdf\";Integrated Security=True");
            {
                String Login, Password;
                Login = user.Text;
                Password = pass.Text;

                try
                {
                    String querry = "SELECT * FROM dbo.TableR WHERE Login = '" + user.Text + "' AND Password = '" + pass.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        Login = user.Text;
                        Password = pass.Text;
                        this.Hide();
                        Form1 ss = new Form1();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invaild login detalis", "Error", MessageBoxButtons.OK);
                        user.Clear();
                        pass.Clear();

                        user.Focus();

                    }
                }

                catch

                {

                    MessageBox.Show("Error");
                }

                finally

                {

                    conn.Close();

                }



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ss = new Form3();
            ss.Show();
        }
    }
}


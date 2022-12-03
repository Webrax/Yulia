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
using System.Xml.Linq;

namespace Journal122
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"L:\\Visual Code\\Project\\Journal\\Journal122\\Journal122\\Database1.mdf\";Integrated Security=True");


            String Login, Password;
            Login = UserReg.Text;
            Password = PassReg.Text;

            try
            {
                string query = "Insert into * FROM dbo.TableR WHERE Login = '" + UserReg + "'AND Password'" + PassReg + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Профіль успішно створено");
            }
            catch
            {
                MessageBox.Show("Профіль успішно створено");
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }
    }
}








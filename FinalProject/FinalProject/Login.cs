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

namespace FinalProject
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool isLogin(string username1,string password1)
        {
            string query = "SELECT * FROM Students WHERE username='" + username1 + "'" + " and password='" + password1 + "'";
            //MessageBox.Show(query);
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roozb\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            bool rows = reader.HasRows;
            reader.Close();
            sqlConnection.Close();
            return rows;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username1 = Userlog.Text;
                string password1 = PassLogin.Text;
                bool condition=isLogin(username1, password1);
                if (condition )
                {
                    //MessageBox.Show(Userlog.Text);
                    //MessageBox.Show(PassLogin.Text);
                    MessageBox.Show("Login succefully");
                    UserPannel userPannel = new UserPannel();
                    userPannel.Show();
                    this.Close();
                }
                else
                {
                    
                    //MessageBox.Show(Userlog.Text);
                    //MessageBox.Show(PassLogin.Text);
                    MessageBox.Show("Login failed!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //UserPannel userPannel = new UserPannel();
            //userPannel.Show();

        }

        private void textBox1_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

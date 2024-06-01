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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        int GenerateQuery(string name, string lastname, string username, string password)
        {
            if (name == null || lastname == null || username == null || password == null)
            {
                Console.WriteLine("You don't allow to enter nothing");
                return 0;
            }
            string query1 = "SELECT * FROM Students";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roozb\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand(query1, conn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["username"] == username) {
                    MessageBox.Show("Invalid username!");
                    return 0;
                 }
            }
            conn.Close();
            string query = "INSERT INTO Students(name,lastname,username,password)" +
                "VALUES(' "  + name + "','"+lastname+  "','" + username + "','" +password+"')";
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roozb\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand command2 = new SqlCommand(query, sqlConnection);
            int i = command2.ExecuteNonQuery();
            sqlConnection.Close();
            return i;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = nam.Text;
            string lastname = Lastname.Text;
            string username = Username.Text;
            string password = Password.Text;
            //UserPannel userPannel = new UserPannel();
            //userPannel.Show();
            try
            {
                int i = GenerateQuery(name, lastname, username, password);
                if (i > 0)
                {
                    SignUp one = new SignUp();
                    MessageBox.Show("Sign in successfully");
                    //MessageBox.Show(username);
                    //MessageBox.Show(password);
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                    
                }
                else
                {
                    MessageBox.Show("Nashod!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

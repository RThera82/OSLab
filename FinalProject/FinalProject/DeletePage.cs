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
    public partial class usercode1 : Form
    {
        public usercode1()
        {
            InitializeComponent();
        }

        private void DeletePage_Load(object sender, EventArgs e)
        {

        }

        private void username3_Click(object sender, EventArgs e)
        {

        }
        public string verif = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            string id43 = ID33.Text;
            string verifcode = textBox1.Text;
            string query = "DELETE FROM Students WHERE Id='" + id43 + "'";
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roozb\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();
            //MessageBox.Show(verif);
            //MessageBox.Show(verifcode);
            if (verifcode==verif && verifcode!=null)
            {
                //MessageBox.Show("Shod");
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    sqlConnection.Close();
                    this.Hide();
                    MessageBox.Show("Your account deleted successfully");

                    for (int j = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if(Application.OpenForms[i].Name!="Form1" && Application.OpenForms[i].Name!="DeletePage")
                            Application.OpenForms[j].Close();
                    }
                    Form1 form5 = new Form1();
                    form5.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nashod!");
                }
            }
            else
            {
                MessageBox.Show("Nashod!");
            }
            sqlConnection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int verficationcode = random.Next(100000);
            string code = verficationcode.ToString();
            MessageBox.Show(code);
            verif = code;
        }

        private void usercode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

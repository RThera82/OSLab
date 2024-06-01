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
    public partial class Survey : Form
    {
        public Survey()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string currenttext = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string currenttext = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string currenttext = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string currenttext = radioButton4.Text;
        }
        private void dis()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedoption = null;
                if (radioButton1.Checked)
                {
                    selectedoption = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    selectedoption = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    selectedoption = radioButton3.Text;
                }
                else if (radioButton4.Checked)
                {
                    selectedoption = radioButton4.Text;
                }
                else
                {
                    MessageBox.Show("Nashod!");
                }
                
                string query = "UPDATE names SET vote_count=vote_count+1" +
                    " WHERE candidate_name='" + selectedoption + "'";
                SqlConnection sqlconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roozb\source\repos\FinalProject\FinalProject\Candidates.mdf;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
                int i = sqlcommand.ExecuteNonQuery();
                
                if (i > 0)
                {
                    MessageBox.Show("رای شما با موفقیت ثبت شد");
                    this.Close();
                    button1.Enabled = false;
                    sqlconnection.Close();

                }
                else
                    MessageBox.Show("نشد");
                sqlconnection.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UserPannel : Form
    {
        public UserPannel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            usercode1 deletePage = new usercode1();
            deletePage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Survey survey = new Survey();
            survey.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateUsers updateUsers = new UpdateUsers();
            updateUsers.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendMessage sendMessage = new SendMessage();
            sendMessage.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Answer answer = new Answer();
            answer.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Informations informations = new Informations();
            informations.Show();
        }
    }
}

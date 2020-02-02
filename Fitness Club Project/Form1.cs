using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Club_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration ss = new Registration();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FitnessClubDBEntities1 database = new FitnessClubDBEntities1())
            {
                var user = database.UserLogs.FirstOrDefault(x => x.Login == UsernameTextBox.Text);

                if(user != null)
                {
                    if (user.Password == PasswordTextBox.Text)
                    {
                        this.Hide();
                        Form3 aa = new Form3(user);
                        aa.Show();
                    }
                    else { MessageBox.Show("Incorrect Password!, Try it again");}
                }

                else { MessageBox.Show("Incorrect Login!"); }
                    

                
            }





                
        }
    }
}

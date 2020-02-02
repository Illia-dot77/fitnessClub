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

    

    public partial class Registration : Form
    {

        UserInformation client = new UserInformation();
        UserLog aaa = new UserLog();
        Random randomise = new Random();
        UserContact bbb = new UserContact();

        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void CreateUserBox_Click(object sender, EventArgs e)
        {           
               
            {
                if (FirstNameBox.Text == "" || LastNameBox.Text == "" || LastNameBox.Text == "" ||
                PasswordBox.Text == "" || HeightBox.Text == "" || weightlabel.Text == "" || AgeBox.Text == "" || EmailBox.Text == "" ||
                PhoneNumberBox.Text == "" || LoginBox.Text == "")
                {
                    MessageBox.Show("Be sure you've filled all gaps!");
                }
                else
                {
                    client.loginID = randomise.Next();
                    client.userID = client.loginID;

                    client.firstname = FirstNameBox.Text;
                    client.lastname = LastNameBox.Text;
                    client.height = int.Parse(HeightBox.Text);
                    client.weight = int.Parse(WeightBox.Text);

                    if(RadioButtMale.Checked == true) { client.gender = "male"; }
                    if (RadioButtFemale.Checked == true) { client.gender = "female"; }


                    bbb.userID = client.userID;
                    aaa.loginID = client.loginID;

                    aaa.Login = LoginBox.Text;
                    aaa.Password = PasswordBox.Text;

                    bbb.PhoneNumber = PhoneNumberBox.Text;
                    bbb.Email = EmailBox.Text;

                    using(FitnessClubDBEntities1 database = new FitnessClubDBEntities1())
                    {
                        database.UserInformations.Add(client);
                        database.UserLogs.Add(aaa);
                        database.UserContacts.Add(bbb);
                        database.SaveChanges();
                    }

                    MessageBox.Show("Congratulations!!!! Now you are ready to work");
                }
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

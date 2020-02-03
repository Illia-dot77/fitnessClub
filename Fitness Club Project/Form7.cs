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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ss = new Form4();
            ss.Show();
        }

        private void UpdateButt_Click(object sender, EventArgs e)
        {
            if(FirstNameBox.Text !="" && LastNameBox.Text != ""
                && PasswordBox.Text != "" && PhoneNumberBox.Text != ""
                && EmailBox.Text != "")
            {
                FitnessClubDBEntities1 database = new FitnessClubDBEntities1();
                database.UserInformations.Find(Form4.thisUser.userID).firstname = FirstNameBox.Text;
                database.UserInformations.Find(Form4.thisUser.userID).lastname = LastNameBox.Text;
                database.UserLogs.Find(Form4.thisUser.loginID).Password = PasswordBox.Text;
                database.UserContacts.Find(Form4.thisUser.userContactID).PhoneNumber = PhoneNumberBox.Text;
                database.UserContacts.Find(Form4.thisUser.userContactID).Email = EmailBox.Text;
                database.SaveChanges();
                MessageBox.Show("Operation completed successfully");
            }
            else
            {
                MessageBox.Show("Please, fill all fields!");
            }
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            FitnessClubDBEntities1 database = new FitnessClubDBEntities1();
            database.Entry(Form4.thisUser).State = System.Data.Entity.EntityState.Deleted;
            database.Entry(Form4.thisLog).State = System.Data.Entity.EntityState.Deleted;
            database.Entry(Form4.thisContact).State = System.Data.Entity.EntityState.Deleted;
            database.UserInformations.Remove(Form4.thisUser);
            database.UserLogs.Remove(Form4.thisLog);
            database.UserContacts.Remove(Form4.thisContact);
            database.SaveChanges();

            this.Hide();
            MessageBox.Show("Your account was deleted!");


        }
    }
}

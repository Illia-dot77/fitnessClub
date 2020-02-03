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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ss = new Form4();
            ss.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'fitnessClubDBDataSet1.Clubs' . Możesz go przenieść lub usunąć.
            this.clubsTableAdapter.Fill(this.fitnessClubDBDataSet1.Clubs);

        }

        public void PopulateDataGridView()
        {
            using (FitnessClubDBEntities1 database = new FitnessClubDBEntities1())
            {
                this.dataGridView1.DataSource = database.Clubs.ToList();
            }
        }
    }
}

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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ss = new Form4();
            ss.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'fitnessClubDBDataSet.Organizer' . Możesz go przenieść lub usunąć.
            this.organizerTableAdapter.Fill(this.fitnessClubDBDataSet.Organizer);

        }

        public void PopulateDataGridView()
        {
            using (FitnessClubDBEntities1 database = new FitnessClubDBEntities1())
            {
                this.dataGridView1.DataSource = database.Organizers.ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            random = rnd.Next(0, 100);
        }
        int random;
        Random rnd = new Random();

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            
            if (Convert.ToInt32(txtGues.Text) == random)
            {
                MessageBox.Show("Well Done");
            }
            else if(Convert.ToInt32(txtGues.Text) > random)
            {
                string liste = txtGues.Text + ", Lower";
                lstGuesedNumbers.Items.Add(liste);
                MessageBox.Show("More Lower");
                txtGues.Clear();
            }
            else
            {
                string liste = txtGues.Text + ", Higher";
                lstGuesedNumbers.Items.Add(liste);
                MessageBox.Show("More Higher");
                txtGues.Clear();
            }
        }

        private void btnGameStarter_Click(object sender, EventArgs e)
        {
            random = rnd.Next(0, 100);
            lstGuesedNumbers.Items.Clear();
            txtGues.Clear();
        }

    }
}

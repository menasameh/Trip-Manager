using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tripManager
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void manageTrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TripChooser(State.edit, this).Show();
        }

        private void selectTrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TripChooser(State.view, this).Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}

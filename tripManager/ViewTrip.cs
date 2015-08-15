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
    public partial class ViewTrip : Form
    {
        menu menu;
        public ViewTrip(menu menu)
        {
            this.menu = menu;
            InitializeComponent();
        }

        private void ViewTrip_Load(object sender, EventArgs e)
        {

        }

        private void manageTripNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void manageTripPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

       
    }
}

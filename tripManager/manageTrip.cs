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
    public partial class manageTrip : Form
    {
        State state;
        menu menu;
        public manageTrip(State state, menu menu)
        {
            this.state = state;
            this.menu = menu;
            InitializeComponent();
        }

        private void manageTrip_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void manageTripBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

    }
}

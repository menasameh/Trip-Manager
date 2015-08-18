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
    public enum State
    {
        edit, view, create
    }

    public partial class TripChooser : Form
    {
        State state;
        menu menu;

        
        public TripChooser(State state, menu menu)
        {
            this.state = state;
            this.menu = menu;
            InitializeComponent();
        }

        private void TripChooser_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void tripChooserSelect_Click(object sender, EventArgs e)
        {
            
            switch (state)
            {
                case State.edit:
                    new manageTrip(State.edit, menu).Show();
                    break;
                case State.view:
                    new ViewTrip(menu).Show();
                    break;
            }
            this.Close();
        }

        private void tripChooserCreate_Click(object sender, EventArgs e)
        {
            
            new manageTrip(State.create, menu).Show();
            this.Close();
        }

        private void tripChooserBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }
    }
}

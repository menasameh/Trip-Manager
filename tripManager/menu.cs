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

            new manageTrip(State.edit, this).Show();
        }

        private void selectTrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            String tripName = tripChooserList.SelectedText;
            new ViewTrip(this).Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.VisibleChanged += showDefaultButtons;
            showDefaultButtons();
        }

        private void showDefaultButtons()
        {
            selectTrip.Enabled = false;
            manageTrip.Enabled = false;
            tripChooserList.Text = "";
            tripChooserList.SelectedText = "";
            CenterToScreen();
        }

        public void showDefaultButtons(object sender, EventArgs e)
        {
            showDefaultButtons();
        }


        private void tripChooserCreate_Click(object sender, EventArgs e)
        {
            new manageTrip(State.create, this).Show();
            this.Hide();
        }

        private void tripChooserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectTrip.Enabled = true;
            manageTrip.Enabled = true;
        }
    }
}

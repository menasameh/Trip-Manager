using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tripManager.controller;
using tripManager.model;

namespace tripManager
{

    public enum State
    {
        edit, view, create
    }

    public partial class menu : Form
    {

        ArrayList tripsList; 
        ArrayList tripsIDs;

        int index;

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
            //Prompt.ShowWarningDialog(tripNameManage, "sdf");
            new manageTrip((int)tripsIDs[index], this).Show();
        }

        private void selectTrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewTrip((int)tripsIDs[index], this).Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            updateList();
            this.VisibleChanged += showDefaultButtons;
            showDefaultButtons();
        }

        public void updateList()
        {
            DBHandler instance = DBHandler.getInstance();
            List<Trip> trips = instance.getTrips();

            tripsIDs = new ArrayList();
            tripsList = new ArrayList();

            for (int i = 0; i < trips.Count; i++)
            {
                tripsList.Add(trips[i].name);
                tripsIDs.Add(trips[i].ID);
            }
            tripList.DataSource = tripsList;
        }

        private void showDefaultButtons()
        {
            selectTrip.Enabled = false;
            manageTrip.Enabled = false;
            tripList.Text = "";
            tripList.SelectedText = "";
            CenterToScreen();
        }

        public void showDefaultButtons(object sender, EventArgs e)
        {
            showDefaultButtons();
        }


        private void tripChooserCreate_Click(object sender, EventArgs e)
        {
            new manageTrip( this).Show();
            this.Hide();
        }

        private void tripChooserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = ((ComboBox)sender).SelectedIndex;
            selectTrip.Enabled = true;
            manageTrip.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tripManager.controller;
using tripManager.model;

namespace tripManager
{
    public partial class manageTrip : Form
    {
        State state;
        menu menu;
        Trip trip;
        int tripID;
        public manageTrip(menu menu)
        {
            this.state = State.create;
            this.menu = menu;
            InitializeComponent();
        }
        public manageTrip(int tripID,  menu menu)
        {

            this.tripID = tripID;
            this.state = State.edit;
            this.menu = menu;
            InitializeComponent();
        }

        public void showBasicButtons()
        {
            tripName.Enabled = false;
            tripDate.Enabled = false;
            tripPrice.Enabled = false;
            tripNotes.Enabled = false;
            changablePrice.Enabled = false;

            numberOfParticipants.Visible = true;
            basicContols.Visible = true;
            createControls.Visible = false;
            editEndControls.Visible = false;

        }



        public void showEditButtons()
        {
            tripName.Enabled = true;
            tripDate.Enabled = true;
            tripPrice.Enabled = true;
            tripNotes.Enabled = true;
            changablePrice.Enabled = true;

            basicContols.Visible = false;
            createControls.Visible = false;
            editEndControls.Visible = true;
        }

        public void showCreateButtons()
        {
            tripName.Enabled = true;
            tripDate.Enabled = true;
            tripPrice.Enabled = true;
            tripNotes.Enabled = true;
            changablePrice.Enabled = true;



            numberOfParticipants.Visible = false;
            basicContols.Visible = false;
            createControls.Visible = true;
            editEndControls.Visible = false;
        }


        private void manageTrip_Load(object sender, EventArgs e)
        {
            switch (state)
            {
                case State.create:
                    Text = "انشاء رحلة";
                    showCreateButtons();
                    break;
                case State.edit:
                    DBHandler instance = DBHandler.getInstance();
                    trip = instance.getTrip(tripID);
                    Text = "ادارة رحلة";
                    tripToFields();
                    showBasicButtons();
                    break;

            }
            CenterToScreen();
        }

        public void tripToFields()
        {
            tripName.Text = trip.name;
            tripDate.Value = trip.Date;
            tripPrice.Text = trip.price + "";
            tripNotes.Text = trip.notes;
            changablePrice.Checked = trip.hasChangablePrice;
            tripCount.Text = trip.reservations.Count + "";
        }


        public void fieldsTotrip()
        {
        trip.name = tripName.Text;
            trip.hasChangablePrice = changablePrice.Checked;
            trip.price = float.Parse(tripPrice.Text, CultureInfo.InvariantCulture.NumberFormat);
            trip.notes = tripNotes.Text;
            trip.Date = tripDate.Value;
    }


        private void manageTripBack_Click(object sender, EventArgs e)
        {
            menu.updateList();
            menu.Show();
            this.Close();
        }

        private void manageTripEdit_Click(object sender, EventArgs e)
        {
            showEditButtons();
        }

        private void manageTripDelete_Click(object sender, EventArgs e)
        {
            int promptValue = Prompt.ShowConfirmDialog("هل تود مسح الرحلة؟", "تحذير");
            if (promptValue == 1)
            {
                DBHandler instance = DBHandler.getInstance();
                instance.removeTrip(trip);
                menu.updateList();
                menu.Show();
                Close();
            }
        }

        private void manageTripFreeze_Click(object sender, EventArgs e)
        {

        }

        private void manageTripCreate_Click(object sender, EventArgs e)
        {
            DBHandler instance = DBHandler.getInstance();
            trip = new Trip();
            fieldsTotrip();
            


            //validations goes here 
            bool valid = true;
            string msg="";


            //end validations

            if(valid){
                instance.insertTrip(trip);

                Prompt.ShowWarningDialog("تم انشاء الرحله بنجاح", "تم");
                menu.updateList();
                menu.Show();
                Close();
            }
            else
            {
                Prompt.ShowWarningDialog(msg, "تحذير");
            }


           
        }

        private void manageTripBack2_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void manageTripDone_Click(object sender, EventArgs e)
        {
            DBHandler instance = DBHandler.getInstance();
            trip.name = tripName.Text;
            trip.hasChangablePrice = changablePrice.Checked;
            trip.price = float.Parse(tripPrice.Text, CultureInfo.InvariantCulture.NumberFormat);
            trip.notes = tripNotes.Text;
            trip.Date = tripDate.Value;
            if (!instance.updateTrip(trip))
            {
                Prompt.ShowWarningDialog("error", "error");
            }
            if (!trip.hasChangablePrice)
            {
                instance.updateTripReservations(trip.ID, trip.price);
            }
            showBasicButtons();
        }

        private void manageTripCancel_Click(object sender, EventArgs e)
        {
            int promptValue = Prompt.ShowConfirmDialog("هل تود الرجوع عن التغيرات ؟", "تحذير");
            if (promptValue == 1)
            {
                tripToFields();
                showBasicButtons();
            }
            else
            {

            }
           
        }

    }
}

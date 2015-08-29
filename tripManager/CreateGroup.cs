using System;
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
    public partial class CreateGroup : Form
    {
        Trip trip;
        ViewTrip vt;
        
        public CreateGroup()
        {
            InitializeComponent();
        }

        public void setTrip(Trip trip, ViewTrip vt)
        {
            this.trip = trip;
            this.vt = vt;
        }



        private void CreateGroup_Load(object sender, EventArgs e)
        {
            isGroup.Checked = true;
            ShowSizeLimit();
            CenterToScreen();
        }





        private void ShowSizeLimit()
        {
            if (hasSizeLimit.Checked)
            {
                groupSize.Enabled = true;
            }
            else
            {
                groupSize.Enabled = false;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            DBHandler instance = DBHandler.getInstance();
            Group selectedGroup = new Group();
            selectedGroup.tripID = trip.ID;
            selectedGroup.name = groupName.Text;
            selectedGroup.isBus = isBus.Checked;
            selectedGroup.hasSizeLimit = hasSizeLimit.Checked;
            if (hasSizeLimit.Checked)
                selectedGroup.capacity = int.Parse(groupSize.Text);
            if (instance.insertTripGroup(trip, selectedGroup))
            {
                vt.open = false;
                vt.updateGroupList();
                Close();
            }
            else
            {
                Prompt.ShowWarningDialog("error", "error");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            vt.open = false;
            Close();
        }

        private void hasSizeLimit_CheckedChanged(object sender, EventArgs e)
        {
            ShowSizeLimit();
        }



    }
}

using System;
using System.Collections;
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
    public partial class ViewTrip : Form
    {
        menu menu;
        Trip trip;
        Group selectedGroup;
        Client selectedClient;
        Reservation selectedReservation;
        int tripID;
        public bool open;

        int grpIndex;
        int busIndex;

        ArrayList groupsIDs;
        ArrayList groupsList;

        ArrayList grpIDs;
        ArrayList grpList;


        ArrayList busesIDs;
        ArrayList busesList;



        public ViewTrip(int tripID, menu menu)
        {
            open = false;
            this.menu = menu;
            this.tripID = tripID;
            InitializeComponent();
        }

        private void ViewTrip_Load(object sender, EventArgs e)
        {
            DBHandler instance = DBHandler.getInstance();
            trip = instance.getTrip(tripID);
            tripToFields();
            updateGroupList();
            CenterToScreen();
            clientsDefaults();
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        }


        public void updateGroupList()
        {
            DBHandler instance = DBHandler.getInstance();
            List<Group> groups = instance.getTripGroups(tripID);
            List<Group> grps = groups.Where(g => !g.isBus).ToList();
            List<Group> buses = groups.Where(g => g.isBus).ToList();



            groupsIDs = new ArrayList();
            groupsList = new ArrayList();

            grpIDs = new ArrayList();
            grpList = new ArrayList();

            busesIDs = new ArrayList();
            busesList = new ArrayList();



            for (int i = 0; i < groups.Count; i++)
            {
                groupsList.Add(groups[i].name);
                groupsIDs.Add(groups[i].ID);
            }

            for (int i = 0; i < grps.Count; i++)
            {
                grpList.Add(grps[i].name);
                grpIDs.Add(grps[i].ID);
            }

            for (int i = 0; i < buses.Count; i++)
            {
                busesList.Add(buses[i].name);
                groupsIDs.Add(buses[i].ID);
            }
            groupList.SelectedIndex = -1;
            group.SelectedIndex = -1;
            bus.SelectedIndex = -1;
            groupList.DataSource = groupsList;
            group.DataSource = grpList;
            bus.DataSource = busesList;
            groupList.SelectedIndex = -1;
            group.SelectedIndex = -1;
            bus.SelectedIndex = -1;
            
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

        public void clientsDefaults()
        {
            clientName.Enabled = false;
            clientPay.Enabled = false;
            clientPhone.Enabled = false;
            group.Enabled = false;
            bus.Enabled = false;
            hasBus.Enabled = false;
            hasGroup.Enabled = false;


            clientDetails.Visible = false;
            searchPanel.Visible = false;

            btnsClientsCreate.Visible = false;
            btnsClientsDoneEdits.Visible = false;
            btnsClientsSelected.Visible = false;
            actionButtons.Visible = true;

        }

        public void groupsDefaults()
        {
            groupName.Enabled = false;
            groupSize.Enabled = false;
            hasSizeLimit.Enabled = false;
            
            isBus.Enabled = false;
            isGroup.Enabled = false;

            groupList.Visible = true;
            groupDetails.Visible = false;

            btnsGroupCreate.Visible = false;
            btnsGroupDoneEdits.Visible = false;
            btnsGroupSelected.Visible = false;
        }


        public void clientsCreateElements()
        {
            clientName.Enabled = true;
            clientPay.Enabled = true;
            clientPhone.Enabled = true;
            clientName.Text = "";
            clientPay.Text = "";
            clientPhone.Text = "";
            group.Enabled = false;
            bus.Enabled = false;
            hasBus.Enabled = true;
            hasGroup.Enabled = true;
            hasBus.Checked = false;
            hasGroup.Checked = false;
            ShowChooseGroup();
            updateGroupList();
            clientID.Text = trip.nextTicketID+ "";
            clientDetails.Visible = true;
            searchPanel.Visible = false;

            btnsClientsCreate.Visible = true;
            btnsClientsDoneEdits.Visible = false;
            btnsClientsSelected.Visible = false;
            actionButtons.Visible = false;
        }

        public void groupsCreateElements()
        {
            groupName.Enabled = true;
            groupSize.Enabled = false;
            hasSizeLimit.Enabled = true;

            isBus.Enabled = true;
            isGroup.Enabled = true;
            groupSize.Enabled = false;

            isGroup.Checked = true;
            groupName.Text = "";
            hasSizeLimit.Checked = false;

            groupList.Visible = false;
            groupDetails.Visible = true;

            btnsGroupCreate.Visible = true;
            btnsGroupDoneEdits.Visible = false;
            btnsGroupSelected.Visible = false;
        }



        public void searchElements()
        {
            clientName.Enabled = false;
            clientPay.Enabled = false;
            clientPhone.Enabled = false;
            hasBus.Enabled = false;
            hasGroup.Enabled = false;


            clientDetails.Visible = false;
            searchPanel.Visible = true;

            btnsClientsCreate.Visible = false;
            btnsClientsDoneEdits.Visible = false;
            btnsClientsSelected.Visible = false;
            actionButtons.Visible = false;
        }

        public void clientsSelectElements()
        {
            clientName.Enabled = false;
            clientPay.Enabled = false;
            clientPhone.Enabled = false;
            hasBus.Enabled = false;
            hasGroup.Enabled = false;


            clientDetails.Visible = true;
            searchPanel.Visible = false;

            btnsClientsCreate.Visible = false;
            btnsClientsDoneEdits.Visible = false;
            btnsClientsSelected.Visible = true;
            actionButtons.Visible = false;
        }


        public void groupsSelectElements()
        {
            groupName.Enabled = false;
            groupSize.Enabled = false;
            hasSizeLimit.Enabled = false;

            isBus.Enabled = false;
            isGroup.Enabled = false;

            groupList.Visible = false;
            groupDetails.Visible = true;

            btnsGroupCreate.Visible = false;
            btnsGroupDoneEdits.Visible = false;
            btnsGroupSelected.Visible = true;
        }

        public void clientsEnableEditElements()
        {
            clientName.Enabled = true;
            clientPay.Enabled = true;
            clientPhone.Enabled = true;
            hasBus.Enabled = true;
            hasGroup.Enabled = true;


            clientDetails.Visible = true;
            searchPanel.Visible = false;

            btnsClientsCreate.Visible = false;
            btnsClientsDoneEdits.Visible = true;
            btnsClientsSelected.Visible = false;
            actionButtons.Visible = false;
        }

        public void groupsEnableEditElements()
        {
            groupName.Enabled = true;
            hasSizeLimit.Enabled = true;
            ShowSizeLimit();

            isBus.Enabled = true;
            isGroup.Enabled = true;

            groupList.Visible = false;
            groupDetails.Visible = true;

            btnsGroupCreate.Visible = false;
            btnsGroupDoneEdits.Visible = true;
            btnsGroupSelected.Visible = false;
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

        private void addClient_Click(object sender, EventArgs e)
        {
            clientsCreateElements();
        }


        private void createClient_Click(object sender, EventArgs e)
        {
            DBHandler instance = DBHandler.getInstance();
            selectedClient = new Client();
            selectedReservation = new Reservation();
            fieldsToClient();
            fieldsToReservation();


            //validations goes here 
            bool valid = true;
            string msg = "";


            //end validations

            if (valid)
            {
                instance.insertResrvation(selectedClient, trip, selectedReservation);
                if (hasGroup.Checked)
                {
                    instance.insertClientGroup(selectedClient.ID, (int)grpIDs[grpIndex]);
                }
                if (hasBus.Checked)
                {
                    instance.insertClientGroup(selectedClient.ID, (int)busesIDs[busIndex]);
                }
                Prompt.ShowWarningDialog("تم اضافة العميل بنجاح", "تم");
                updateAutoComplete();
                clientsDefaults();
            }
            else
            {
                Prompt.ShowWarningDialog(msg, "تحذير");
            }
        }

        private void fieldsToReservation()
        {
            
            selectedReservation.ticketID = int.Parse(clientID.Text);
            selectedReservation.priceToPay = float.Parse(tripPrice.Text);
            selectedReservation.pricePaid = float.Parse(clientPay.Text);
            selectedReservation.Date = DateTime.Now;
        }

        private void updateAutoComplete()
        {
            throw new NotImplementedException();
        }

        private void fieldsToClient()
        {
            selectedClient.name = clientName.Text;
            selectedClient.phoneNumber = clientPhone.Text;
        }

        private void cancelCreate_Click(object sender, EventArgs e)
        {

            clientsDefaults();
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            searchElements();
        }

        private void cancelSearch_Click(object sender, EventArgs e)
        {
            clientsDefaults();
        }

        private void search_Click(object sender, EventArgs e)
        {
            clientsSelectElements();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            clientsEnableEditElements();
        }

        private void cancelEditClient_Click(object sender, EventArgs e)
        {
            clientsDefaults();
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            int promptValue = Prompt.ShowConfirmDialog("هل تود بالفعل مسح العميل ؟", "تحذير");
            if(promptValue == 1){
                clientsDefaults();
            }
            else
            {

            }

        }

        private void cancelEdit_Click(object sender, EventArgs e)
        {
            int promptValue = Prompt.ShowConfirmDialog("هل تود الرجوع عن التغيرات ؟", "تحذير");
            if (promptValue == 1)
            {
                clientsSelectElements();
            }
            else
            {

            }
        }

        private void doneEdit_Click(object sender, EventArgs e)
        {
            clientsSelectElements();
        }


        void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //
            if (tabControl1.SelectedIndex == 0)
            {
                clientsDefaults();
            }
            else
            {
                groupsDefaults();
                //List<TripGroup> arr =  trip.tripGroups.ToList();
                //updateGroupList();
            }
        }

        private void cancelCreateGroup_Click(object sender, EventArgs e)
        {
            groupsDefaults();
        }

        private void cancelEditGroup_Click(object sender, EventArgs e)
        {
            updateGroupList();
            groupsDefaults();
        }

        private void cancelEditDoneGroup_Click(object sender, EventArgs e)
        {
            int promptValue = Prompt.ShowConfirmDialog("هل تود الرجوع عن التغيرات ؟", "تحذير");
            if (promptValue == 1)
            {
                groupsSelectElements();
            }
            else
            {

            }
            
        }

        private void createGroup_Click(object sender, EventArgs e)
        {
            DBHandler instance = DBHandler.getInstance();
            selectedGroup = new Group();
            selectedGroup.tripID = tripID;
            fieldsToGroup();
            if (instance.insertTripGroup(trip, selectedGroup))
            {
                updateGroupList();
                groupsDefaults();
            }
            else
            {
                Prompt.ShowWarningDialog("error", "error");
            }
                       
        }

        private void fieldsToGroup()
        {
            selectedGroup.name = groupName.Text;
            selectedGroup.isBus = isBus.Checked;
            selectedGroup.hasSizeLimit = hasSizeLimit.Checked;
            if(hasSizeLimit.Checked)
                selectedGroup.capacity = int.Parse(groupSize.Text);
        }

        private void deleteGroup_Click(object sender, EventArgs e)
        {
            int promptValue = Prompt.ShowConfirmDialog("هل تود بالفعل مسح المجموعة ؟", "تحذير");
            if (promptValue == 1)
            {
                //TODO is this "remove group" cascading? yes it is :D
                DBHandler instance = DBHandler.getInstance();
                instance.removeGroup(selectedGroup);
                updateGroupList();
                groupsDefaults();
            }
        }

        private void editGroup_Click(object sender, EventArgs e)
        {
            groupsEnableEditElements();
        }

        private void doneEditGroup_Click(object sender, EventArgs e)
        {
            DBHandler instance = DBHandler.getInstance();

            fieldsToGroup();

            instance.updateGroup(selectedGroup);

            groupsSelectElements();
        }

        private void addGroup_Click(object sender, EventArgs e)
        {
            groupsCreateElements();
        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            if(index == -1){
                return;
            }
            
            //updateGroupList();
            DBHandler instance = DBHandler.getInstance();
            selectedGroup = instance.getGroup((int)groupsIDs[index]);
            groupToFields();
            ShowSizeLimit();
            groupsSelectElements();
        }

        private void groupToFields()
        {
            groupName.Text = selectedGroup.name;
            isBus.Checked = selectedGroup.isBus;
            isGroup.Checked = !selectedGroup.isBus;
            hasSizeLimit.Checked = selectedGroup.hasSizeLimit;
            if (hasSizeLimit.Checked)
                groupSize.Text = selectedGroup.capacity + "";
            else
                groupSize.Text = "";
        }

        private void clientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addGroupPortable_Click(object sender, EventArgs e)
        {
            if(open){
                return;
            }

            CreateGroup cg = new CreateGroup();
            cg.setTrip(trip, this);
            cg.Show();
            open = true;
            
        }

        private void hasSizeLimit_CheckedChanged(object sender, EventArgs e)
        {
            ShowSizeLimit();
        }

        private void ShowSizeLimit()
        {
            groupSize.Enabled = hasSizeLimit.Checked;
        }

        private void hasGroup_CheckedChanged(object sender, EventArgs e)
        {
            ShowChooseGroup();
        }

        private void hasBus_CheckedChanged(object sender, EventArgs e)
        {
            ShowChooseGroup();
        }

       private void ShowChooseGroup()
        {
            group.Enabled = hasGroup.Checked;
            bus.Enabled = hasBus.Checked;
        }

       private void group_SelectedIndexChanged(object sender, EventArgs e)
       {
           grpIndex = ((ComboBox)sender).SelectedIndex;
       }

       private void bus_SelectedIndexChanged(object sender, EventArgs e)
       {
           busIndex = ((ComboBox)sender).SelectedIndex;
       }

       

    }





    public static class Prompt
    {
        public static string ShowInputDialog(string text, string title)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = title;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }


        public static int ShowConfirmDialog(string text, string title)
        {
            Form prompt = new Form();
            prompt.Width = 200;
            prompt.Height = 150;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = title;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 20, Top = 20, Width = 180, Text = text };
            Button yes = new Button() { Text = "موافق", Left = 20, Width = 60, Top = 70, DialogResult = DialogResult.Yes };
            yes.Click += (sender, e) => { prompt.Close(); };
            Button cancel = new Button() { Text = "رجوع", Left = 100, Width = 60, Top = 70, DialogResult = DialogResult.No };
            cancel.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(yes);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = yes;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.Yes ? 1 : 0;
        }

        public static void ShowWarningDialog(string text, string title)
        {
            Form prompt = new Form();
            prompt.Width = 200;
            prompt.Height = 150;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = title;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            Label textLabel = new Label() { Left = 20, Top = 20, Width = 180, Text = text };
            Button yes = new Button() { Text = "موافق", Left = 20, Width = 60, Top = 70, DialogResult = DialogResult.Yes };
            yes.Click += (sender, e) => { prompt.Close(); };
           
           
            prompt.Controls.Add(yes);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = yes;
   

            prompt.ShowDialog();
        }
    }






}

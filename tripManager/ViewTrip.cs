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
            CenterToScreen();
            clientsDefaults();
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
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

        //public void 


        public void clientsCreateElements()
        {
            clientName.Enabled = true;
            clientPay.Enabled = true;
            clientPhone.Enabled = true;
            group.Enabled = false;
            bus.Enabled = false;
            hasBus.Enabled = true;
            hasGroup.Enabled = true;


            clientDetails.Visible = true;
            searchPanel.Visible = false;

            btnsClientsCreate.Visible = true;
            btnsClientsDoneEdits.Visible = false;
            btnsClientsSelected.Visible = false;
        }

        public void groupsCreateElements()
        {
            groupName.Enabled = true;
            groupSize.Enabled = false;
            hasSizeLimit.Enabled = true;

            isBus.Enabled = true;
            isGroup.Enabled = true;

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
        }

        public void groupsEnableEditElements()
        {
            groupName.Enabled = true;
            hasSizeLimit.Enabled = true;

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

            clientsDefaults();
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
            int promptValue = Prompt.ShowDialog("هل تود بالفعل مسح العميل ؟", "تحذير");
            if(promptValue == 1){
                clientsDefaults();
            }
            else
            {

            }

        }

        private void cancelEdit_Click(object sender, EventArgs e)
        {
            int promptValue = Prompt.ShowDialog("هل تود الرجوع عن التغيرات ؟", "تحذير");
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
            }
        }

        private void cancelCreateGroup_Click(object sender, EventArgs e)
        {
            groupsDefaults();
        }

        private void cancelEditGroup_Click(object sender, EventArgs e)
        {
            groupsDefaults();
        }

        private void cancelEditDoneGroup_Click(object sender, EventArgs e)
        {
            int promptValue = Prompt.ShowDialog("هل تود الرجوع عن التغيرات ؟", "تحذير");
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
            groupsDefaults();
        }

        private void deleteGroup_Click(object sender, EventArgs e)
        {
            int promptValue = Prompt.ShowDialog("هل تود بالفعل مسح المجموعة ؟", "تحذير");
            if (promptValue == 1)
            {
                clientsDefaults();
            }
            else
            {

            }
        }

        private void editGroup_Click(object sender, EventArgs e)
        {
            groupsEnableEditElements();
        }

        private void doneEditGroup_Click(object sender, EventArgs e)
        {
            groupsSelectElements();
        }

        private void addGroup_Click(object sender, EventArgs e)
        {
            groupsCreateElements();
        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupsSelectElements();
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


        public static int ShowDialog(string text, string title)
        {
            Form prompt = new Form();
            prompt.Width = 200;
            prompt.Height = 150;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = title;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 20, Top = 20, Width=180, Text = text };
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
    }






}

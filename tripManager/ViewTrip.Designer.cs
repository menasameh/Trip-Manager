namespace tripManager
{
    partial class ViewTrip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewTripClients = new System.Windows.Forms.DataGridView();
            this.group = new System.Windows.Forms.ComboBox();
            this.bus = new System.Windows.Forms.ComboBox();
            this.hasGroup = new System.Windows.Forms.CheckBox();
            this.hasBus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientDetails = new System.Windows.Forms.Panel();
            this.addGroupPortable = new System.Windows.Forms.Button();
            this.clientID = new System.Windows.Forms.TextBox();
            this.clientPay = new System.Windows.Forms.TextBox();
            this.clientPhone = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tripNotes = new System.Windows.Forms.TextBox();
            this.tripCount = new System.Windows.Forms.Label();
            this.tripPrice = new System.Windows.Forms.TextBox();
            this.tripName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Button();
            this.editClient = new System.Windows.Forms.Button();
            this.addGroup = new System.Windows.Forms.Button();
            this.createClient = new System.Windows.Forms.Button();
            this.cancelCreate = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.btnsClientsCreate = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.cancelSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.byID = new System.Windows.Forms.RadioButton();
            this.byName = new System.Windows.Forms.RadioButton();
            this.edit = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.btnsClientsSelected = new System.Windows.Forms.Panel();
            this.cancelEditClient = new System.Windows.Forms.Button();
            this.doneEdit = new System.Windows.Forms.Button();
            this.cancelEdit = new System.Windows.Forms.Button();
            this.btnsClientsDoneEdits = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.actionButtons = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsGroupDoneEdits = new System.Windows.Forms.Panel();
            this.cancelEditDoneGroup = new System.Windows.Forms.Button();
            this.doneEditGroup = new System.Windows.Forms.Button();
            this.groupDetails = new System.Windows.Forms.Panel();
            this.groupName = new System.Windows.Forms.TextBox();
            this.groupSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.hasSizeLimit = new System.Windows.Forms.CheckBox();
            this.isBus = new System.Windows.Forms.RadioButton();
            this.isGroup = new System.Windows.Forms.RadioButton();
            this.btnsGroupSelected = new System.Windows.Forms.Panel();
            this.deleteGroup = new System.Windows.Forms.Button();
            this.editGroup = new System.Windows.Forms.Button();
            this.cancelEditGroup = new System.Windows.Forms.Button();
            this.btnsGroupCreate = new System.Windows.Forms.Panel();
            this.createGroup = new System.Windows.Forms.Button();
            this.cancelCreateGroup = new System.Windows.Forms.Button();
            this.groupList = new System.Windows.Forms.ComboBox();
            this.changablePrice = new System.Windows.Forms.CheckBox();
            this.tripDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.viewTripClients)).BeginInit();
            this.clientDetails.SuspendLayout();
            this.btnsClientsCreate.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.btnsClientsSelected.SuspendLayout();
            this.btnsClientsDoneEdits.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.actionButtons.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.btnsGroupDoneEdits.SuspendLayout();
            this.groupDetails.SuspendLayout();
            this.btnsGroupSelected.SuspendLayout();
            this.btnsGroupCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewTripClients
            // 
            this.viewTripClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTripClients.Location = new System.Drawing.Point(19, 251);
            this.viewTripClients.Name = "viewTripClients";
            this.viewTripClients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewTripClients.Size = new System.Drawing.Size(664, 138);
            this.viewTripClients.TabIndex = 0;
            // 
            // group
            // 
            this.group.FormattingEnabled = true;
            this.group.Location = new System.Drawing.Point(252, 112);
            this.group.Name = "group";
            this.group.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.group.Size = new System.Drawing.Size(121, 21);
            this.group.TabIndex = 1;
            this.group.SelectedIndexChanged += new System.EventHandler(this.group_SelectedIndexChanged);
            // 
            // bus
            // 
            this.bus.FormattingEnabled = true;
            this.bus.Location = new System.Drawing.Point(62, 112);
            this.bus.Name = "bus";
            this.bus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bus.Size = new System.Drawing.Size(121, 21);
            this.bus.TabIndex = 2;
            this.bus.SelectedIndexChanged += new System.EventHandler(this.bus_SelectedIndexChanged);
            // 
            // hasGroup
            // 
            this.hasGroup.AutoSize = true;
            this.hasGroup.Location = new System.Drawing.Point(312, 89);
            this.hasGroup.Name = "hasGroup";
            this.hasGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hasGroup.Size = new System.Drawing.Size(61, 17);
            this.hasGroup.TabIndex = 3;
            this.hasGroup.Text = "مجموعة";
            this.hasGroup.UseVisualStyleBackColor = true;
            this.hasGroup.CheckedChanged += new System.EventHandler(this.hasGroup_CheckedChanged);
            // 
            // hasBus
            // 
            this.hasBus.AutoSize = true;
            this.hasBus.Location = new System.Drawing.Point(127, 89);
            this.hasBus.Name = "hasBus";
            this.hasBus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hasBus.Size = new System.Drawing.Size(56, 17);
            this.hasBus.TabIndex = 4;
            this.hasBus.Text = "اتوبيس";
            this.hasBus.UseVisualStyleBackColor = true;
            this.hasBus.CheckedChanged += new System.EventHandler(this.hasBus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "الاسم";
            // 
            // clientDetails
            // 
            this.clientDetails.Controls.Add(this.addGroupPortable);
            this.clientDetails.Controls.Add(this.clientID);
            this.clientDetails.Controls.Add(this.clientPay);
            this.clientDetails.Controls.Add(this.clientPhone);
            this.clientDetails.Controls.Add(this.clientName);
            this.clientDetails.Controls.Add(this.label4);
            this.clientDetails.Controls.Add(this.label3);
            this.clientDetails.Controls.Add(this.hasBus);
            this.clientDetails.Controls.Add(this.label2);
            this.clientDetails.Controls.Add(this.hasGroup);
            this.clientDetails.Controls.Add(this.label1);
            this.clientDetails.Controls.Add(this.bus);
            this.clientDetails.Controls.Add(this.group);
            this.clientDetails.Location = new System.Drawing.Point(288, 7);
            this.clientDetails.Name = "clientDetails";
            this.clientDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientDetails.Size = new System.Drawing.Size(393, 182);
            this.clientDetails.TabIndex = 6;
            // 
            // addGroupPortable
            // 
            this.addGroupPortable.Location = new System.Drawing.Point(163, 142);
            this.addGroupPortable.Name = "addGroupPortable";
            this.addGroupPortable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addGroupPortable.Size = new System.Drawing.Size(90, 23);
            this.addGroupPortable.TabIndex = 30;
            this.addGroupPortable.Text = "اضافة مجموعة";
            this.addGroupPortable.UseVisualStyleBackColor = true;
            this.addGroupPortable.Click += new System.EventHandler(this.addGroupPortable_Click);
            // 
            // clientID
            // 
            this.clientID.Enabled = false;
            this.clientID.Location = new System.Drawing.Point(10, 45);
            this.clientID.Name = "clientID";
            this.clientID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientID.Size = new System.Drawing.Size(100, 20);
            this.clientID.TabIndex = 12;
            // 
            // clientPay
            // 
            this.clientPay.Location = new System.Drawing.Point(10, 11);
            this.clientPay.Name = "clientPay";
            this.clientPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientPay.Size = new System.Drawing.Size(100, 20);
            this.clientPay.TabIndex = 11;
            // 
            // clientPhone
            // 
            this.clientPhone.Location = new System.Drawing.Point(203, 46);
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientPhone.Size = new System.Drawing.Size(100, 20);
            this.clientPhone.TabIndex = 10;
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(203, 11);
            this.clientName.Name = "clientName";
            this.clientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientName.Size = new System.Drawing.Size(100, 20);
            this.clientName.TabIndex = 9;
            this.clientName.TextChanged += new System.EventHandler(this.clientName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 46);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "رقم التذكرة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 14);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "المبلغ المدفوع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 46);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "رقم الموبايل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 99);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ملحوظات";
            // 
            // tripNotes
            // 
            this.tripNotes.BackColor = System.Drawing.SystemColors.Control;
            this.tripNotes.Enabled = false;
            this.tripNotes.Location = new System.Drawing.Point(86, 79);
            this.tripNotes.Multiline = true;
            this.tripNotes.Name = "tripNotes";
            this.tripNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripNotes.Size = new System.Drawing.Size(409, 52);
            this.tripNotes.TabIndex = 25;
            this.tripNotes.Text = "\r\n\r\n";
            this.tripNotes.TextChanged += new System.EventHandler(this.manageTripNotes_TextChanged);
            // 
            // tripCount
            // 
            this.tripCount.AutoSize = true;
            this.tripCount.Location = new System.Drawing.Point(180, 39);
            this.tripCount.Name = "tripCount";
            this.tripCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripCount.Size = new System.Drawing.Size(13, 13);
            this.tripCount.TabIndex = 23;
            this.tripCount.Text = "5";
            // 
            // tripPrice
            // 
            this.tripPrice.BackColor = System.Drawing.SystemColors.Control;
            this.tripPrice.Enabled = false;
            this.tripPrice.Location = new System.Drawing.Point(365, 35);
            this.tripPrice.Name = "tripPrice";
            this.tripPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripPrice.Size = new System.Drawing.Size(100, 20);
            this.tripPrice.TabIndex = 22;
            this.tripPrice.TextChanged += new System.EventHandler(this.manageTripPrice_TextChanged);
            // 
            // tripName
            // 
            this.tripName.BackColor = System.Drawing.SystemColors.Control;
            this.tripName.Enabled = false;
            this.tripName.Location = new System.Drawing.Point(365, 10);
            this.tripName.Name = "tripName";
            this.tripName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripName.Size = new System.Drawing.Size(100, 20);
            this.tripName.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 39);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "عدد المشتركين";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 10);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "تاريخ الرحلة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 39);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ثمن الرحلة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 10);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "اسم الرحلة";
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(12, 10);
            this.addClient.Name = "addClient";
            this.addClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addClient.Size = new System.Drawing.Size(90, 23);
            this.addClient.TabIndex = 27;
            this.addClient.Text = "اضافة عميل";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // editClient
            // 
            this.editClient.Location = new System.Drawing.Point(12, 53);
            this.editClient.Name = "editClient";
            this.editClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editClient.Size = new System.Drawing.Size(90, 23);
            this.editClient.TabIndex = 28;
            this.editClient.Text = "تعديل عميل";
            this.editClient.UseVisualStyleBackColor = true;
            this.editClient.Click += new System.EventHandler(this.editClient_Click);
            // 
            // addGroup
            // 
            this.addGroup.Location = new System.Drawing.Point(619, 45);
            this.addGroup.Name = "addGroup";
            this.addGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addGroup.Size = new System.Drawing.Size(90, 23);
            this.addGroup.TabIndex = 29;
            this.addGroup.Text = "اضافة مجموعة";
            this.addGroup.UseVisualStyleBackColor = true;
            this.addGroup.Click += new System.EventHandler(this.addGroup_Click);
            // 
            // createClient
            // 
            this.createClient.Location = new System.Drawing.Point(21, 25);
            this.createClient.Name = "createClient";
            this.createClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.createClient.Size = new System.Drawing.Size(75, 23);
            this.createClient.TabIndex = 30;
            this.createClient.Text = "اضافه";
            this.createClient.UseVisualStyleBackColor = true;
            this.createClient.Click += new System.EventHandler(this.createClient_Click);
            // 
            // cancelCreate
            // 
            this.cancelCreate.Location = new System.Drawing.Point(21, 88);
            this.cancelCreate.Name = "cancelCreate";
            this.cancelCreate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelCreate.Size = new System.Drawing.Size(75, 23);
            this.cancelCreate.TabIndex = 31;
            this.cancelCreate.Text = "رجوع";
            this.cancelCreate.UseVisualStyleBackColor = true;
            this.cancelCreate.Click += new System.EventHandler(this.cancelCreate_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 86);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(52, 23);
            this.Back.TabIndex = 34;
            this.Back.Text = "رجوع";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // btnsClientsCreate
            // 
            this.btnsClientsCreate.Controls.Add(this.cancelCreate);
            this.btnsClientsCreate.Controls.Add(this.createClient);
            this.btnsClientsCreate.Location = new System.Drawing.Point(165, 11);
            this.btnsClientsCreate.Name = "btnsClientsCreate";
            this.btnsClientsCreate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsClientsCreate.Size = new System.Drawing.Size(117, 136);
            this.btnsClientsCreate.TabIndex = 35;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.cancelSearch);
            this.searchPanel.Controls.Add(this.search);
            this.searchPanel.Controls.Add(this.label10);
            this.searchPanel.Controls.Add(this.searchText);
            this.searchPanel.Controls.Add(this.byID);
            this.searchPanel.Controls.Add(this.byName);
            this.searchPanel.Location = new System.Drawing.Point(687, 7);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchPanel.Size = new System.Drawing.Size(307, 147);
            this.searchPanel.TabIndex = 36;
            // 
            // cancelSearch
            // 
            this.cancelSearch.Location = new System.Drawing.Point(52, 99);
            this.cancelSearch.Name = "cancelSearch";
            this.cancelSearch.Size = new System.Drawing.Size(75, 23);
            this.cancelSearch.TabIndex = 42;
            this.cancelSearch.Text = "رجوع";
            this.cancelSearch.UseVisualStyleBackColor = true;
            this.cancelSearch.Click += new System.EventHandler(this.cancelSearch_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(203, 99);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 41;
            this.search.Text = "بحث";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "الاسم";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(17, 45);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(217, 20);
            this.searchText.TabIndex = 39;
            // 
            // byID
            // 
            this.byID.AutoSize = true;
            this.byID.Location = new System.Drawing.Point(65, 14);
            this.byID.Name = "byID";
            this.byID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.byID.Size = new System.Drawing.Size(77, 17);
            this.byID.TabIndex = 38;
            this.byID.TabStop = true;
            this.byID.Text = "رقم التذكرة";
            this.byID.UseVisualStyleBackColor = true;
            // 
            // byName
            // 
            this.byName.AutoSize = true;
            this.byName.Location = new System.Drawing.Point(203, 14);
            this.byName.Name = "byName";
            this.byName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.byName.Size = new System.Drawing.Size(48, 17);
            this.byName.TabIndex = 37;
            this.byName.TabStop = true;
            this.byName.Text = "الاسم";
            this.byName.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(27, 25);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 37;
            this.edit.Text = "تعديل";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Location = new System.Drawing.Point(27, 57);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(75, 23);
            this.deleteClient.TabIndex = 38;
            this.deleteClient.Text = "مسح";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // btnsClientsSelected
            // 
            this.btnsClientsSelected.Controls.Add(this.cancelEditClient);
            this.btnsClientsSelected.Controls.Add(this.edit);
            this.btnsClientsSelected.Controls.Add(this.deleteClient);
            this.btnsClientsSelected.Location = new System.Drawing.Point(689, 162);
            this.btnsClientsSelected.Name = "btnsClientsSelected";
            this.btnsClientsSelected.Size = new System.Drawing.Size(125, 136);
            this.btnsClientsSelected.TabIndex = 39;
            // 
            // cancelEditClient
            // 
            this.cancelEditClient.Location = new System.Drawing.Point(27, 89);
            this.cancelEditClient.Name = "cancelEditClient";
            this.cancelEditClient.Size = new System.Drawing.Size(75, 23);
            this.cancelEditClient.TabIndex = 40;
            this.cancelEditClient.Text = "رجوع";
            this.cancelEditClient.UseVisualStyleBackColor = true;
            this.cancelEditClient.Click += new System.EventHandler(this.cancelEditClient_Click);
            // 
            // doneEdit
            // 
            this.doneEdit.Location = new System.Drawing.Point(22, 25);
            this.doneEdit.Name = "doneEdit";
            this.doneEdit.Size = new System.Drawing.Size(75, 23);
            this.doneEdit.TabIndex = 40;
            this.doneEdit.Text = "تم";
            this.doneEdit.UseVisualStyleBackColor = true;
            this.doneEdit.Click += new System.EventHandler(this.doneEdit_Click);
            // 
            // cancelEdit
            // 
            this.cancelEdit.Location = new System.Drawing.Point(22, 89);
            this.cancelEdit.Name = "cancelEdit";
            this.cancelEdit.Size = new System.Drawing.Size(75, 23);
            this.cancelEdit.TabIndex = 41;
            this.cancelEdit.Text = "رجوع";
            this.cancelEdit.UseVisualStyleBackColor = true;
            this.cancelEdit.Click += new System.EventHandler(this.cancelEdit_Click);
            // 
            // btnsClientsDoneEdits
            // 
            this.btnsClientsDoneEdits.Controls.Add(this.cancelEdit);
            this.btnsClientsDoneEdits.Controls.Add(this.doneEdit);
            this.btnsClientsDoneEdits.Location = new System.Drawing.Point(841, 162);
            this.btnsClientsDoneEdits.Name = "btnsClientsDoneEdits";
            this.btnsClientsDoneEdits.Size = new System.Drawing.Size(125, 136);
            this.btnsClientsDoneEdits.TabIndex = 42;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 131);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 442);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.actionButtons);
            this.tabPage1.Controls.Add(this.btnsClientsDoneEdits);
            this.tabPage1.Controls.Add(this.btnsClientsCreate);
            this.tabPage1.Controls.Add(this.btnsClientsSelected);
            this.tabPage1.Controls.Add(this.clientDetails);
            this.tabPage1.Controls.Add(this.searchPanel);
            this.tabPage1.Controls.Add(this.viewTripClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1020, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "العملاء";
            // 
            // actionButtons
            // 
            this.actionButtons.Controls.Add(this.addClient);
            this.actionButtons.Controls.Add(this.editClient);
            this.actionButtons.Location = new System.Drawing.Point(19, 21);
            this.actionButtons.Name = "actionButtons";
            this.actionButtons.Size = new System.Drawing.Size(118, 93);
            this.actionButtons.TabIndex = 43;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnsGroupDoneEdits);
            this.tabPage2.Controls.Add(this.groupDetails);
            this.tabPage2.Controls.Add(this.btnsGroupSelected);
            this.tabPage2.Controls.Add(this.btnsGroupCreate);
            this.tabPage2.Controls.Add(this.groupList);
            this.tabPage2.Controls.Add(this.addGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1020, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "المجموعات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 150);
            this.dataGridView1.TabIndex = 48;
            // 
            // btnsGroupDoneEdits
            // 
            this.btnsGroupDoneEdits.Controls.Add(this.cancelEditDoneGroup);
            this.btnsGroupDoneEdits.Controls.Add(this.doneEditGroup);
            this.btnsGroupDoneEdits.Location = new System.Drawing.Point(341, 256);
            this.btnsGroupDoneEdits.Name = "btnsGroupDoneEdits";
            this.btnsGroupDoneEdits.Size = new System.Drawing.Size(119, 153);
            this.btnsGroupDoneEdits.TabIndex = 47;
            // 
            // cancelEditDoneGroup
            // 
            this.cancelEditDoneGroup.Location = new System.Drawing.Point(28, 95);
            this.cancelEditDoneGroup.Name = "cancelEditDoneGroup";
            this.cancelEditDoneGroup.Size = new System.Drawing.Size(75, 23);
            this.cancelEditDoneGroup.TabIndex = 1;
            this.cancelEditDoneGroup.Text = "رجوع";
            this.cancelEditDoneGroup.UseVisualStyleBackColor = true;
            this.cancelEditDoneGroup.Click += new System.EventHandler(this.cancelEditDoneGroup_Click);
            // 
            // doneEditGroup
            // 
            this.doneEditGroup.Location = new System.Drawing.Point(28, 19);
            this.doneEditGroup.Name = "doneEditGroup";
            this.doneEditGroup.Size = new System.Drawing.Size(75, 23);
            this.doneEditGroup.TabIndex = 0;
            this.doneEditGroup.Text = "تم";
            this.doneEditGroup.UseVisualStyleBackColor = true;
            this.doneEditGroup.Click += new System.EventHandler(this.doneEditGroup_Click);
            // 
            // groupDetails
            // 
            this.groupDetails.Controls.Add(this.groupName);
            this.groupDetails.Controls.Add(this.groupSize);
            this.groupDetails.Controls.Add(this.label11);
            this.groupDetails.Controls.Add(this.hasSizeLimit);
            this.groupDetails.Controls.Add(this.isBus);
            this.groupDetails.Controls.Add(this.isGroup);
            this.groupDetails.Location = new System.Drawing.Point(637, 89);
            this.groupDetails.Name = "groupDetails";
            this.groupDetails.Size = new System.Drawing.Size(345, 158);
            this.groupDetails.TabIndex = 46;
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(95, 69);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(100, 20);
            this.groupName.TabIndex = 39;
            // 
            // groupSize
            // 
            this.groupSize.Location = new System.Drawing.Point(95, 95);
            this.groupSize.Name = "groupSize";
            this.groupSize.Size = new System.Drawing.Size(100, 20);
            this.groupSize.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "الاسم";
            // 
            // hasSizeLimit
            // 
            this.hasSizeLimit.AutoSize = true;
            this.hasSizeLimit.Location = new System.Drawing.Point(210, 95);
            this.hasSizeLimit.Name = "hasSizeLimit";
            this.hasSizeLimit.Size = new System.Drawing.Size(74, 17);
            this.hasSizeLimit.TabIndex = 36;
            this.hasSizeLimit.Text = "عدد محدود";
            this.hasSizeLimit.UseVisualStyleBackColor = true;
            this.hasSizeLimit.CheckedChanged += new System.EventHandler(this.hasSizeLimit_CheckedChanged);
            // 
            // isBus
            // 
            this.isBus.AutoSize = true;
            this.isBus.Location = new System.Drawing.Point(17, 6);
            this.isBus.Name = "isBus";
            this.isBus.Size = new System.Drawing.Size(55, 17);
            this.isBus.TabIndex = 35;
            this.isBus.TabStop = true;
            this.isBus.Text = "اتوبيس";
            this.isBus.UseVisualStyleBackColor = true;
            // 
            // isGroup
            // 
            this.isGroup.AutoSize = true;
            this.isGroup.Location = new System.Drawing.Point(185, 6);
            this.isGroup.Name = "isGroup";
            this.isGroup.Size = new System.Drawing.Size(60, 17);
            this.isGroup.TabIndex = 34;
            this.isGroup.TabStop = true;
            this.isGroup.Text = "مجموعة";
            this.isGroup.UseVisualStyleBackColor = true;
            // 
            // btnsGroupSelected
            // 
            this.btnsGroupSelected.Controls.Add(this.deleteGroup);
            this.btnsGroupSelected.Controls.Add(this.editGroup);
            this.btnsGroupSelected.Controls.Add(this.cancelEditGroup);
            this.btnsGroupSelected.Location = new System.Drawing.Point(472, 256);
            this.btnsGroupSelected.Name = "btnsGroupSelected";
            this.btnsGroupSelected.Size = new System.Drawing.Size(115, 153);
            this.btnsGroupSelected.TabIndex = 45;
            // 
            // deleteGroup
            // 
            this.deleteGroup.Location = new System.Drawing.Point(22, 63);
            this.deleteGroup.Name = "deleteGroup";
            this.deleteGroup.Size = new System.Drawing.Size(75, 23);
            this.deleteGroup.TabIndex = 44;
            this.deleteGroup.Text = "مسح";
            this.deleteGroup.UseVisualStyleBackColor = true;
            this.deleteGroup.Click += new System.EventHandler(this.deleteGroup_Click);
            // 
            // editGroup
            // 
            this.editGroup.Location = new System.Drawing.Point(22, 17);
            this.editGroup.Name = "editGroup";
            this.editGroup.Size = new System.Drawing.Size(75, 23);
            this.editGroup.TabIndex = 42;
            this.editGroup.Text = "تعديل";
            this.editGroup.UseVisualStyleBackColor = true;
            this.editGroup.Click += new System.EventHandler(this.editGroup_Click);
            // 
            // cancelEditGroup
            // 
            this.cancelEditGroup.Location = new System.Drawing.Point(22, 109);
            this.cancelEditGroup.Name = "cancelEditGroup";
            this.cancelEditGroup.Size = new System.Drawing.Size(75, 23);
            this.cancelEditGroup.TabIndex = 43;
            this.cancelEditGroup.Text = "رجوع";
            this.cancelEditGroup.UseVisualStyleBackColor = true;
            this.cancelEditGroup.Click += new System.EventHandler(this.cancelEditGroup_Click);
            // 
            // btnsGroupCreate
            // 
            this.btnsGroupCreate.Controls.Add(this.createGroup);
            this.btnsGroupCreate.Controls.Add(this.cancelCreateGroup);
            this.btnsGroupCreate.Location = new System.Drawing.Point(472, 97);
            this.btnsGroupCreate.Name = "btnsGroupCreate";
            this.btnsGroupCreate.Size = new System.Drawing.Size(123, 153);
            this.btnsGroupCreate.TabIndex = 41;
            // 
            // createGroup
            // 
            this.createGroup.Location = new System.Drawing.Point(26, 20);
            this.createGroup.Name = "createGroup";
            this.createGroup.Size = new System.Drawing.Size(75, 23);
            this.createGroup.TabIndex = 1;
            this.createGroup.Text = "اضافة";
            this.createGroup.UseVisualStyleBackColor = true;
            this.createGroup.Click += new System.EventHandler(this.createGroup_Click);
            // 
            // cancelCreateGroup
            // 
            this.cancelCreateGroup.Location = new System.Drawing.Point(26, 109);
            this.cancelCreateGroup.Name = "cancelCreateGroup";
            this.cancelCreateGroup.Size = new System.Drawing.Size(75, 23);
            this.cancelCreateGroup.TabIndex = 0;
            this.cancelCreateGroup.Text = "رجوع";
            this.cancelCreateGroup.UseVisualStyleBackColor = true;
            this.cancelCreateGroup.Click += new System.EventHandler(this.cancelCreateGroup_Click);
            // 
            // groupList
            // 
            this.groupList.FormattingEnabled = true;
            this.groupList.Location = new System.Drawing.Point(761, 45);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(121, 21);
            this.groupList.TabIndex = 40;
            this.groupList.SelectedIndexChanged += new System.EventHandler(this.groupList_SelectedIndexChanged);
            // 
            // changablePrice
            // 
            this.changablePrice.AutoSize = true;
            this.changablePrice.Enabled = false;
            this.changablePrice.Location = new System.Drawing.Point(483, 58);
            this.changablePrice.Name = "changablePrice";
            this.changablePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.changablePrice.Size = new System.Drawing.Size(73, 17);
            this.changablePrice.TabIndex = 44;
            this.changablePrice.Text = "سعر متغير";
            this.changablePrice.UseVisualStyleBackColor = true;
            // 
            // tripDate
            // 
            this.tripDate.Enabled = false;
            this.tripDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tripDate.Location = new System.Drawing.Point(135, 7);
            this.tripDate.Name = "tripDate";
            this.tripDate.Size = new System.Drawing.Size(106, 20);
            this.tripDate.TabIndex = 45;
            // 
            // ViewTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 622);
            this.ControlBox = false;
            this.Controls.Add(this.tripDate);
            this.Controls.Add(this.changablePrice);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tripNotes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tripCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tripPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tripName);
            this.Controls.Add(this.label6);
            this.Name = "ViewTrip";
            this.Text = "ViewTrip";
            this.Load += new System.EventHandler(this.ViewTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewTripClients)).EndInit();
            this.clientDetails.ResumeLayout(false);
            this.clientDetails.PerformLayout();
            this.btnsClientsCreate.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.btnsClientsSelected.ResumeLayout(false);
            this.btnsClientsDoneEdits.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.actionButtons.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.btnsGroupDoneEdits.ResumeLayout(false);
            this.groupDetails.ResumeLayout(false);
            this.groupDetails.PerformLayout();
            this.btnsGroupSelected.ResumeLayout(false);
            this.btnsGroupCreate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        
        #endregion

        private System.Windows.Forms.DataGridView viewTripClients;
        private System.Windows.Forms.ComboBox group;
        private System.Windows.Forms.ComboBox bus;
        private System.Windows.Forms.CheckBox hasGroup;
        private System.Windows.Forms.CheckBox hasBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel clientDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientID;
        private System.Windows.Forms.TextBox clientPay;
        private System.Windows.Forms.TextBox clientPhone;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tripNotes;
        private System.Windows.Forms.Label tripCount;
        private System.Windows.Forms.TextBox tripPrice;
        private System.Windows.Forms.TextBox tripName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button editClient;
        private System.Windows.Forms.Button addGroup;
        private System.Windows.Forms.Button createClient;
        private System.Windows.Forms.Button cancelCreate;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel btnsClientsCreate;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.RadioButton byID;
        private System.Windows.Forms.RadioButton byName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button cancelSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Panel btnsClientsSelected;
        private System.Windows.Forms.Button cancelEditClient;
        private System.Windows.Forms.Button doneEdit;
        private System.Windows.Forms.Button cancelEdit;
        private System.Windows.Forms.Panel btnsClientsDoneEdits;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel btnsGroupSelected;
        private System.Windows.Forms.Button deleteGroup;
        private System.Windows.Forms.Button editGroup;
        private System.Windows.Forms.Button cancelEditGroup;
        private System.Windows.Forms.Panel btnsGroupCreate;
        private System.Windows.Forms.Button createGroup;
        private System.Windows.Forms.Button cancelCreateGroup;
        private System.Windows.Forms.ComboBox groupList;
        private System.Windows.Forms.TextBox groupName;
        private System.Windows.Forms.TextBox groupSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox hasSizeLimit;
        private System.Windows.Forms.RadioButton isBus;
        private System.Windows.Forms.RadioButton isGroup;
        private System.Windows.Forms.Panel groupDetails;
        private System.Windows.Forms.Panel btnsGroupDoneEdits;
        private System.Windows.Forms.Button cancelEditDoneGroup;
        private System.Windows.Forms.Button doneEditGroup;
        private System.Windows.Forms.Button addGroupPortable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox changablePrice;
        private System.Windows.Forms.DateTimePicker tripDate;
        private System.Windows.Forms.Panel actionButtons;
    }
}
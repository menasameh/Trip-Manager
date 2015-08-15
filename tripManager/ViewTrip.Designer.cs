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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.tripDate = new System.Windows.Forms.TextBox();
            this.editGroup = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.byID = new System.Windows.Forms.RadioButton();
            this.byName = new System.Windows.Forms.RadioButton();
            this.edit = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancelEditClient = new System.Windows.Forms.Button();
            this.doneEdit = new System.Windows.Forms.Button();
            this.cancelEdit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.viewTripClients)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewTripClients
            // 
            this.viewTripClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTripClients.Location = new System.Drawing.Point(12, 301);
            this.viewTripClients.Name = "viewTripClients";
            this.viewTripClients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewTripClients.Size = new System.Drawing.Size(651, 150);
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
            // 
            // bus
            // 
            this.bus.FormattingEnabled = true;
            this.bus.Location = new System.Drawing.Point(62, 112);
            this.bus.Name = "bus";
            this.bus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bus.Size = new System.Drawing.Size(121, 21);
            this.bus.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.clientID);
            this.panel1.Controls.Add(this.clientPay);
            this.panel1.Controls.Add(this.clientPhone);
            this.panel1.Controls.Add(this.clientName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.hasBus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hasGroup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bus);
            this.panel1.Controls.Add(this.group);
            this.panel1.Location = new System.Drawing.Point(270, 148);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(393, 147);
            this.panel1.TabIndex = 6;
            // 
            // clientID
            // 
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
            this.label5.Location = new System.Drawing.Point(586, 101);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ملحوظات";
            // 
            // tripNotes
            // 
            this.tripNotes.BackColor = System.Drawing.SystemColors.Control;
            this.tripNotes.Location = new System.Drawing.Point(171, 85);
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
            this.tripCount.Location = new System.Drawing.Point(256, 42);
            this.tripCount.Name = "tripCount";
            this.tripCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripCount.Size = new System.Drawing.Size(13, 13);
            this.tripCount.TabIndex = 23;
            this.tripCount.Text = "5";
            // 
            // tripPrice
            // 
            this.tripPrice.BackColor = System.Drawing.SystemColors.Control;
            this.tripPrice.Location = new System.Drawing.Point(441, 42);
            this.tripPrice.Name = "tripPrice";
            this.tripPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripPrice.Size = new System.Drawing.Size(100, 20);
            this.tripPrice.TabIndex = 22;
            this.tripPrice.TextChanged += new System.EventHandler(this.manageTripPrice_TextChanged);
            // 
            // tripName
            // 
            this.tripName.BackColor = System.Drawing.SystemColors.Control;
            this.tripName.Location = new System.Drawing.Point(441, 9);
            this.tripName.Name = "tripName";
            this.tripName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripName.Size = new System.Drawing.Size(100, 20);
            this.tripName.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 42);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "عدد المشتركين";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 9);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "تاريخ الرحلة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 43);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ثمن الرحلة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(572, 9);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "اسم الرحلة";
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(29, 32);
            this.addClient.Name = "addClient";
            this.addClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addClient.Size = new System.Drawing.Size(90, 23);
            this.addClient.TabIndex = 27;
            this.addClient.Text = "اضافة عميل";
            this.addClient.UseVisualStyleBackColor = true;
            // 
            // editClient
            // 
            this.editClient.Location = new System.Drawing.Point(29, 76);
            this.editClient.Name = "editClient";
            this.editClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editClient.Size = new System.Drawing.Size(90, 23);
            this.editClient.TabIndex = 28;
            this.editClient.Text = "تعديل عميل";
            this.editClient.UseVisualStyleBackColor = true;
            // 
            // addGroup
            // 
            this.addGroup.Location = new System.Drawing.Point(29, 120);
            this.addGroup.Name = "addGroup";
            this.addGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addGroup.Size = new System.Drawing.Size(90, 23);
            this.addGroup.TabIndex = 29;
            this.addGroup.Text = "اضافة مجموعة";
            this.addGroup.UseVisualStyleBackColor = true;
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
            // 
            // tripDate
            // 
            this.tripDate.BackColor = System.Drawing.SystemColors.Control;
            this.tripDate.Location = new System.Drawing.Point(207, 6);
            this.tripDate.Name = "tripDate";
            this.tripDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripDate.Size = new System.Drawing.Size(100, 20);
            this.tripDate.TabIndex = 32;
            // 
            // editGroup
            // 
            this.editGroup.Location = new System.Drawing.Point(29, 164);
            this.editGroup.Name = "editGroup";
            this.editGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editGroup.Size = new System.Drawing.Size(90, 23);
            this.editGroup.TabIndex = 33;
            this.editGroup.Text = "تعديل مجموعة";
            this.editGroup.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(29, 208);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(90, 23);
            this.Back.TabIndex = 34;
            this.Back.Text = "رجوع";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelCreate);
            this.panel2.Controls.Add(this.createClient);
            this.panel2.Location = new System.Drawing.Point(128, 159);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(117, 136);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cancelSearch);
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.searchText);
            this.panel3.Controls.Add(this.byID);
            this.panel3.Controls.Add(this.byName);
            this.panel3.Location = new System.Drawing.Point(758, 42);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(307, 147);
            this.panel3.TabIndex = 36;
            // 
            // cancelSearch
            // 
            this.cancelSearch.Location = new System.Drawing.Point(52, 99);
            this.cancelSearch.Name = "cancelSearch";
            this.cancelSearch.Size = new System.Drawing.Size(75, 23);
            this.cancelSearch.TabIndex = 42;
            this.cancelSearch.Text = "رجوع";
            this.cancelSearch.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(203, 99);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 41;
            this.search.Text = "بحث";
            this.search.UseVisualStyleBackColor = true;
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
            // 
            // deleteClient
            // 
            this.deleteClient.Location = new System.Drawing.Point(27, 57);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(75, 23);
            this.deleteClient.TabIndex = 38;
            this.deleteClient.Text = "مسح";
            this.deleteClient.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cancelEditClient);
            this.panel4.Controls.Add(this.edit);
            this.panel4.Controls.Add(this.deleteClient);
            this.panel4.Location = new System.Drawing.Point(758, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 136);
            this.panel4.TabIndex = 39;
            // 
            // cancelEditClient
            // 
            this.cancelEditClient.Location = new System.Drawing.Point(27, 89);
            this.cancelEditClient.Name = "cancelEditClient";
            this.cancelEditClient.Size = new System.Drawing.Size(75, 23);
            this.cancelEditClient.TabIndex = 40;
            this.cancelEditClient.Text = "رجوع";
            this.cancelEditClient.UseVisualStyleBackColor = true;
            // 
            // doneEdit
            // 
            this.doneEdit.Location = new System.Drawing.Point(22, 25);
            this.doneEdit.Name = "doneEdit";
            this.doneEdit.Size = new System.Drawing.Size(75, 23);
            this.doneEdit.TabIndex = 40;
            this.doneEdit.Text = "تم";
            this.doneEdit.UseVisualStyleBackColor = true;
            // 
            // cancelEdit
            // 
            this.cancelEdit.Location = new System.Drawing.Point(22, 89);
            this.cancelEdit.Name = "cancelEdit";
            this.cancelEdit.Size = new System.Drawing.Size(75, 23);
            this.cancelEdit.TabIndex = 41;
            this.cancelEdit.Text = "رجوع";
            this.cancelEdit.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cancelEdit);
            this.panel5.Controls.Add(this.doneEdit);
            this.panel5.Location = new System.Drawing.Point(940, 247);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 136);
            this.panel5.TabIndex = 42;
            // 
            // ViewTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 463);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.editGroup);
            this.Controls.Add(this.tripDate);
            this.Controls.Add(this.addGroup);
            this.Controls.Add(this.editClient);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tripNotes);
            this.Controls.Add(this.viewTripClients);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TextBox tripDate;
        private System.Windows.Forms.Button editGroup;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton byID;
        private System.Windows.Forms.RadioButton byName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button cancelSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cancelEditClient;
        private System.Windows.Forms.Button doneEdit;
        private System.Windows.Forms.Button cancelEdit;
        private System.Windows.Forms.Panel panel5;
    }
}
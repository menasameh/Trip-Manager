namespace tripManager
{
    partial class manageTrip
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tripName = new System.Windows.Forms.TextBox();
            this.tripPrice = new System.Windows.Forms.TextBox();
            this.tripCount = new System.Windows.Forms.Label();
            this.tripDate = new System.Windows.Forms.DateTimePicker();
            this.manageTripEdit = new System.Windows.Forms.Button();
            this.manageTripDelete = new System.Windows.Forms.Button();
            this.manageTripFreeze = new System.Windows.Forms.Button();
            this.manageTripBack = new System.Windows.Forms.Button();
            this.basicContols = new System.Windows.Forms.Panel();
            this.editEndControls = new System.Windows.Forms.Panel();
            this.manageTripCancel = new System.Windows.Forms.Button();
            this.manageTripDone = new System.Windows.Forms.Button();
            this.tripNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.manageTripCreate = new System.Windows.Forms.Button();
            this.manageTripBack2 = new System.Windows.Forms.Button();
            this.createControls = new System.Windows.Forms.Panel();
            this.changablePrice = new System.Windows.Forms.CheckBox();
            this.basicContols.SuspendLayout();
            this.editEndControls.SuspendLayout();
            this.createControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الرحلة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 56);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ثمن الرحلة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 22);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ الرحلة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 55);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "عدد المشتركين";
            // 
            // tripName
            // 
            this.tripName.Location = new System.Drawing.Point(315, 22);
            this.tripName.Name = "tripName";
            this.tripName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripName.Size = new System.Drawing.Size(100, 20);
            this.tripName.TabIndex = 6;
            // 
            // tripPrice
            // 
            this.tripPrice.Location = new System.Drawing.Point(315, 55);
            this.tripPrice.Name = "tripPrice";
            this.tripPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripPrice.Size = new System.Drawing.Size(100, 20);
            this.tripPrice.TabIndex = 7;
            // 
            // tripCount
            // 
            this.tripCount.AutoSize = true;
            this.tripCount.Location = new System.Drawing.Point(130, 55);
            this.tripCount.Name = "tripCount";
            this.tripCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripCount.Size = new System.Drawing.Size(13, 13);
            this.tripCount.TabIndex = 8;
            this.tripCount.Text = "5";
            // 
            // tripDate
            // 
            this.tripDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tripDate.Location = new System.Drawing.Point(81, 19);
            this.tripDate.Name = "tripDate";
            this.tripDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripDate.Size = new System.Drawing.Size(112, 20);
            this.tripDate.TabIndex = 9;
            // 
            // manageTripEdit
            // 
            this.manageTripEdit.Location = new System.Drawing.Point(355, 7);
            this.manageTripEdit.Name = "manageTripEdit";
            this.manageTripEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manageTripEdit.Size = new System.Drawing.Size(100, 50);
            this.manageTripEdit.TabIndex = 10;
            this.manageTripEdit.Text = "تعديل";
            this.manageTripEdit.UseVisualStyleBackColor = true;
            this.manageTripEdit.Click += new System.EventHandler(this.manageTripEdit_Click);
            // 
            // manageTripDelete
            // 
            this.manageTripDelete.Location = new System.Drawing.Point(241, 7);
            this.manageTripDelete.Name = "manageTripDelete";
            this.manageTripDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manageTripDelete.Size = new System.Drawing.Size(100, 50);
            this.manageTripDelete.TabIndex = 11;
            this.manageTripDelete.Text = "حذف";
            this.manageTripDelete.UseVisualStyleBackColor = true;
            this.manageTripDelete.Click += new System.EventHandler(this.manageTripDelete_Click);
            // 
            // manageTripFreeze
            // 
            this.manageTripFreeze.Location = new System.Drawing.Point(122, 7);
            this.manageTripFreeze.Name = "manageTripFreeze";
            this.manageTripFreeze.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manageTripFreeze.Size = new System.Drawing.Size(100, 50);
            this.manageTripFreeze.TabIndex = 12;
            this.manageTripFreeze.Text = "تجميد";
            this.manageTripFreeze.UseVisualStyleBackColor = true;
            this.manageTripFreeze.Click += new System.EventHandler(this.manageTripFreeze_Click);
            // 
            // manageTripBack
            // 
            this.manageTripBack.Location = new System.Drawing.Point(11, 7);
            this.manageTripBack.Name = "manageTripBack";
            this.manageTripBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manageTripBack.Size = new System.Drawing.Size(100, 50);
            this.manageTripBack.TabIndex = 13;
            this.manageTripBack.Text = "رجوع";
            this.manageTripBack.UseVisualStyleBackColor = true;
            this.manageTripBack.Click += new System.EventHandler(this.manageTripBack_Click);
            // 
            // basicContols
            // 
            this.basicContols.Controls.Add(this.manageTripBack);
            this.basicContols.Controls.Add(this.manageTripFreeze);
            this.basicContols.Controls.Add(this.manageTripDelete);
            this.basicContols.Controls.Add(this.manageTripEdit);
            this.basicContols.Location = new System.Drawing.Point(26, 167);
            this.basicContols.Name = "basicContols";
            this.basicContols.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.basicContols.Size = new System.Drawing.Size(470, 68);
            this.basicContols.TabIndex = 14;
            // 
            // editEndControls
            // 
            this.editEndControls.Controls.Add(this.manageTripCancel);
            this.editEndControls.Controls.Add(this.manageTripDone);
            this.editEndControls.Location = new System.Drawing.Point(133, 325);
            this.editEndControls.Name = "editEndControls";
            this.editEndControls.Size = new System.Drawing.Size(247, 67);
            this.editEndControls.TabIndex = 17;
            this.editEndControls.Visible = false;
            // 
            // manageTripCancel
            // 
            this.manageTripCancel.Location = new System.Drawing.Point(14, 8);
            this.manageTripCancel.Name = "manageTripCancel";
            this.manageTripCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manageTripCancel.Size = new System.Drawing.Size(100, 50);
            this.manageTripCancel.TabIndex = 16;
            this.manageTripCancel.Text = "رجوع";
            this.manageTripCancel.UseVisualStyleBackColor = true;
            this.manageTripCancel.Click += new System.EventHandler(this.manageTripCancel_Click);
            // 
            // manageTripDone
            // 
            this.manageTripDone.Location = new System.Drawing.Point(133, 8);
            this.manageTripDone.Name = "manageTripDone";
            this.manageTripDone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manageTripDone.Size = new System.Drawing.Size(100, 50);
            this.manageTripDone.TabIndex = 15;
            this.manageTripDone.Text = "تم";
            this.manageTripDone.UseVisualStyleBackColor = true;
            this.manageTripDone.Click += new System.EventHandler(this.manageTripDone_Click);
            // 
            // tripNotes
            // 
            this.tripNotes.Location = new System.Drawing.Point(45, 98);
            this.tripNotes.Multiline = true;
            this.tripNotes.Name = "tripNotes";
            this.tripNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tripNotes.Size = new System.Drawing.Size(409, 52);
            this.tripNotes.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ملحوظات";
            // 
            // manageTripCreate
            // 
            this.manageTripCreate.Location = new System.Drawing.Point(133, 12);
            this.manageTripCreate.Name = "manageTripCreate";
            this.manageTripCreate.Size = new System.Drawing.Size(100, 50);
            this.manageTripCreate.TabIndex = 17;
            this.manageTripCreate.Text = "اضافه";
            this.manageTripCreate.UseVisualStyleBackColor = true;
            this.manageTripCreate.Click += new System.EventHandler(this.manageTripCreate_Click);
            // 
            // manageTripBack2
            // 
            this.manageTripBack2.Location = new System.Drawing.Point(14, 12);
            this.manageTripBack2.Name = "manageTripBack2";
            this.manageTripBack2.Size = new System.Drawing.Size(100, 50);
            this.manageTripBack2.TabIndex = 18;
            this.manageTripBack2.Text = "رجوع";
            this.manageTripBack2.UseVisualStyleBackColor = true;
            this.manageTripBack2.Click += new System.EventHandler(this.manageTripBack2_Click);
            // 
            // createControls
            // 
            this.createControls.Controls.Add(this.manageTripBack2);
            this.createControls.Controls.Add(this.manageTripCreate);
            this.createControls.Location = new System.Drawing.Point(133, 251);
            this.createControls.Name = "createControls";
            this.createControls.Size = new System.Drawing.Size(247, 68);
            this.createControls.TabIndex = 19;
            this.createControls.Visible = false;
            // 
            // changablePrice
            // 
            this.changablePrice.AutoSize = true;
            this.changablePrice.Location = new System.Drawing.Point(435, 79);
            this.changablePrice.Name = "changablePrice";
            this.changablePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.changablePrice.Size = new System.Drawing.Size(73, 17);
            this.changablePrice.TabIndex = 20;
            this.changablePrice.Text = "سعر متغير";
            this.changablePrice.UseVisualStyleBackColor = true;
            // 
            // manageTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 395);
            this.ControlBox = false;
            this.Controls.Add(this.changablePrice);
            this.Controls.Add(this.createControls);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tripNotes);
            this.Controls.Add(this.basicContols);
            this.Controls.Add(this.editEndControls);
            this.Controls.Add(this.tripDate);
            this.Controls.Add(this.tripCount);
            this.Controls.Add(this.tripPrice);
            this.Controls.Add(this.tripName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "manageTrip";
            this.Text = "ادارة رحلة";
            this.Load += new System.EventHandler(this.manageTrip_Load);
            this.basicContols.ResumeLayout(false);
            this.editEndControls.ResumeLayout(false);
            this.createControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tripName;
        private System.Windows.Forms.TextBox tripPrice;
        private System.Windows.Forms.Label tripCount;
        private System.Windows.Forms.DateTimePicker tripDate;
        private System.Windows.Forms.Button manageTripEdit;
        private System.Windows.Forms.Button manageTripDelete;
        private System.Windows.Forms.Button manageTripFreeze;
        private System.Windows.Forms.Button manageTripBack;
        private System.Windows.Forms.Panel basicContols;
        private System.Windows.Forms.Button manageTripDone;
        private System.Windows.Forms.Button manageTripCancel;
        private System.Windows.Forms.Panel editEndControls;
        private System.Windows.Forms.TextBox tripNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button manageTripCreate;
        private System.Windows.Forms.Button manageTripBack2;
        private System.Windows.Forms.Panel createControls;
        private System.Windows.Forms.CheckBox changablePrice;
    }
}
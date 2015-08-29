namespace tripManager
{
    partial class CreateGroup
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
            this.groupName = new System.Windows.Forms.TextBox();
            this.groupSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.hasSizeLimit = new System.Windows.Forms.CheckBox();
            this.isBus = new System.Windows.Forms.RadioButton();
            this.isGroup = new System.Windows.Forms.RadioButton();
            this.create = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(56, 54);
            this.groupName.Name = "groupName";
            this.groupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupName.Size = new System.Drawing.Size(100, 20);
            this.groupName.TabIndex = 39;
            // 
            // groupSize
            // 
            this.groupSize.Location = new System.Drawing.Point(56, 80);
            this.groupSize.Name = "groupSize";
            this.groupSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupSize.Size = new System.Drawing.Size(100, 20);
            this.groupSize.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 54);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "الاسم";
            // 
            // hasSizeLimit
            // 
            this.hasSizeLimit.AutoSize = true;
            this.hasSizeLimit.Location = new System.Drawing.Point(171, 80);
            this.hasSizeLimit.Name = "hasSizeLimit";
            this.hasSizeLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hasSizeLimit.Size = new System.Drawing.Size(74, 17);
            this.hasSizeLimit.TabIndex = 36;
            this.hasSizeLimit.Text = "عدد محدود";
            this.hasSizeLimit.UseVisualStyleBackColor = true;
            this.hasSizeLimit.CheckedChanged += new System.EventHandler(this.hasSizeLimit_CheckedChanged);
            // 
            // isBus
            // 
            this.isBus.AutoSize = true;
            this.isBus.Location = new System.Drawing.Point(27, 25);
            this.isBus.Name = "isBus";
            this.isBus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isBus.Size = new System.Drawing.Size(55, 17);
            this.isBus.TabIndex = 35;
            this.isBus.TabStop = true;
            this.isBus.Text = "اتوبيس";
            this.isBus.UseVisualStyleBackColor = true;
            // 
            // isGroup
            // 
            this.isGroup.AutoSize = true;
            this.isGroup.Location = new System.Drawing.Point(170, 25);
            this.isGroup.Name = "isGroup";
            this.isGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isGroup.Size = new System.Drawing.Size(60, 17);
            this.isGroup.TabIndex = 34;
            this.isGroup.TabStop = true;
            this.isGroup.Text = "مجموعة";
            this.isGroup.UseVisualStyleBackColor = true;
            // 
            // create
            // 
            this.create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.create.Location = new System.Drawing.Point(170, 127);
            this.create.Name = "create";
            this.create.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 1;
            this.create.Text = "اضافة";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(7, 127);
            this.cancel.Name = "cancel";
            this.cancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "رجوع";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 167);
            this.ControlBox = false;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.isGroup);
            this.Controls.Add(this.groupSize);
            this.Controls.Add(this.isBus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.hasSizeLimit);
            this.Name = "CreateGroup";
            this.Text = "CreateGroup";
            this.Load += new System.EventHandler(this.CreateGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox groupName;
        private System.Windows.Forms.TextBox groupSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox hasSizeLimit;
        private System.Windows.Forms.RadioButton isBus;
        private System.Windows.Forms.RadioButton isGroup;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cancel;
    }
}
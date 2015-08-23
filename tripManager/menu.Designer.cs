namespace tripManager
{
    partial class menu
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
            this.manageTrip = new System.Windows.Forms.Button();
            this.selectTrip = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.tripChooserCreate = new System.Windows.Forms.Button();
            this.tripChooserList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manageTrip
            // 
            this.manageTrip.Enabled = false;
            this.manageTrip.Location = new System.Drawing.Point(12, 76);
            this.manageTrip.Name = "manageTrip";
            this.manageTrip.Size = new System.Drawing.Size(100, 50);
            this.manageTrip.TabIndex = 0;
            this.manageTrip.Text = "ادارة رحلة";
            this.manageTrip.UseVisualStyleBackColor = true;
            this.manageTrip.Click += new System.EventHandler(this.manageTrip_Click);
            // 
            // selectTrip
            // 
            this.selectTrip.Enabled = false;
            this.selectTrip.Location = new System.Drawing.Point(121, 76);
            this.selectTrip.Name = "selectTrip";
            this.selectTrip.Size = new System.Drawing.Size(100, 50);
            this.selectTrip.TabIndex = 1;
            this.selectTrip.Text = "اختيار رحلة";
            this.selectTrip.UseVisualStyleBackColor = true;
            this.selectTrip.Click += new System.EventHandler(this.selectTrip_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(339, 76);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 50);
            this.exit.TabIndex = 2;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tripChooserCreate
            // 
            this.tripChooserCreate.Location = new System.Drawing.Point(230, 76);
            this.tripChooserCreate.Name = "tripChooserCreate";
            this.tripChooserCreate.Size = new System.Drawing.Size(100, 50);
            this.tripChooserCreate.TabIndex = 8;
            this.tripChooserCreate.Text = "انشاء رحله جديده";
            this.tripChooserCreate.UseVisualStyleBackColor = true;
            this.tripChooserCreate.Click += new System.EventHandler(this.tripChooserCreate_Click);
            // 
            // tripChooserList
            // 
            this.tripChooserList.FormattingEnabled = true;
            this.tripChooserList.Items.AddRange(new object[] {
            "رحلة 1",
            "رحلة 2"});
            this.tripChooserList.Location = new System.Drawing.Point(136, 43);
            this.tripChooserList.Name = "tripChooserList";
            this.tripChooserList.Size = new System.Drawing.Size(192, 21);
            this.tripChooserList.TabIndex = 5;
            this.tripChooserList.SelectedIndexChanged += new System.EventHandler(this.tripChooserList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "اختر الرحلة";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 148);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tripChooserCreate);
            this.Controls.Add(this.tripChooserList);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.selectTrip);
            this.Controls.Add(this.manageTrip);
            this.Name = "menu";
            this.Text = "ادارة الرحلات";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageTrip;
        private System.Windows.Forms.Button selectTrip;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button tripChooserCreate;
        private System.Windows.Forms.ComboBox tripChooserList;
        private System.Windows.Forms.Label label1;
    }
}


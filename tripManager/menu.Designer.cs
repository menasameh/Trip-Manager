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
            this.SuspendLayout();
            // 
            // manageTrip
            // 
            this.manageTrip.Location = new System.Drawing.Point(36, 60);
            this.manageTrip.Name = "manageTrip";
            this.manageTrip.Size = new System.Drawing.Size(100, 50);
            this.manageTrip.TabIndex = 0;
            this.manageTrip.Text = "ادارة رحلة";
            this.manageTrip.UseVisualStyleBackColor = true;
            this.manageTrip.Click += new System.EventHandler(this.manageTrip_Click);
            // 
            // selectTrip
            // 
            this.selectTrip.Location = new System.Drawing.Point(177, 60);
            this.selectTrip.Name = "selectTrip";
            this.selectTrip.Size = new System.Drawing.Size(100, 50);
            this.selectTrip.TabIndex = 1;
            this.selectTrip.Text = "اختيار رحلة";
            this.selectTrip.UseVisualStyleBackColor = true;
            this.selectTrip.Click += new System.EventHandler(this.selectTrip_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(318, 60);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 50);
            this.exit.TabIndex = 2;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 185);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.selectTrip);
            this.Controls.Add(this.manageTrip);
            this.Name = "menu";
            this.Text = "ادارة الرحلات";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageTrip;
        private System.Windows.Forms.Button selectTrip;
        private System.Windows.Forms.Button exit;
    }
}


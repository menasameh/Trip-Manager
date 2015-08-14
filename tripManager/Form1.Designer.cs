namespace tripManager
{
    partial class Form1
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
            this.manageTrip.Location = new System.Drawing.Point(47, 81);
            this.manageTrip.Name = "manageTrip";
            this.manageTrip.Size = new System.Drawing.Size(75, 23);
            this.manageTrip.TabIndex = 0;
            this.manageTrip.Text = "ادارة رحلة";
            this.manageTrip.UseVisualStyleBackColor = true;
            // 
            // selectTrip
            // 
            this.selectTrip.Location = new System.Drawing.Point(188, 81);
            this.selectTrip.Name = "selectTrip";
            this.selectTrip.Size = new System.Drawing.Size(75, 23);
            this.selectTrip.TabIndex = 1;
            this.selectTrip.Text = "اختيار رحلة";
            this.selectTrip.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(329, 81);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 185);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.selectTrip);
            this.Controls.Add(this.manageTrip);
            this.Name = "Form1";
            this.Text = "ادارة الرحلات";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageTrip;
        private System.Windows.Forms.Button selectTrip;
        private System.Windows.Forms.Button exit;
    }
}


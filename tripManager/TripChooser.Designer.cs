namespace tripManager
{
    partial class TripChooser
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
            this.tripChooserList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tripChooserSelect = new System.Windows.Forms.Button();
            this.tripChooserBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tripChooserList
            // 
            this.tripChooserList.FormattingEnabled = true;
            this.tripChooserList.Location = new System.Drawing.Point(47, 61);
            this.tripChooserList.Name = "tripChooserList";
            this.tripChooserList.Size = new System.Drawing.Size(192, 21);
            this.tripChooserList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "قم باختيار الرحلة";
            // 
            // tripChooserSelect
            // 
            this.tripChooserSelect.Location = new System.Drawing.Point(47, 122);
            this.tripChooserSelect.Name = "tripChooserSelect";
            this.tripChooserSelect.Size = new System.Drawing.Size(75, 23);
            this.tripChooserSelect.TabIndex = 2;
            this.tripChooserSelect.Text = "اختار";
            this.tripChooserSelect.UseVisualStyleBackColor = true;
            // 
            // tripChooserBack
            // 
            this.tripChooserBack.Location = new System.Drawing.Point(164, 122);
            this.tripChooserBack.Name = "tripChooserBack";
            this.tripChooserBack.Size = new System.Drawing.Size(75, 23);
            this.tripChooserBack.TabIndex = 3;
            this.tripChooserBack.Text = "رجوع";
            this.tripChooserBack.UseVisualStyleBackColor = true;
            // 
            // TripChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.tripChooserBack);
            this.Controls.Add(this.tripChooserSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tripChooserList);
            this.Name = "TripChooser";
            this.Text = "TripChooser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tripChooserList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tripChooserSelect;
        private System.Windows.Forms.Button tripChooserBack;
    }
}
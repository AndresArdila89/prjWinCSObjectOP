namespace prjWinCSObjectOP
{
    partial class frmStrucToClass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lblMinute = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.btnDisplayUniversal = new System.Windows.Forms.Button();
            this.btnDisplayStandard = new System.Windows.Forms.Button();
            this.lblStandard = new System.Windows.Forms.TextBox();
            this.lblUniversal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "APPOINTMENTS - MANAGEMENT";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtSeconds);
            this.groupBox1.Controls.Add(this.lblSecond);
            this.groupBox1.Controls.Add(this.txtMinutes);
            this.groupBox1.Controls.Add(this.lblMinute);
            this.groupBox1.Controls.Add(this.txtHour);
            this.groupBox1.Controls.Add(this.lblHour);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Appointment";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(113, 123);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 32);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create or Adjust";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtSeconds
            // 
            this.txtSeconds.ForeColor = System.Drawing.Color.Red;
            this.txtSeconds.Location = new System.Drawing.Point(113, 90);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(128, 20);
            this.txtSeconds.TabIndex = 7;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(15, 93);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(92, 13);
            this.lblSecond.TabIndex = 6;
            this.lblSecond.Text = "Enter Second :";
            // 
            // txtMinutes
            // 
            this.txtMinutes.ForeColor = System.Drawing.Color.Red;
            this.txtMinutes.Location = new System.Drawing.Point(113, 61);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(128, 20);
            this.txtMinutes.TabIndex = 5;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(15, 65);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(87, 13);
            this.lblMinute.TabIndex = 4;
            this.lblMinute.Text = "Enter Minute :";
            // 
            // txtHour
            // 
            this.txtHour.ForeColor = System.Drawing.Color.Red;
            this.txtHour.Location = new System.Drawing.Point(113, 33);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(128, 20);
            this.txtHour.TabIndex = 3;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(15, 37);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(76, 13);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "Enter Hour :";
            // 
            // btnDisplayUniversal
            // 
            this.btnDisplayUniversal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayUniversal.Location = new System.Drawing.Point(342, 186);
            this.btnDisplayUniversal.Name = "btnDisplayUniversal";
            this.btnDisplayUniversal.Size = new System.Drawing.Size(146, 32);
            this.btnDisplayUniversal.TabIndex = 10;
            this.btnDisplayUniversal.Text = "Display in Universal >>";
            this.btnDisplayUniversal.UseVisualStyleBackColor = true;
            this.btnDisplayUniversal.Click += new System.EventHandler(this.btnDisplayUniversal_Click);
            // 
            // btnDisplayStandard
            // 
            this.btnDisplayStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayStandard.Location = new System.Drawing.Point(342, 224);
            this.btnDisplayStandard.Name = "btnDisplayStandard";
            this.btnDisplayStandard.Size = new System.Drawing.Size(146, 32);
            this.btnDisplayStandard.TabIndex = 11;
            this.btnDisplayStandard.Text = "Display in Standard >>";
            this.btnDisplayStandard.UseVisualStyleBackColor = true;
            this.btnDisplayStandard.Click += new System.EventHandler(this.btnDisplayStandard_Click);
            // 
            // lblStandard
            // 
            this.lblStandard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStandard.Location = new System.Drawing.Point(508, 231);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(122, 20);
            this.lblStandard.TabIndex = 13;
            // 
            // lblUniversal
            // 
            this.lblUniversal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUniversal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUniversal.Location = new System.Drawing.Point(508, 193);
            this.lblUniversal.Name = "lblUniversal";
            this.lblUniversal.Size = new System.Drawing.Size(122, 20);
            this.lblUniversal.TabIndex = 12;
            // 
            // frmStrucToClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 372);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.lblUniversal);
            this.Controls.Add(this.btnDisplayStandard);
            this.Controls.Add(this.btnDisplayUniversal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmStrucToClass";
            this.Text = "frmStrucToClass";
            this.Load += new System.EventHandler(this.frmStrucToClass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnDisplayUniversal;
        private System.Windows.Forms.Button btnDisplayStandard;
        private System.Windows.Forms.TextBox lblStandard;
        private System.Windows.Forms.TextBox lblUniversal;
    }
}
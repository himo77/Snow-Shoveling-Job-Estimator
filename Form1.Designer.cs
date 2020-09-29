namespace Snow_Shoveling_Job_Estimator
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dteAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCorner = new System.Windows.Forms.RadioButton();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSpecialRequests = new System.Windows.Forms.Label();
            this.btnAddSpecialRequests = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetEstimate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(326, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(527, 31);
            this.txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(326, 96);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(527, 31);
            this.txtAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Requested";
            // 
            // dteAppointmentDate
            // 
            this.dteAppointmentDate.Location = new System.Drawing.Point(326, 187);
            this.dteAppointmentDate.Name = "dteAppointmentDate";
            this.dteAppointmentDate.Size = new System.Drawing.Size(526, 31);
            this.dteAppointmentDate.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCorner);
            this.groupBox1.Controls.Add(this.rdoSingle);
            this.groupBox1.Location = new System.Drawing.Point(46, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Sidewalk";
            // 
            // rdoCorner
            // 
            this.rdoCorner.AutoSize = true;
            this.rdoCorner.Location = new System.Drawing.Point(7, 95);
            this.rdoCorner.Name = "rdoCorner";
            this.rdoCorner.Size = new System.Drawing.Size(108, 29);
            this.rdoCorner.TabIndex = 1;
            this.rdoCorner.Text = "Corner";
            this.rdoCorner.UseVisualStyleBackColor = true;
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Checked = true;
            this.rdoSingle.Location = new System.Drawing.Point(6, 43);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(103, 29);
            this.rdoSingle.TabIndex = 0;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "Single";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSpecialRequests);
            this.groupBox2.Location = new System.Drawing.Point(503, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 152);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Special Requests";
            // 
            // lblSpecialRequests
            // 
            this.lblSpecialRequests.AutoEllipsis = true;
            this.lblSpecialRequests.Location = new System.Drawing.Point(21, 61);
            this.lblSpecialRequests.Name = "lblSpecialRequests";
            this.lblSpecialRequests.Size = new System.Drawing.Size(285, 29);
            this.lblSpecialRequests.TabIndex = 0;
            this.lblSpecialRequests.Text = "No special requests entered";
            // 
            // btnAddSpecialRequests
            // 
            this.btnAddSpecialRequests.Location = new System.Drawing.Point(529, 499);
            this.btnAddSpecialRequests.Name = "btnAddSpecialRequests";
            this.btnAddSpecialRequests.Size = new System.Drawing.Size(324, 53);
            this.btnAddSpecialRequests.TabIndex = 4;
            this.btnAddSpecialRequests.Text = "Add special requests";
            this.btnAddSpecialRequests.UseVisualStyleBackColor = true;
            this.btnAddSpecialRequests.Click += new System.EventHandler(this.btnAddSpecialRequests_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(597, 617);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(253, 31);
            this.txtPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 623);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estimated Price";
            // 
            // btnGetEstimate
            // 
            this.btnGetEstimate.Location = new System.Drawing.Point(100, 617);
            this.btnGetEstimate.Name = "btnGetEstimate";
            this.btnGetEstimate.Size = new System.Drawing.Size(180, 46);
            this.btnGetEstimate.TabIndex = 5;
            this.btnGetEstimate.Text = "Get Estimate";
            this.btnGetEstimate.UseVisualStyleBackColor = true;
            this.btnGetEstimate.Click += new System.EventHandler(this.btnGetEstimate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 710);
            this.Controls.Add(this.btnGetEstimate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAddSpecialRequests);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dteAppointmentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dteAppointmentDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSpecialRequests;
        private System.Windows.Forms.Button btnAddSpecialRequests;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoCorner;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.Button btnGetEstimate;
    }
}


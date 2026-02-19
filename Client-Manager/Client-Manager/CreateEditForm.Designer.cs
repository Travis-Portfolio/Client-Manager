namespace Client_Manager
{
    partial class CreateEditForm
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
            lbTitle = new Label();
            label1 = new Label();
            lbID = new Label();
            label2 = new Label();
            tbFirstName = new TextBox();
            label3 = new Label();
            tbLastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbAddress = new TextBox();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI", 16F);
            lbTitle.Location = new Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(776, 50);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Create Client";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 82);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Client ID";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(241, 82);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 20);
            lbID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 141);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(241, 134);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(348, 27);
            tbFirstName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 193);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(241, 190);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(348, 27);
            tbLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 248);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 302);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 8;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 358);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 9;
            label6.Text = "Address";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(241, 351);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(348, 27);
            tbAddress.TabIndex = 10;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(241, 302);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(348, 27);
            tbPhone.TabIndex = 11;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(241, 245);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(348, 27);
            tbEmail.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(241, 419);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(354, 419);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbEmail);
            Controls.Add(tbPhone);
            Controls.Add(tbAddress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbLastName);
            Controls.Add(label3);
            Controls.Add(tbFirstName);
            Controls.Add(label2);
            Controls.Add(lbID);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Name = "CreateEditForm";
            Text = "Create Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label1;
        private Label lbID;
        private Label label2;
        private TextBox tbFirstName;
        private Label label3;
        private TextBox tbLastName;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbAddress;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private Button btnSave;
        private Button btnCancel;
    }
}
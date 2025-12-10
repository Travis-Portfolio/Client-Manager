namespace Client_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAddClient = new Button();
            btnDeleteClient = new Button();
            btnEditClient = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(794, 41);
            label1.TabIndex = 0;
            label1.Text = "Clients List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(12, 98);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(94, 29);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteClient.Location = new Point(662, 98);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(124, 29);
            btnDeleteClient.TabIndex = 2;
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnEditClient
            // 
            btnEditClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditClient.Location = new Point(358, 98);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(94, 29);
            btnEditClient.TabIndex = 3;
            btnEditClient.Text = "Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(771, 305);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnEditClient);
            Controls.Add(btnDeleteClient);
            Controls.Add(btnAddClient);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Clients Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAddClient;
        private Button btnDeleteClient;
        private Button btnEditClient;
        private DataGridView dataGridView1;
    }
}

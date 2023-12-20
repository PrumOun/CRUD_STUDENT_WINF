namespace ListStudent
{
    partial class Creating
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
            gbCreating = new GroupBox();
            btAdd = new Button();
            cbCgender = new ComboBox();
            tbCage = new TextBox();
            tbCname = new TextBox();
            tbCno = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbCreating.SuspendLayout();
            SuspendLayout();
            // 
            // gbCreating
            // 
            gbCreating.BackColor = SystemColors.ActiveCaption;
            gbCreating.Controls.Add(btAdd);
            gbCreating.Controls.Add(cbCgender);
            gbCreating.Controls.Add(tbCage);
            gbCreating.Controls.Add(tbCname);
            gbCreating.Controls.Add(tbCno);
            gbCreating.Controls.Add(label4);
            gbCreating.Controls.Add(label3);
            gbCreating.Controls.Add(label2);
            gbCreating.Controls.Add(label1);
            gbCreating.Location = new Point(12, 12);
            gbCreating.Name = "gbCreating";
            gbCreating.Size = new Size(261, 174);
            gbCreating.TabIndex = 4;
            gbCreating.TabStop = false;
            gbCreating.Text = "Creating";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(174, 139);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(84, 31);
            btAdd.TabIndex = 9;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            // 
            // cbCgender
            // 
            cbCgender.FormattingEnabled = true;
            cbCgender.Items.AddRange(new object[] { "Male", "Female" });
            cbCgender.Location = new Point(75, 92);
            cbCgender.Name = "cbCgender";
            cbCgender.Size = new Size(154, 28);
            cbCgender.TabIndex = 8;
            // 
            // tbCage
            // 
            tbCage.Location = new Point(75, 132);
            tbCage.Name = "tbCage";
            tbCage.Size = new Size(46, 27);
            tbCage.TabIndex = 7;
            // 
            // tbCname
            // 
            tbCname.Location = new Point(75, 56);
            tbCname.Name = "tbCname";
            tbCname.Size = new Size(154, 27);
            tbCname.TabIndex = 6;
            // 
            // tbCno
            // 
            tbCno.Location = new Point(75, 19);
            tbCno.Name = "tbCno";
            tbCno.Size = new Size(154, 27);
            tbCno.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 139);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 100);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "No";
            // 
            // Creating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 198);
            Controls.Add(gbCreating);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Creating";
            Text = "Creating";
            Load += Creating_Load;
            gbCreating.ResumeLayout(false);
            gbCreating.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCreating;
        private Button btAdd;
        private ComboBox cbCgender;
        private TextBox tbCage;
        private TextBox tbCname;
        private TextBox tbCno;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
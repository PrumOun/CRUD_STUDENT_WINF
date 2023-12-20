namespace ListStudent
{
    partial class Edit
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
            gbEdit = new GroupBox();
            btUpdate = new Button();
            cbEgender = new ComboBox();
            tbEage = new TextBox();
            tbEname = new TextBox();
            tbEno = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbEdit.SuspendLayout();
            SuspendLayout();
            // 
            // gbEdit
            // 
            gbEdit.BackColor = SystemColors.ActiveCaption;
            gbEdit.Controls.Add(btUpdate);
            gbEdit.Controls.Add(cbEgender);
            gbEdit.Controls.Add(tbEage);
            gbEdit.Controls.Add(tbEname);
            gbEdit.Controls.Add(tbEno);
            gbEdit.Controls.Add(label4);
            gbEdit.Controls.Add(label3);
            gbEdit.Controls.Add(label2);
            gbEdit.Controls.Add(label1);
            gbEdit.Location = new Point(12, 12);
            gbEdit.Name = "gbEdit";
            gbEdit.Size = new Size(261, 174);
            gbEdit.TabIndex = 5;
            gbEdit.TabStop = false;
            gbEdit.Text = "Edit";
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(174, 139);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(84, 31);
            btUpdate.TabIndex = 9;
            btUpdate.Text = "update";
            btUpdate.UseVisualStyleBackColor = true;
            // 
            // cbEgender
            // 
            cbEgender.FormattingEnabled = true;
            cbEgender.Items.AddRange(new object[] { "Male", "Female" });
            cbEgender.Location = new Point(75, 92);
            cbEgender.Name = "cbEgender";
            cbEgender.Size = new Size(154, 28);
            cbEgender.TabIndex = 8;
            // 
            // tbEage
            // 
            tbEage.Location = new Point(75, 132);
            tbEage.Name = "tbEage";
            tbEage.Size = new Size(46, 27);
            tbEage.TabIndex = 7;
            // 
            // tbEname
            // 
            tbEname.Location = new Point(75, 56);
            tbEname.Name = "tbEname";
            tbEname.Size = new Size(154, 27);
            tbEname.TabIndex = 6;
            // 
            // tbEno
            // 
            tbEno.Location = new Point(75, 19);
            tbEno.Name = "tbEno";
            tbEno.Size = new Size(154, 27);
            tbEno.TabIndex = 4;
            tbEno.TextChanged += tbCno_TextChanged;
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
            // Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 198);
            Controls.Add(gbEdit);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Edit";
            Text = "Edit";
            Load += Edit_Load;
            gbEdit.ResumeLayout(false);
            gbEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbEdit;
        private Button btUpdate;
        private ComboBox cbEgender;
        private TextBox tbEage;
        private TextBox tbEname;
        private TextBox tbEno;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
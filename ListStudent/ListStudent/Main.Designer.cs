namespace ListStudent
{
    partial class Main
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
            btReload = new Button();
            btDelete = new Button();
            grvStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
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
            groupBox1 = new GroupBox();
            cbEgender = new ComboBox();
            btUpdate = new Button();
            tbEage = new TextBox();
            tbEname = new TextBox();
            tbEno = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btEdit = new Button();
            btCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)grvStudent).BeginInit();
            gbCreating.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btReload
            // 
            btReload.Location = new Point(658, 63);
            btReload.Name = "btReload";
            btReload.Size = new Size(92, 35);
            btReload.TabIndex = 0;
            btReload.Text = "Reload";
            btReload.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(658, 292);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(92, 35);
            btDelete.TabIndex = 1;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            // 
            // grvStudent
            // 
            grvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            grvStudent.Location = new Point(12, 63);
            grvStudent.Name = "grvStudent";
            grvStudent.RowHeadersWidth = 51;
            grvStudent.RowTemplate.Height = 29;
            grvStudent.Size = new Size(554, 349);
            grvStudent.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Gender";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Sex";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
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
            gbCreating.Location = new Point(250, 177);
            gbCreating.Name = "gbCreating";
            gbCreating.Size = new Size(258, 170);
            gbCreating.TabIndex = 3;
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
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(cbEgender);
            groupBox1.Controls.Add(btUpdate);
            groupBox1.Controls.Add(tbEage);
            groupBox1.Controls.Add(tbEname);
            groupBox1.Controls.Add(tbEno);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(47, 277);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 170);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit";
            // 
            // cbEgender
            // 
            cbEgender.FormattingEnabled = true;
            cbEgender.Items.AddRange(new object[] { "Male", "Female" });
            cbEgender.Location = new Point(75, 92);
            cbEgender.Name = "cbEgender";
            cbEgender.Size = new Size(154, 28);
            cbEgender.TabIndex = 11;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(174, 139);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(84, 31);
            btUpdate.TabIndex = 10;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 139);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 3;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 63);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 2;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 100);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 1;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 26);
            label8.Name = "label8";
            label8.Size = new Size(29, 20);
            label8.TabIndex = 0;
            label8.Text = "No";
            // 
            // btEdit
            // 
            btEdit.Location = new Point(658, 214);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(92, 35);
            btEdit.TabIndex = 10;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(658, 140);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(92, 35);
            btCreate.TabIndex = 11;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(839, 482);
            Controls.Add(btCreate);
            Controls.Add(btEdit);
            Controls.Add(groupBox1);
            Controls.Add(gbCreating);
            Controls.Add(grvStudent);
            Controls.Add(btDelete);
            Controls.Add(btReload);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Manage Student";
            ((System.ComponentModel.ISupportInitialize)grvStudent).EndInit();
            gbCreating.ResumeLayout(false);
            gbCreating.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btReload;
        private Button btDelete;
        private DataGridView grvStudent;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox gbCreating;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbCage;
        private TextBox tbCname;
        private TextBox tbCno;
        private ComboBox cbCgender;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private TextBox tbEage;
        private TextBox tbEname;
        private TextBox tbEno;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btAdd;
        private Button btUpdate;
        private ComboBox cbEgender;
        private Button btEdit;
        private Button btCreate;
    }
}
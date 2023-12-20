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
            btEdit = new Button();
            btCreate = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grvStudent).BeginInit();
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
            Column4.HeaderText = "Age";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(839, 482);
            Controls.Add(btEdit);
            Controls.Add(grvStudent);
            Controls.Add(btDelete);
            Controls.Add(btReload);
            Controls.Add(btCreate);
            MaximizeBox = false;
            Name = "Main";
            Text = "Manage Student";
            ((System.ComponentModel.ISupportInitialize)grvStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btReload;
        private Button btDelete;
        private DataGridView grvStudent;
        private ComboBox comboBox2;
        private Button btEdit;
        private Button btCreate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
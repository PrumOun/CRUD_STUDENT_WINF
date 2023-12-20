using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListStudent
{
    public partial class Edit : Form
    {
        People? _student = null;
        public Edit(People? student)
        {
            InitializeComponent();
            _student = student;
            viewStudent();
            btUpdate.Click += BtUpdate_Click;
        }

        private void BtUpdate_Click(object? sender, EventArgs e)
        {
            if ((int.TryParse(tbEno.Text, out int no) == false) || (tbEname.Text.Length == 0) || (cbEgender.Text.Length == 0) || (tbEage.Text.Length == 0))
            {
                MessageBox.Show("Invalid information", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            } 

            _student = Program._student.FirstOrDefault(x => x.No == no);
            if (_student == null)
            {
                MessageBox.Show($"No student with number, {no}", "Updating",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            _student.No = no;
            _student.Name = tbEname.Text;
            _student.Gender = cbEgender.Text;
            _student.Age = int.Parse(tbEage.Text);

            StuUpdated?.Invoke(this, _student);
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void viewStudent()
        {
            tbEno.Text = _student?.No.ToString();
            tbEname.Text = _student?.Name;
            cbEgender.Text = _student?.Gender;
            tbEage.Text = _student?.Age.ToString();
        }

        private void tbCno_TextChanged(object sender, EventArgs e)
        {

        }
        public event StudentEventHandler? StuUpdated;
    }
}

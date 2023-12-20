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
    public partial class Creating : Form
    {
        public Creating()
        {
            InitializeComponent();
            btAdd.Click += BtAdd_Click;
        }

        private void BtAdd_Click(object? sender, EventArgs e)
        {
            if ((tbCno.Text.Length == 0) || (tbCname.Text.Length == 0) || (cbCgender.Text.Length == 0) || (tbCage.Text.Length == 0))
            {
                MessageBox.Show("Invalid information", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            string info = $"{tbCno.Text}/{tbCname.Text}/{cbCgender.Text}/{tbCage.Text}";

            People? p = People.createInstance(info);
            Program._student.Add(p!);
            tbCno.Text = "";
            tbCname.Text = "";
            cbCgender.Text = "";
            tbCage.Text = "";
            StuCreated?.Invoke(this, p!);
        }

        private void Creating_Load(object sender, EventArgs e)
        {

        }

        public event StudentEventHandler? StuCreated;
    }
}

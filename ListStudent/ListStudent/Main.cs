using System.Windows.Forms;

namespace ListStudent
{
    public partial class Main : Form
    {
        private List<People> _student = new();
        public Main()
        {
            InitializeComponent();
            foreach (People student in Program._student)
            {
                grvStudent.Rows.Add(student.No, student.Name, student.Gender, student.Age);
            }
            ConfigView();
            btReload.Click += BtReload_Click;
            btDelete.Click += BtDelete_Click;
            btCreate.Click += BtCreate_Click;
            btEdit.Click += BtEdit_Click;
        
        }

        private void BtEdit_Click(object? sender, EventArgs e)
        {
            People? found = null;
            if (grvStudent.CurrentRow != null)
            {
                int no = (int)grvStudent.CurrentRow.Cells[0].Value;
                found = Program._student.FirstOrDefault(x => x.No == no);
                if (found != null) _student.Add(found);
            }

            Edit frm = new(found);
            frm.StuUpdated += (sender, stud) =>
            {
                foreach (DataGridViewRow data in grvStudent.Rows)
                {
                    if (found?.No == (int)data.Cells[0].Value)
                    {
                        data.SetValues(found.No, found.Name, found.Gender, found.Age);
                        break;
                    }
                }
            };
            if (found != null)
            {
                frm.FormClosed += (sender, e) => { _student.Remove(found); };
            }
            frm.Show();
        }

        private void BtCreate_Click(object? sender, EventArgs e)
        {
            Creating frm = new Creating();
            frm.StuCreated += (sender, stud) =>
            {
                grvStudent.Rows.Add(stud.No, stud.Name, stud.Gender, stud.Age);
            };
            frm.Show();
        }

        private void BtDelete_Click(object? sender, EventArgs e)
        {
            if (grvStudent.CurrentRow == null) return;
            int no = (int)grvStudent.CurrentRow.Cells[0].Value;
            People? found = Program._student.FirstOrDefault(s => s.No == no);
            if (found != null)
            {
                var result = MessageBox.Show($"Are you sure to delete a student no, {no}?", "Deleting",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Program._student.Remove(found);
                    grvStudent.Rows.Remove(grvStudent.CurrentRow);
                }
            }
            else return;
        }

        private void BtReload_Click(object? sender, EventArgs e)
        {
            grvStudent.Rows.Clear();
            foreach (People student in Program._student)
            {
                grvStudent.Rows.Add(student.No, student.Name, student.Gender, student.Age);
            }
        }

        private void ConfigView()
        {
            foreach (DataGridViewColumn column in grvStudent.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (column.Index == 0) continue;
                column.DefaultCellStyle.Format = "N2";
            }
        }

    }
}
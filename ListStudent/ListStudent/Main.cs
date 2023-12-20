namespace ListStudent
{
    public partial class Main : Form
    {
        List<People> _student = new List<People>();
        public Main()
        {
            InitializeComponent();
            LoadStudent("people.txt");

            btReload.Click += BtReload_Click;
            ConfigView();

            btDelete.Click += BtDelete_Click;
            btAdd.Click += BtAdd_Click;
            grvStudent.SelectionChanged += GrvStudent_SelectionChanged;
            btUpdate.Click += BtUpdate_Click;

        }

        private void GrvStudent_SelectionChanged(object? sender, EventArgs e)
        {
            if (grvStudent.CurrentRow != null)
            {
                int no = (int)grvStudent.CurrentRow.Cells[0].Value;
                People? found = _student.FirstOrDefault(x => x.No == no);
                if (found != null)
                {
                    tbEno.Text = found.No.ToString();
                    tbEname.Text = found.Name;
                    cbEgender.Text = found.Gender;
                    tbEage.Text = found.Age.ToString();
                }
                else return;
            }
            else return;
        }

        private void BtUpdate_Click(object? sender, EventArgs e)
        {

            if ((tbEno.Text.Length == 0) || (tbEname.Text.Length == 0) || (cbEgender.Text.Length == 0) || (tbEage.Text.Length == 0))
            {
                MessageBox.Show("Invalid information", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            int no = int.Parse(tbEno.Text);
            People? found = _student.FirstOrDefault(x => x.No == no);
            if (found != null)
            {
                found.No = no;
                found.Name = tbEname.Text;
                found.Gender = cbEgender.Text;
                found.Age = int.Parse(tbEage.Text);

                foreach (DataGridViewRow data in grvStudent.Rows)
                {
                    if (no == (int)data.Cells[0].Value)
                    {
                        data.SetValues(found.No, found.Name, found.Gender, found.Age);
                        break;
                    }
                }
            }
            else return;
        }

        private void BtAdd_Click(object? sender, EventArgs e)
        {
            if ((tbCno.Text.Length == 0) || (tbCname.Text.Length == 0) || (cbCgender.Text.Length == 0) || (tbCage.Text.Length == 0))
            {
                MessageBox.Show("Invalid information", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            String info = $"{tbCno.Text}/{tbCname.Text}/{cbCgender.Text}/{tbCage.Text}";

            People p = People.createInstance(info);
            _student.Add(p);
            grvStudent.Rows.Add(p.No, p.Name, p.Gender, p.Age);
        }

        private void BtDelete_Click(object? sender, EventArgs e)
        {
            if (grvStudent.CurrentRow == null) return;
            int no = (int)grvStudent.CurrentRow.Cells[0].Value;
            People? found = _student.FirstOrDefault(s => s.No == no);
            if (found != null)
            {
                var result = MessageBox.Show($"Are you sure to delete a student no, {no}?", "Deleting",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _student.Remove(found);
                    grvStudent.Rows.Remove(grvStudent.CurrentRow);
                }
            }
            else return;
        }

        private void BtReload_Click(object? sender, EventArgs e)
        {
            grvStudent.Rows.Clear();
            _student.ForEach(s =>
            {
                grvStudent.Rows.Add(s.No, s.Name, s.Gender, s.Age);
            });
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
        private void LoadStudent(String fileName)
        {
            _student.Clear();
            String[] allLines = File.ReadAllLines(fileName);
            foreach (String line in allLines)
            {
                _student.Add(People.createInstance(line));
            }
        }


    }
}
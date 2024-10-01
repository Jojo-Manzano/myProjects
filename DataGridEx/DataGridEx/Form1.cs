using System.Windows.Forms;

namespace DataGridEx
{
    public partial class Form1 : Form
    {
        Boolean Chk = true;
        int BegLine = 0;
        int EndLine = 0;
        int NoPage = 1;
        int NoLine = 10;
        int LastLine = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaycontent();
            show_chkBox();
        }
        private void displaycontent()
        {
            dataGridView1.Rows.Add(false, "00001", "Jonathan", "Jonathan", "58", "Male", "jojomanzano@yahoo.com", "5879666130");
            dataGridView1.Rows.Add(false, "00002", "Mark", "Mark", "29", "Male", "markmanzano@yahoo.com", "5879666212");
            dataGridView1.Rows.Add(false, "00003", "Martin", "Martin", "26", "Male", "martinmanzano@yahoo.com", "5879666131");
            dataGridView1.Rows.Add(false, "00004", "Christian", "Christian", "31", "Male", "christianmanzano@yahoo.com", "5879666210");
            dataGridView1.Rows.Add(false, "00005", "Jojo", "Jojo", "58", "Male", "jojomanzano@yahoo.com", "5879666130");
            dataGridView1.Rows.Add(false, "00006", "Marcos", "Marcos", "29", "Male", "markmanzano@yahoo.com", "5879666212");
            dataGridView1.Rows.Add(false, "00007", "Tintin", "Tintin", "26", "Male", "martinmanzano@yahoo.com", "5879666131");
            dataGridView1.Rows.Add(false, "00008", "Chris", "Chris", "31", "Male", "christianmanzano@yahoo.com", "5879666210");
            dataGridView1.Rows.Add(false, "00009", "Jonathan", "Jonathan", "58", "Male", "jojomanzano@yahoo.com", "5879666130");
            dataGridView1.Rows.Add(false, "00010", "Mark", "Mark", "29", "Male", "markmanzano@yahoo.com", "5879666212");
            dataGridView1.Rows.Add(false, "00011", "Martin", "Martin", "26", "Male", "martinmanzano@yahoo.com", "5879666131");
            dataGridView1.Rows.Add(false, "00012", "Christian", "Christian", "31", "Male", "christianmanzano@yahoo.com", "5879666210");
            dataGridView1.Rows.Add(false, "00013", "Jojo", "Jojo", "58", "Male", "jojomanzano@yahoo.com", "5879666130");
            dataGridView1.Rows.Add(false, "00014", "Marcos", "Marcos", "29", "Male", "markmanzano@yahoo.com", "5879666212");
            dataGridView1.Rows.Add(false, "00015", "Tintin", "Tintin", "26", "Male", "martinmanzano@yahoo.com", "5879666131");
            dataGridView1.Rows.Add(false, "00016", "Chris", "Chris", "31", "Male", "christianmanzano@yahoo.com", "5879666210");
            dataGridView1.Rows.Add(false, "00017", "Jonathan", "Jonathan", "58", "Male", "jojomanzano@yahoo.com", "5879666130");
            dataGridView1.Rows.Add(false, "00018", "Mark", "Mark", "29", "Male", "markmanzano@yahoo.com", "5879666212");
            dataGridView1.Rows.Add(false, "00019", "Martin", "Martin", "26", "Male", "martinmanzano@yahoo.com", "5879666131");
            dataGridView1.Rows.Add(false, "00020", "Christian", "Christian", "31", "Male", "christianmanzano@yahoo.com", "5879666210");
            dataGridView1.Rows.Add(false, "00021", "Jojo", "Jojo", "58", "Male", "jojomanzano@yahoo.com", "5879666130");
            dataGridView1.Rows.Add(false, "00022", "Marcos", "Marcos", "29", "Male", "markmanzano@yahoo.com", "5879666212");
            dataGridView1.Rows.Add(false, "00023", "Tintin", "Tintin", "26", "Male", "martinmanzano@yahoo.com", "5879666131");
            dataGridView1.Rows.Add(false, "00024", "Chris", "Chris", "31", "Male", "christianmanzano@yahoo.com", "5879666210");

            for (int i = 0; i < dataGridView1.Rows.Count; i = i + 2)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            }
            for (int i = 1; i < dataGridView1.Rows.Count; i = i + 2)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
            }

        }
        private void show_chkBox()
        {
            Rectangle rect = dataGridView1.GetCellDisplayRectangle(0, -1, true);

            rect.Y = 12;
            rect.X = rect.Location.X + ((rect.Width / 3) + 10);
            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Name = "Member";

            checkboxHeader.Size = new Size(18, 18);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
            dataGridView1.Controls.Add(checkboxHeader);

        }
        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox headerBox = ((CheckBox)dataGridView1.Controls.Find("checkboxHeader", true)[0])

            if (Chk)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Member"].Value != null)
                        row.Cells["Member"].Value = true;
                }
                Chk = false;
            }
            else Chk = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Search = txtSearch.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["First"].Value != null)
                {
                    string SFirst = row.Cells["First"].Value.ToString().ToLower();
                    if (SFirst.Contains(Search))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Member"].Value != null)
                {
                    bool value = (bool)row.Cells["Member"].Value;
                    Boolean rowDel = value;
                    if (rowDel == true)
                    {
                        dataGridView1.Rows.Remove(row);
                        break;
                    }
                }
            }
        }
        private void MakeInvisible()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Member"].Value != null)
                {
                    row.Visible = false;
                }
            }
        }
        private void btnBeg_Click(object sender, EventArgs e)
        {

            MakeInvisible();
            NoPage = 1;
            EndLine = NoPage * NoLine;
            for (int i = 0; i < EndLine; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }

        }

        private void btnRew_Click(object sender, EventArgs e)
        {
            if (NoPage > 1)
            {
                MakeInvisible();
                NoPage--;
                BegLine = ((NoPage - 1) * NoLine);
                EndLine = NoPage * NoLine;
                for (int i = BegLine; i < EndLine; i++)
                {
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > NoLine)
            {
                MakeInvisible();
                LastLine = dataGridView1.Rows.Count;
                BegLine = NoPage * NoLine;
                NoPage++;
                EndLine = NoPage * NoLine;
                if (EndLine > LastLine)
                {
                    EndLine = LastLine;
                }
                for (int i = BegLine; i < EndLine; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            MakeInvisible();
            if (dataGridView1.Rows.Count > NoLine)
            {
                LastLine = dataGridView1.RowCount;
                int Comp = Convert.ToInt32(LastLine / NoLine);
                NoPage = Comp;
                BegLine = NoPage * NoLine;
                NoPage++;
                EndLine = NoPage * NoLine;
                if (EndLine > LastLine)
                {
                    EndLine = LastLine;
                }
                for (int i = BegLine; i < EndLine; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }

            }
        }
    }
}

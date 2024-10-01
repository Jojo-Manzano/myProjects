namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var To = dtpTo.Value;
            var From = dtpFrom.Value;
            var Diff = From - To;
            MessageBox.Show ("Difference in Timespan: {0}", Diff);
        }
    }
}

using System.Linq.Expressions;
using System.Windows.Forms;

namespace DateTime
{
    public partial class Form1 : Form
    {
        Boolean Test = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string To = dtpTo.Text;
            string From = dtpFrom.Text;

            var Diff = dtpFrom.Value - dtpTo.Value;
            string DateDiff = Diff.Days.ToString();
            int HourDiff = 0;
            HourDiff = Diff.Days * 24;


            MessageBox.Show("Difference between " + From + " " + To + " is " + DateDiff + " Days");
            MessageBox.Show("Difference between " + From + " " + To + " is " + HourDiff + " Hours");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string DOW = "";

            string DOWeek = "";
            var BDAte = dtpBDate.Value;
            DOW = dtpBDate.Value.DayOfWeek.ToString();

            MessageBox.Show("Your Birthdate DAY is " + DOW);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test = false;
            dtpDate.CustomFormat = " ";
            dtpDate.Format = DateTimePickerFormat.Custom;


            cmbCountry.Items.Clear();
            cmbCountry.Items.Add("Canada");
            cmbCountry.Items.Add("USA");
            cmbCountry.Items.Add("France");
            cmbCountry.Items.Add("Germany");
            cmbCountry.Items.Add("Serbia");

            cmbCountry.Items.Insert(0, "Select Country");
            cmbCountry.Text = "Select Country";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTimePicker DateTime = new DateTimePicker();
            lblDateTime.Text = dtpDateTime.Value.ToString("d-MMM-yyyy hh:mm:ss tt");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Test == false)
            {
                lblMsg.Text = "Please choose a DATE.";
            }
            else
            {
                lblMsg.Text = "Date has been SUBMITTED.";
            }

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDate.CustomFormat = "MMMM dd yyyy";
            dtpDate.Format = DateTimePickerFormat.Custom;
            lblMsg.Text = "";
            Test = true;
        }
    }
}

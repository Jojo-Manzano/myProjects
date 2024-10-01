using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DateTime
{

    public partial class DateSearch : Form
    {
        Dictionary<string, string> Flight = new Dictionary<string, string>();
        public DateSearch()
        {
            InitializeComponent();
        }

        private void DateSearch_Load(object sender, EventArgs e)
        {
            Flight.Clear();
            Flight.Add("YYC-AMS", "Aug-28-2024");
            Flight.Add("YYC-AMS", "Aug-29-2024");
            Flight.Add("YYC-AMS", "Aug-30-2024");
            Flight.Add("YYC-AMS", "Sep-01-2024");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime From = dtpFrom.Value;
            DateTime To = dtpTo.Value;
            From.CustomFormat = "MMM-dd-yyyy";
            From.Format = DateTimePickerFormat.Custom;
            To.CustomFormat = "MMM-dd-yyyy";
            To.Format = DateTimePickerFormat.Custom;
            foreach (var FLT in Flight)
            {
                
                if (FLT.Value >= From && FLT.Value <= To)
                    {
                    MessageBox.Show(FLT.Value);
                    }
            }
            
        }
    }
}

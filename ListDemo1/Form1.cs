using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListDemo1
{
    public partial class timeZones : Form
    {
        public timeZones()
        {
            InitializeComponent();
        }

        private void lbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city;

            // Get the city that was selected
            city = lbxCities.SelectedItem.ToString();

            // Switch based on the city selected
            switch (city)
            {
                case "Honolulu":
                    lblTimeZone.Text = "Hawaii";
                    break;
                case "New York":
                case "Mailman's House":
                case "Jimmy Johns":
                    lblTimeZone.Text = "Eastern";
                    break;
                case "San Franscisco":
                    lblTimeZone.Text = "Pacific";
                    break;
                case "Minneapolis":
                    lblTimeZone.Text = "Central";
                    break;
                case "Mordor":
                    lblTimeZone.Text = "North Korea";
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; // Remember to add the "System.Net;" so that the WebClient works correctly!
using System.Windows.Forms;

namespace VersionChecker
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            // Local version of the program
            string appVersion = "v0.0.1";  // I recommend checking the version based on a separate file, where it will contain other important information!
            lblLocalVersion.Text = "Version: " + appVersion;

            // WebClient, pulls the referring information from the Web, in this case I make a request on the referring URL and I get a string (The string is the last version made available on the server).
            WebClient client = new WebClient();

            string getUpdate = client.DownloadString("https://pastebin.com/raw/T1QJeVm3");  // Here is the link to the file you want to get the information from, in this case I used a .txt stored in pastebin !!! Remember to get the URL that opens the file directly and is displayed by the browser, do not use the URL where the file is displayed by the site, otherwise the webclient will return an error as it will take parts of the HTML!

            // Online version of the program after being collected is visually informed in a label 
            lblNewerVersion.Text = "Last Update: " + getUpdate;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
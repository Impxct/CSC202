using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketBrowser
{
    public partial class MainBrowser : Form
    {
        /// <summary>
        /// Runs once the program starts, Runs automatically. 
        /// </summary>
        public MainBrowser()
        {
            InitializeComponent();
            //default home page.
            textBoxURL.Text = "google.com";
            //Goes to the URL typed into URL textbox. Displays web page in the browser.
            webBrowserDisplay.Navigate(textBoxURL.Text);
            // Stops javascript errors from displaying
            webBrowserDisplay.ScriptErrorsSuppressed = true;

        }
        /// <summary>
        ///  Runs when user clicks "Go" Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            //Goes to the URL typed into URL textbox. Displays web page in the browser.
            webBrowserDisplay.Navigate(textBoxURL.Text);
            // Stops javascript errors from displaying
            webBrowserDisplay.ScriptErrorsSuppressed = true;
            //pasted above for auto display of "google.com"
        }
    }
}

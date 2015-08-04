using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrozzleValidator
{
    enum LEVEL
    {
        EASY, MEDIUM, HARD, EXTREME
    }

    public partial class mainForm : Form
    {
        StringBuilder errorMessage;
        CSVLaoder csvLoader;
        CrozzleLoader clLoader;
        
        string[] wordList;

        public mainForm()
        {
            InitializeComponent();
            tsmCrozzle.Enabled = false;
            errorMessage = new StringBuilder(String.Empty);
            csvLoader = new CSVLaoder();
            clLoader = new CrozzleLoader();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addMessage(string message)
        {
            errorMessage.AppendLine(message);
            richTextBox1.Text = errorMessage.ToString();
        }

        private void tsmWordlist_Click(object sender, EventArgs e)
        {
            ofdLoadFiles.Filter = "CSV Flies(.csv)|*.csv|All files(*.*)|*.*";
            if (ofdLoadFiles.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofdLoadFiles.FileName;
                wordList = csvLoader.loadWordlist(fileName);
                if (wordList.Length > 0)
                {
                    tsmCrozzle.Enabled = true;
                }
                addMessage(csvLoader.loaderMessages.ToString());
            }
        }

        private void tsmCrozzle_Click(object sender, EventArgs e)
        {
            ofdLoadFiles.Filter = "TXT Flies(.txt)|*.txt|All files(*.*)|*.*";
            if (ofdLoadFiles.ShowDialog() == DialogResult.OK)
            {
                clLoader.width = csvLoader.width;
                clLoader.height = csvLoader.height;
                string fileName = ofdLoadFiles.FileName;
                clLoader.loadWordlist(fileName);
                if (wordList.Length > 0)
                {
                    tsmCrozzle.Enabled = true;
                }
                addMessage(csvLoader.loaderMessages.ToString());
            }
        }        
    }
}

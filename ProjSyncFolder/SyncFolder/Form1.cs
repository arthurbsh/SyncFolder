using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncFolder
{
    public partial class Form1 : Form
    {

        Watcher fileWatcher;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBrowseFrom_Click(object sender, EventArgs e)
        {
            if (fromFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.textBoxFrom.Text = fromFolderBrowser.SelectedPath;
            }
        }

        private void buttonBrowseTo_Click(object sender, EventArgs e)
        {
            if (toFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.textBoxTo.Text = toFolderBrowser.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Starting watcher");
            fileWatcher = new Watcher();
            fileWatcher.Watch(textBoxFrom.Text, textBoxTo.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubSubGUI
{
    public partial class PublisherGUI : Form
    {
        private PublisherControls control;

        public PublisherGUI()
        {

        }

        public PublisherGUI(PublisherControls pcontrol)
        {
            InitializeComponent();
            control = pcontrol;
        }

        private void newTopicButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (!string.IsNullOrWhiteSpace(pubIndexBox.Text) && Int32.TryParse(pubIndexBox.Text, out index))
            {
                if (!string.IsNullOrWhiteSpace(newTopicBox.Text))
                {
                    string topic = newTopicBox.Text;
                    bool messageSent = control.newTopic(index, topic);
                    if (messageSent == true)
                    {
                        newTopicBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Unable to add.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter topic name.");
                }
            }
            else
                MessageBox.Show("Please enter publisher index.");
        }

        private void postToButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (!string.IsNullOrWhiteSpace(pubIndexBox.Text) && Int32.TryParse(pubIndexBox.Text, out index))
            {
                if (!string.IsNullOrWhiteSpace(postBox.Text) && !string.IsNullOrWhiteSpace(postMessageBox.Text))
                {
                    string topic = postBox.Text;
                    string message = postMessageBox.Text;
                    DateTime time = DateTime.Now;
                    bool messageSent = control.newPost(index, topic, message, time.ToString());
                    if (messageSent == true)
                    {
                        int rowId = postGrid.Rows.Add();
                        DataGridViewRow row = postGrid.Rows[rowId];
                        row.Cells["topic"].Value = topic;
                        row.Cells["message"].Value = message;
                        row.Cells["date"].Value = time.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Server is closed.");
                    }
                }
                else
                    MessageBox.Show("Please enter post topic or post message.");
            }
            else
                MessageBox.Show("Please enter publisher index.");
        }

        private void PublisherGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool messageSent = control.closeConnection();
            if (messageSent == false) // this means the server is closed already
            {
                this.Hide();
            }
        }
    }
}

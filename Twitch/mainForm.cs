using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Twitch
{
    public partial class mainForm : Form
    {
        int seriesSize = 0;
        string channel = "";
        string clientID = ""; // Insert client ID here

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            channelTextBox.Focus();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            clearUI();
            channel = channelTextBox.Text;
            load();
        }

        private void chatButton_Click(object sender, EventArgs e)
        {
            chatForm form = new chatForm(channel);
            form.ShowDialog();
        }

        // Event Listeners

        private void channelTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitButton_Click(this, new EventArgs());
            }
        }

        private void scrollTimer_Tick(object sender, EventArgs e)
        {
            titleLabel.Text = titleLabel.Text.Substring(1, titleLabel.Text.Length - 1) + titleLabel.Text.Substring(0, 1);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            load();
        }

        // Own functions

        private void clearUI()
        {
            foreach (var series in viewersChart.Series)
            {
                series.Points.Clear();
            }
        }

        private void load()
        {
            chatButton.Enabled = true;

            // Load data from web
            System.Net.WebClient client = new System.Net.WebClient();
            string streamsReply = "";
            string channelReply = "";
            try
            {
                streamsReply = client.DownloadString("https://api.twitch.tv/kraken/streams/" + channel + "?client_id=" + clientID);
                channelReply = client.DownloadString("https://api.twitch.tv/kraken/channels/" + channel + "?client_id=" + clientID);
            }
            catch
            {
                MessageBox.Show("Channel not found", "Error");
                return;
            }

            // Extract data from JSON replies
            var streamsResults = JsonConvert.DeserializeObject<dynamic>(streamsReply);
            var channelResults = JsonConvert.DeserializeObject<dynamic>(channelReply);
            

            string followersString = channelResults.followers;
            int followers = int.Parse(followersString);

            string viewsString = channelResults.views;
            int views = int.Parse(viewsString);

            logoPictureBox.ImageLocation = channelResults.logo;
            channelCreationLabel.Text = "Created at: " + channelResults.created_at;
            matureLabel.Text = "Mature: " + channelResults.mature;
            partnerLabel.Text = "Partner: " + channelResults.partner;
            followersLabel.Text = "Followers: " + followers.ToString("#,##0");
            totalviewersLabel.Text = "Total unique views: " + views.ToString("#,##0");

            DateTime accountCreationTime = Convert.ToDateTime(channelResults.created_at);
            TimeSpan timeSinceAccountCreation = System.DateTime.Now - accountCreationTime;
            timeSinceLabel.Text = "Time since: " + timeSinceAccountCreation.Days + " Days";


            if (streamsResults.stream == null) // Offline stream
            {
                titleLabel.Text = "Stream offline";

                previewBox.ImageLocation = channelResults.video_banner;


            }
            else // Online stream
            {
                scrollTimer.Enabled = true;
                refreshTimer.Enabled = true;

                previewBox.ImageLocation = streamsResults.stream.preview.large;
                titleLabel.Text = streamsResults.stream.channel.status + "          ";
                infoLabel.Text = "Game: " + streamsResults.stream.game;

                string viewersLabelString = streamsResults.stream.viewers;
                int viewersLabel = int.Parse(viewersLabelString);
                viewerLabel.Text = "Viewers: " + viewersLabel.ToString("#,##0");

                if (streamsResults.stream.delay == "0")
                {
                    delayLabel.Text = "Delay: none";
                }
                else
                {
                    delayLabel.Text = "Delay: " + streamsResults.stream.delay + " seconds";
                }


                string fpsString = streamsResults.stream.average_fps;
                float fps = float.Parse(fpsString);
                fpsLabel.Text = "Average fps: " + Math.Round(fps, 2);


                DateTime startTime = Convert.ToDateTime(streamsResults.stream.created_at);
                startedLabel.Text = "Started at: " + startTime;
                TimeSpan duration = System.DateTime.Now - startTime;
                uptimeLabel.Text = "Uptime: " + duration.ToString(@"hh\:mm\:ss");
                

                // CHART 

                int viewers = 0;
                string viewersString = streamsResults.stream.viewers;
                bool resize = true;

                if (int.TryParse(viewersString, out viewers))
                {
                    if (resize == true)
                    {
                        viewersChart.ChartAreas[0].AxisY.Minimum = viewers - (viewers * 0.05);
                        viewersChart.ChartAreas[0].AxisY.Maximum = viewers + (viewers * 0.05);
                        resize = false;
                    }
                    viewersChart.Series[0].Points.AddY(viewers);
                    seriesSize++;
                }
                if (seriesSize >= 5)
                {
                    viewersChart.ChartAreas[0].AxisX.Minimum = seriesSize - 5;
                    viewersChart.ChartAreas[0].AxisX.Maximum = seriesSize + 2;

                }
                if (seriesSize % 5 == 0)
                {
                    resize = true;
                }

            }




        }

        private void channelTextBox_TextChanged(object sender, EventArgs e)
        {
            if(this.Text.Length >= 1)
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

       
    }
}

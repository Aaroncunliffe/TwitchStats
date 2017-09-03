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
using Newtonsoft.Json.Linq;

namespace Twitch
{
    public partial class chatForm : Form
    {
        string channel = "";

        const int rowSize = 5;

        JObject resultsObj;
        dynamic chatResults;
        string clientID = ""; // Insert client ID here

        public chatForm(string c)
        {
            channel = c;
            InitializeComponent();
        }

        private void chatForm_Load(object sender, EventArgs e)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            string chatReply = "";
            try
            {
                chatReply = client.DownloadString("https://api.twitch.tv/kraken/chat/" + channel + "/emoticons" + "?client_id=" + clientID);
            }
            catch
            {
                MessageBox.Show("Cannot load chat info", "Error");
                return;
            }

            // Extract data from JSON reply
            resultsObj = (JObject)JsonConvert.DeserializeObject<dynamic>(chatReply);
            chatResults = JsonConvert.DeserializeObject<dynamic>(chatReply);

            int numOfEmoticons = resultsObj["emoticons"].Count();
            sliderControl.Maximum = numOfEmoticons;

            nameLabel.Text = "Name: " + chatResults.emoticons[0].regex;
            subLabel.Text = "Subscriber only: " + chatResults.emoticons[0].subscriber_only;
            stateLabel.Text = "State: " + "" + chatResults.emoticons[0].state;
            
            emotePictureBox.Width = chatResults.emoticons[0].width * 4;
            emotePictureBox.Height = chatResults.emoticons[0].height * 4;
            emotePictureBox.ImageLocation = chatResults.emoticons[0].url;
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sliderControl_Scroll(object sender, EventArgs e)
        {
            nameLabel.Text = "Name: " + chatResults.emoticons[sliderControl.Value - 1].regex;
            subLabel.Text = "Subscriber only: " + chatResults.emoticons[sliderControl.Value - 1].subscriber_only;
            stateLabel.Text = "State: " + "" + chatResults.emoticons[sliderControl.Value - 1].state;
            
            emotePictureBox.Width = chatResults.emoticons[sliderControl.Value - 1].width * 4;
            emotePictureBox.Height = chatResults.emoticons[sliderControl.Value - 1].height * 4;
            emotePictureBox.ImageLocation = chatResults.emoticons[sliderControl.Value - 1].url;

        }

        
    }
}

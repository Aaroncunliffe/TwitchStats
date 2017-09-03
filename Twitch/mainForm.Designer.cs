namespace Twitch
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.channelInfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.channelCreationLabel = new System.Windows.Forms.Label();
            this.timeSinceLabel = new System.Windows.Forms.Label();
            this.matureLabel = new System.Windows.Forms.Label();
            this.partnerLabel = new System.Windows.Forms.Label();
            this.followersLabel = new System.Windows.Forms.Label();
            this.totalviewersLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.viewersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.titleLabel = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.viewerLabel = new System.Windows.Forms.Label();
            this.delayLabel = new System.Windows.Forms.Label();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.startedLabel = new System.Windows.Forms.Label();
            this.uptimeLabel = new System.Windows.Forms.Label();
            this.streamPanel = new System.Windows.Forms.Panel();
            this.chatButton = new System.Windows.Forms.Button();
            this.channelInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewersChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.streamPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // channelTextBox
            // 
            this.channelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelTextBox.Location = new System.Drawing.Point(10, 17);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(211, 29);
            this.channelTextBox.TabIndex = 0;
            this.channelTextBox.TextChanged += new System.EventHandler(this.channelTextBox_TextChanged);
            this.channelTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.channelTextBox_KeyDown);
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(227, 17);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(93, 31);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // channelInfoPanel
            // 
            this.channelInfoPanel.Controls.Add(this.channelCreationLabel);
            this.channelInfoPanel.Controls.Add(this.timeSinceLabel);
            this.channelInfoPanel.Controls.Add(this.matureLabel);
            this.channelInfoPanel.Controls.Add(this.partnerLabel);
            this.channelInfoPanel.Controls.Add(this.followersLabel);
            this.channelInfoPanel.Controls.Add(this.totalviewersLabel);
            this.channelInfoPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.channelInfoPanel.Location = new System.Drawing.Point(12, 83);
            this.channelInfoPanel.Name = "channelInfoPanel";
            this.channelInfoPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.channelInfoPanel.Size = new System.Drawing.Size(308, 123);
            this.channelInfoPanel.TabIndex = 2;
            // 
            // channelCreationLabel
            // 
            this.channelCreationLabel.AutoSize = true;
            this.channelCreationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelCreationLabel.Location = new System.Drawing.Point(3, 5);
            this.channelCreationLabel.Name = "channelCreationLabel";
            this.channelCreationLabel.Size = new System.Drawing.Size(80, 18);
            this.channelCreationLabel.TabIndex = 0;
            this.channelCreationLabel.Text = "Created at:";
            // 
            // timeSinceLabel
            // 
            this.timeSinceLabel.AutoSize = true;
            this.timeSinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSinceLabel.Location = new System.Drawing.Point(3, 23);
            this.timeSinceLabel.Name = "timeSinceLabel";
            this.timeSinceLabel.Size = new System.Drawing.Size(86, 18);
            this.timeSinceLabel.TabIndex = 5;
            this.timeSinceLabel.Text = "Time Since:";
            // 
            // matureLabel
            // 
            this.matureLabel.AutoSize = true;
            this.matureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matureLabel.Location = new System.Drawing.Point(3, 41);
            this.matureLabel.Name = "matureLabel";
            this.matureLabel.Size = new System.Drawing.Size(62, 18);
            this.matureLabel.TabIndex = 1;
            this.matureLabel.Text = "Mature: ";
            // 
            // partnerLabel
            // 
            this.partnerLabel.AutoSize = true;
            this.partnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partnerLabel.Location = new System.Drawing.Point(3, 59);
            this.partnerLabel.Name = "partnerLabel";
            this.partnerLabel.Size = new System.Drawing.Size(56, 18);
            this.partnerLabel.TabIndex = 2;
            this.partnerLabel.Text = "Partner";
            // 
            // followersLabel
            // 
            this.followersLabel.AutoSize = true;
            this.followersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followersLabel.Location = new System.Drawing.Point(3, 77);
            this.followersLabel.Name = "followersLabel";
            this.followersLabel.Size = new System.Drawing.Size(73, 18);
            this.followersLabel.TabIndex = 4;
            this.followersLabel.Text = "Followers";
            // 
            // totalviewersLabel
            // 
            this.totalviewersLabel.AutoSize = true;
            this.totalviewersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalviewersLabel.Location = new System.Drawing.Point(3, 95);
            this.totalviewersLabel.Name = "totalviewersLabel";
            this.totalviewersLabel.Size = new System.Drawing.Size(142, 18);
            this.totalviewersLabel.TabIndex = 3;
            this.totalviewersLabel.Text = "Total unique viewers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Channel Info:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scrollTimer
            // 
            this.scrollTimer.Tick += new System.EventHandler(this.scrollTimer_Tick);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 10000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // viewersChart
            // 
            this.viewersChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.viewersChart.ChartAreas.Add(chartArea1);
            this.viewersChart.Location = new System.Drawing.Point(10, 213);
            this.viewersChart.Name = "viewersChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.viewersChart.Series.Add(series1);
            this.viewersChart.Size = new System.Drawing.Size(310, 234);
            this.viewersChart.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(90, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(50, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(21, 73);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(500, 281);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewBox.TabIndex = 2;
            this.previewBox.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(14, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(66, 64);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 4;
            this.logoPictureBox.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(87, 40);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(53, 18);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Game:";
            // 
            // viewerLabel
            // 
            this.viewerLabel.AutoSize = true;
            this.viewerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewerLabel.Location = new System.Drawing.Point(18, 357);
            this.viewerLabel.Name = "viewerLabel";
            this.viewerLabel.Size = new System.Drawing.Size(64, 18);
            this.viewerLabel.TabIndex = 6;
            this.viewerLabel.Text = "Viewers:";
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayLabel.Location = new System.Drawing.Point(18, 375);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(49, 18);
            this.delayLabel.TabIndex = 7;
            this.delayLabel.Text = "Delay:";
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsLabel.Location = new System.Drawing.Point(18, 393);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(89, 18);
            this.fpsLabel.TabIndex = 8;
            this.fpsLabel.Text = "Average fps:";
            // 
            // startedLabel
            // 
            this.startedLabel.AutoSize = true;
            this.startedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedLabel.Location = new System.Drawing.Point(275, 357);
            this.startedLabel.Name = "startedLabel";
            this.startedLabel.Size = new System.Drawing.Size(79, 18);
            this.startedLabel.TabIndex = 9;
            this.startedLabel.Text = "Started at: ";
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.AutoSize = true;
            this.uptimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uptimeLabel.Location = new System.Drawing.Point(275, 375);
            this.uptimeLabel.Name = "uptimeLabel";
            this.uptimeLabel.Size = new System.Drawing.Size(67, 18);
            this.uptimeLabel.TabIndex = 10;
            this.uptimeLabel.Text = "Uptime : ";
            // 
            // streamPanel
            // 
            this.streamPanel.AutoSize = true;
            this.streamPanel.Controls.Add(this.chatButton);
            this.streamPanel.Controls.Add(this.uptimeLabel);
            this.streamPanel.Controls.Add(this.startedLabel);
            this.streamPanel.Controls.Add(this.fpsLabel);
            this.streamPanel.Controls.Add(this.delayLabel);
            this.streamPanel.Controls.Add(this.viewerLabel);
            this.streamPanel.Controls.Add(this.infoLabel);
            this.streamPanel.Controls.Add(this.logoPictureBox);
            this.streamPanel.Controls.Add(this.previewBox);
            this.streamPanel.Controls.Add(this.titleLabel);
            this.streamPanel.Location = new System.Drawing.Point(341, 10);
            this.streamPanel.Name = "streamPanel";
            this.streamPanel.Size = new System.Drawing.Size(530, 440);
            this.streamPanel.TabIndex = 4;
            // 
            // chatButton
            // 
            this.chatButton.Enabled = false;
            this.chatButton.Location = new System.Drawing.Point(434, 406);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(93, 31);
            this.chatButton.TabIndex = 6;
            this.chatButton.Text = "Chat info";
            this.chatButton.UseVisualStyleBackColor = true;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(880, 459);
            this.Controls.Add(this.viewersChart);
            this.Controls.Add(this.channelInfoPanel);
            this.Controls.Add(this.streamPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.channelTextBox);
            this.MaximumSize = new System.Drawing.Size(896, 760);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Twitch Scanner";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.channelInfoPanel.ResumeLayout(false);
            this.channelInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewersChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.streamPanel.ResumeLayout(false);
            this.streamPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.FlowLayoutPanel channelInfoPanel;
        private System.Windows.Forms.Label channelCreationLabel;
        private System.Windows.Forms.Label matureLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label partnerLabel;
        private System.Windows.Forms.Label totalviewersLabel;
        private System.Windows.Forms.Label followersLabel;
        private System.Windows.Forms.Timer scrollTimer;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart viewersChart;
        private System.Windows.Forms.Label timeSinceLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label viewerLabel;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.Label startedLabel;
        private System.Windows.Forms.Label uptimeLabel;
        private System.Windows.Forms.Panel streamPanel;
        private System.Windows.Forms.Button chatButton;
    }
}


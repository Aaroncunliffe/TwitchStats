namespace Twitch
{
    partial class chatForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.emotePictureBox = new System.Windows.Forms.PictureBox();
            this.sliderControl = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emotePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderControl)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(421, 335);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 31);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // emotePictureBox
            // 
            this.emotePictureBox.Location = new System.Drawing.Point(201, 12);
            this.emotePictureBox.Name = "emotePictureBox";
            this.emotePictureBox.Size = new System.Drawing.Size(112, 112);
            this.emotePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emotePictureBox.TabIndex = 3;
            this.emotePictureBox.TabStop = false;
            // 
            // sliderControl
            // 
            this.sliderControl.Location = new System.Drawing.Point(12, 284);
            this.sliderControl.Minimum = 1;
            this.sliderControl.Name = "sliderControl";
            this.sliderControl.Size = new System.Drawing.Size(502, 45);
            this.sliderControl.TabIndex = 4;
            this.sliderControl.Value = 1;
            this.sliderControl.Scroll += new System.EventHandler(this.sliderControl_Scroll);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nameLabel);
            this.flowLayoutPanel1.Controls.Add(this.subLabel);
            this.flowLayoutPanel1.Controls.Add(this.stateLabel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(178, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 96);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.Location = new System.Drawing.Point(3, 18);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(114, 18);
            this.subLabel.TabIndex = 1;
            this.subLabel.Text = "Subscriber only:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(3, 36);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(46, 18);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "State:";
            // 
            // chatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 378);
            this.Controls.Add(this.emotePictureBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sliderControl);
            this.Controls.Add(this.closeButton);
            this.Name = "chatForm";
            this.ShowIcon = false;
            this.Text = "Emotes";
            this.Load += new System.EventHandler(this.chatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emotePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderControl)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox emotePictureBox;
        private System.Windows.Forms.TrackBar sliderControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label stateLabel;
    }
}
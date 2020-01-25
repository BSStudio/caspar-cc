namespace caspar_cc
{
    partial class MainForm
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
            this.actionsLabelPanel = new System.Windows.Forms.Panel();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.captionsLabelPanel = new System.Windows.Forms.Panel();
            this.captionsLabel = new System.Windows.Forms.Label();
            this.captionsPanel = new System.Windows.Forms.Panel();
            this.channelsLabelPanel = new System.Windows.Forms.Panel();
            this.channelsLabel = new System.Windows.Forms.Label();
            this.channelsPanel = new System.Windows.Forms.Panel();
            this.allChannelUpButton = new System.Windows.Forms.Button();
            this.allChannelDownButton = new System.Windows.Forms.Button();
            this.previousCaptionButton = new System.Windows.Forms.Button();
            this.nextCaptionButton = new System.Windows.Forms.Button();
            this.emptyCaptionButton = new System.Windows.Forms.Button();
            this.actionsLabelPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.captionsLabelPanel.SuspendLayout();
            this.channelsLabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsLabelPanel
            // 
            this.actionsLabelPanel.AutoSize = true;
            this.actionsLabelPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actionsLabelPanel.BackColor = System.Drawing.Color.Navy;
            this.actionsLabelPanel.Controls.Add(this.actionsLabel);
            this.actionsLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionsLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.actionsLabelPanel.Name = "actionsLabelPanel";
            this.actionsLabelPanel.Size = new System.Drawing.Size(800, 58);
            this.actionsLabelPanel.TabIndex = 0;
            // 
            // actionsLabel
            // 
            this.actionsLabel.AutoSize = true;
            this.actionsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionsLabel.Font = new System.Drawing.Font("Broadway", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsLabel.ForeColor = System.Drawing.Color.White;
            this.actionsLabel.Location = new System.Drawing.Point(0, 0);
            this.actionsLabel.Name = "actionsLabel";
            this.actionsLabel.Padding = new System.Windows.Forms.Padding(10);
            this.actionsLabel.Size = new System.Drawing.Size(196, 58);
            this.actionsLabel.TabIndex = 0;
            this.actionsLabel.Text = "ACTIONS";
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.emptyCaptionButton);
            this.actionsPanel.Controls.Add(this.nextCaptionButton);
            this.actionsPanel.Controls.Add(this.previousCaptionButton);
            this.actionsPanel.Controls.Add(this.allChannelDownButton);
            this.actionsPanel.Controls.Add(this.allChannelUpButton);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionsPanel.Location = new System.Drawing.Point(0, 58);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.actionsPanel.Size = new System.Drawing.Size(800, 100);
            this.actionsPanel.TabIndex = 1;
            // 
            // captionsLabelPanel
            // 
            this.captionsLabelPanel.AutoSize = true;
            this.captionsLabelPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.captionsLabelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.captionsLabelPanel.Controls.Add(this.captionsLabel);
            this.captionsLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.captionsLabelPanel.Location = new System.Drawing.Point(0, 158);
            this.captionsLabelPanel.Name = "captionsLabelPanel";
            this.captionsLabelPanel.Size = new System.Drawing.Size(800, 58);
            this.captionsLabelPanel.TabIndex = 2;
            // 
            // captionsLabel
            // 
            this.captionsLabel.AutoSize = true;
            this.captionsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.captionsLabel.Font = new System.Drawing.Font("Broadway", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionsLabel.ForeColor = System.Drawing.Color.White;
            this.captionsLabel.Location = new System.Drawing.Point(0, 0);
            this.captionsLabel.Name = "captionsLabel";
            this.captionsLabel.Padding = new System.Windows.Forms.Padding(10);
            this.captionsLabel.Size = new System.Drawing.Size(230, 58);
            this.captionsLabel.TabIndex = 0;
            this.captionsLabel.Text = "CAPTIONS";
            // 
            // captionsPanel
            // 
            this.captionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captionsPanel.Location = new System.Drawing.Point(0, 216);
            this.captionsPanel.Name = "captionsPanel";
            this.captionsPanel.Size = new System.Drawing.Size(800, 150);
            this.captionsPanel.TabIndex = 3;
            // 
            // channelsLabelPanel
            // 
            this.channelsLabelPanel.AutoSize = true;
            this.channelsLabelPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channelsLabelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.channelsLabelPanel.Controls.Add(this.channelsLabel);
            this.channelsLabelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.channelsLabelPanel.Location = new System.Drawing.Point(0, 366);
            this.channelsLabelPanel.Name = "channelsLabelPanel";
            this.channelsLabelPanel.Size = new System.Drawing.Size(800, 58);
            this.channelsLabelPanel.TabIndex = 4;
            // 
            // channelsLabel
            // 
            this.channelsLabel.AutoSize = true;
            this.channelsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.channelsLabel.Font = new System.Drawing.Font("Broadway", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelsLabel.ForeColor = System.Drawing.Color.White;
            this.channelsLabel.Location = new System.Drawing.Point(0, 0);
            this.channelsLabel.Name = "channelsLabel";
            this.channelsLabel.Padding = new System.Windows.Forms.Padding(10);
            this.channelsLabel.Size = new System.Drawing.Size(238, 58);
            this.channelsLabel.TabIndex = 0;
            this.channelsLabel.Text = "CHANNELS";
            // 
            // channelsPanel
            // 
            this.channelsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.channelsPanel.Location = new System.Drawing.Point(0, 424);
            this.channelsPanel.Name = "channelsPanel";
            this.channelsPanel.Size = new System.Drawing.Size(800, 100);
            this.channelsPanel.TabIndex = 5;
            // 
            // allChannelUpButton
            // 
            this.allChannelUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allChannelUpButton.Location = new System.Drawing.Point(13, 14);
            this.allChannelUpButton.Name = "allChannelUpButton";
            this.allChannelUpButton.Size = new System.Drawing.Size(108, 73);
            this.allChannelUpButton.TabIndex = 0;
            this.allChannelUpButton.Text = "ALL CHANNEL UP";
            this.allChannelUpButton.UseVisualStyleBackColor = true;
            // 
            // allChannelDownButton
            // 
            this.allChannelDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allChannelDownButton.Location = new System.Drawing.Point(127, 14);
            this.allChannelDownButton.Name = "allChannelDownButton";
            this.allChannelDownButton.Size = new System.Drawing.Size(108, 73);
            this.allChannelDownButton.TabIndex = 1;
            this.allChannelDownButton.Text = "ALL CHANNEL DOWN";
            this.allChannelDownButton.UseVisualStyleBackColor = true;
            // 
            // previousCaptionButton
            // 
            this.previousCaptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previousCaptionButton.Location = new System.Drawing.Point(275, 14);
            this.previousCaptionButton.Name = "previousCaptionButton";
            this.previousCaptionButton.Size = new System.Drawing.Size(120, 73);
            this.previousCaptionButton.TabIndex = 2;
            this.previousCaptionButton.Text = "PREVIOUS CAPTION";
            this.previousCaptionButton.UseVisualStyleBackColor = true;
            // 
            // nextCaptionButton
            // 
            this.nextCaptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextCaptionButton.Location = new System.Drawing.Point(401, 13);
            this.nextCaptionButton.Name = "nextCaptionButton";
            this.nextCaptionButton.Size = new System.Drawing.Size(120, 73);
            this.nextCaptionButton.TabIndex = 3;
            this.nextCaptionButton.Text = "NEXT CAPTION";
            this.nextCaptionButton.UseVisualStyleBackColor = true;
            // 
            // emptyCaptionButton
            // 
            this.emptyCaptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emptyCaptionButton.Location = new System.Drawing.Point(527, 14);
            this.emptyCaptionButton.Name = "emptyCaptionButton";
            this.emptyCaptionButton.Size = new System.Drawing.Size(120, 73);
            this.emptyCaptionButton.TabIndex = 4;
            this.emptyCaptionButton.Text = "EMPTY CAPTION";
            this.emptyCaptionButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.captionsPanel);
            this.Controls.Add(this.channelsLabelPanel);
            this.Controls.Add(this.channelsPanel);
            this.Controls.Add(this.captionsLabelPanel);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.actionsLabelPanel);
            this.Name = "MainForm";
            this.Text = "CasparCG - closed captions GUI";
            this.actionsLabelPanel.ResumeLayout(false);
            this.actionsLabelPanel.PerformLayout();
            this.actionsPanel.ResumeLayout(false);
            this.captionsLabelPanel.ResumeLayout(false);
            this.captionsLabelPanel.PerformLayout();
            this.channelsLabelPanel.ResumeLayout(false);
            this.channelsLabelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel actionsLabelPanel;
        private System.Windows.Forms.Label actionsLabel;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Panel captionsLabelPanel;
        private System.Windows.Forms.Label captionsLabel;
        private System.Windows.Forms.Panel captionsPanel;
        private System.Windows.Forms.Panel channelsLabelPanel;
        private System.Windows.Forms.Label channelsLabel;
        private System.Windows.Forms.Panel channelsPanel;
        private System.Windows.Forms.Button emptyCaptionButton;
        private System.Windows.Forms.Button nextCaptionButton;
        private System.Windows.Forms.Button previousCaptionButton;
        private System.Windows.Forms.Button allChannelDownButton;
        private System.Windows.Forms.Button allChannelUpButton;
    }
}


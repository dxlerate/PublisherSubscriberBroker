namespace PubSubGUI
{
    partial class PublisherGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newTopicBox = new System.Windows.Forms.TextBox();
            this.postMessageBox = new System.Windows.Forms.TextBox();
            this.newTopicButton = new System.Windows.Forms.Button();
            this.postToButton = new System.Windows.Forms.Button();
            this.postGrid = new System.Windows.Forms.DataGridView();
            this.topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pubIndexBox = new System.Windows.Forms.TextBox();
            this.postBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.postGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Topic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Post To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message:";
            // 
            // newTopicBox
            // 
            this.newTopicBox.Location = new System.Drawing.Point(92, 37);
            this.newTopicBox.Name = "newTopicBox";
            this.newTopicBox.Size = new System.Drawing.Size(243, 22);
            this.newTopicBox.TabIndex = 3;
            // 
            // postMessageBox
            // 
            this.postMessageBox.AcceptsReturn = true;
            this.postMessageBox.Location = new System.Drawing.Point(92, 136);
            this.postMessageBox.Multiline = true;
            this.postMessageBox.Name = "postMessageBox";
            this.postMessageBox.Size = new System.Drawing.Size(243, 130);
            this.postMessageBox.TabIndex = 5;
            // 
            // newTopicButton
            // 
            this.newTopicButton.Location = new System.Drawing.Point(141, 65);
            this.newTopicButton.Name = "newTopicButton";
            this.newTopicButton.Size = new System.Drawing.Size(147, 23);
            this.newTopicButton.TabIndex = 7;
            this.newTopicButton.Text = "Create New Topic";
            this.newTopicButton.UseVisualStyleBackColor = true;
            this.newTopicButton.Click += new System.EventHandler(this.newTopicButton_Click);
            // 
            // postToButton
            // 
            this.postToButton.Location = new System.Drawing.Point(141, 272);
            this.postToButton.Name = "postToButton";
            this.postToButton.Size = new System.Drawing.Size(147, 23);
            this.postToButton.TabIndex = 8;
            this.postToButton.Text = "Post To Topic";
            this.postToButton.UseVisualStyleBackColor = true;
            this.postToButton.Click += new System.EventHandler(this.postToButton_Click);
            // 
            // postGrid
            // 
            this.postGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topic,
            this.message,
            this.date});
            this.postGrid.Location = new System.Drawing.Point(15, 315);
            this.postGrid.Name = "postGrid";
            this.postGrid.RowHeadersWidth = 51;
            this.postGrid.RowTemplate.Height = 24;
            this.postGrid.Size = new System.Drawing.Size(457, 167);
            this.postGrid.TabIndex = 9;
            // 
            // topic
            // 
            this.topic.HeaderText = "Topix";
            this.topic.MinimumWidth = 6;
            this.topic.Name = "topic";
            this.topic.Width = 125;
            // 
            // message
            // 
            this.message.HeaderText = "Message";
            this.message.MinimumWidth = 6;
            this.message.Name = "message";
            this.message.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publisher Index";
            // 
            // pubIndexBox
            // 
            this.pubIndexBox.Location = new System.Drawing.Point(122, 6);
            this.pubIndexBox.Name = "pubIndexBox";
            this.pubIndexBox.Size = new System.Drawing.Size(213, 22);
            this.pubIndexBox.TabIndex = 11;
            // 
            // postBox
            // 
            this.postBox.Location = new System.Drawing.Point(92, 106);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(243, 22);
            this.postBox.TabIndex = 12;
            // 
            // PublisherGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 494);
            this.Controls.Add(this.postBox);
            this.Controls.Add(this.pubIndexBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.postGrid);
            this.Controls.Add(this.postToButton);
            this.Controls.Add(this.newTopicButton);
            this.Controls.Add(this.postMessageBox);
            this.Controls.Add(this.newTopicBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PublisherGUI";
            this.Text = "PublisherGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PublisherGUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.postGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newTopicBox;
        private System.Windows.Forms.TextBox postMessageBox;
        private System.Windows.Forms.Button newTopicButton;
        private System.Windows.Forms.Button postToButton;
        private System.Windows.Forms.DataGridView postGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pubIndexBox;
        private System.Windows.Forms.TextBox postBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}
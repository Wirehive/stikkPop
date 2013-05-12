namespace stikkPop
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.configureLink = new System.Windows.Forms.LinkLabel();
            this.PasteClipboardButton = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.PastedURLLabel = new System.Windows.Forms.Label();
            this.CopyLinkButton = new System.Windows.Forms.Button();
            this.syntaxBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.privateCheckBox = new System.Windows.Forms.CheckBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expiryBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.composeButton = new System.Windows.Forms.Button();
            this.openStikkedLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // configureLink
            // 
            this.configureLink.AutoSize = true;
            this.configureLink.Location = new System.Drawing.Point(173, 272);
            this.configureLink.Name = "configureLink";
            this.configureLink.Size = new System.Drawing.Size(52, 13);
            this.configureLink.TabIndex = 9;
            this.configureLink.TabStop = true;
            this.configureLink.Text = "Configure";
            this.configureLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.configureLink_LinkClicked);
            // 
            // PasteClipboardButton
            // 
            this.PasteClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasteClipboardButton.Location = new System.Drawing.Point(129, 12);
            this.PasteClipboardButton.Name = "PasteClipboardButton";
            this.PasteClipboardButton.Size = new System.Drawing.Size(96, 23);
            this.PasteClipboardButton.TabIndex = 1;
            this.PasteClipboardButton.Text = "Paste Clipboard";
            this.PasteClipboardButton.UseVisualStyleBackColor = true;
            this.PasteClipboardButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // urlBox
            // 
            this.urlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlBox.Location = new System.Drawing.Point(13, 67);
            this.urlBox.Name = "urlBox";
            this.urlBox.ReadOnly = true;
            this.urlBox.Size = new System.Drawing.Size(180, 20);
            this.urlBox.TabIndex = 2;
            // 
            // PastedURLLabel
            // 
            this.PastedURLLabel.AutoSize = true;
            this.PastedURLLabel.Location = new System.Drawing.Point(13, 48);
            this.PastedURLLabel.Name = "PastedURLLabel";
            this.PastedURLLabel.Size = new System.Drawing.Size(65, 13);
            this.PastedURLLabel.TabIndex = 3;
            this.PastedURLLabel.Text = "Pasted URL";
            this.PastedURLLabel.Click += new System.EventHandler(this.urlLabel_Click);
            // 
            // CopyLinkButton
            // 
            this.CopyLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CopyLinkButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyLinkButton.Image")));
            this.CopyLinkButton.Location = new System.Drawing.Point(200, 65);
            this.CopyLinkButton.Name = "CopyLinkButton";
            this.CopyLinkButton.Size = new System.Drawing.Size(25, 23);
            this.CopyLinkButton.TabIndex = 3;
            this.CopyLinkButton.UseVisualStyleBackColor = true;
            this.CopyLinkButton.Click += new System.EventHandler(this.CopyLinkButton_Click);
            // 
            // syntaxBox
            // 
            this.syntaxBox.FormattingEnabled = true;
            this.syntaxBox.Location = new System.Drawing.Point(13, 166);
            this.syntaxBox.Name = "syntaxBox";
            this.syntaxBox.Size = new System.Drawing.Size(212, 21);
            this.syntaxBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Syntax Highlighting";
            // 
            // privateCheckBox
            // 
            this.privateCheckBox.AutoSize = true;
            this.privateCheckBox.Location = new System.Drawing.Point(166, 206);
            this.privateCheckBox.Name = "privateCheckBox";
            this.privateCheckBox.Size = new System.Drawing.Size(59, 17);
            this.privateCheckBox.TabIndex = 7;
            this.privateCheckBox.Text = "Private";
            this.privateCheckBox.UseVisualStyleBackColor = true;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(13, 117);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(212, 20);
            this.titleBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Expiry";
            // 
            // expiryBox
            // 
            this.expiryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expiryBox.FormattingEnabled = true;
            this.expiryBox.Location = new System.Drawing.Point(53, 203);
            this.expiryBox.Name = "expiryBox";
            this.expiryBox.Size = new System.Drawing.Size(105, 21);
            this.expiryBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 33);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "or Ctrl-v";
            // 
            // composeButton
            // 
            this.composeButton.Location = new System.Drawing.Point(13, 239);
            this.composeButton.Name = "composeButton";
            this.composeButton.Size = new System.Drawing.Size(212, 25);
            this.composeButton.TabIndex = 8;
            this.composeButton.Text = "Compose Paste";
            this.composeButton.UseVisualStyleBackColor = true;
            this.composeButton.Click += new System.EventHandler(this.composeButton_Click);
            // 
            // openStikkedLink
            // 
            this.openStikkedLink.AutoSize = true;
            this.openStikkedLink.Location = new System.Drawing.Point(13, 273);
            this.openStikkedLink.Name = "openStikkedLink";
            this.openStikkedLink.Size = new System.Drawing.Size(72, 13);
            this.openStikkedLink.TabIndex = 15;
            this.openStikkedLink.TabStop = true;
            this.openStikkedLink.Text = "Open Stikked";
            this.openStikkedLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openStikkedLink_LinkClicked);
            // 
            // Main
            // 
            this.AcceptButton = this.PasteClipboardButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(239, 301);
            this.Controls.Add(this.openStikkedLink);
            this.Controls.Add(this.composeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.expiryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.privateCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.syntaxBox);
            this.Controls.Add(this.CopyLinkButton);
            this.Controls.Add(this.PastedURLLabel);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.PasteClipboardButton);
            this.Controls.Add(this.configureLink);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "stikkPop";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel configureLink;
        private System.Windows.Forms.Button PasteClipboardButton;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label PastedURLLabel;
        private System.Windows.Forms.Button CopyLinkButton;
        private System.Windows.Forms.ComboBox syntaxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox privateCheckBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox expiryBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button composeButton;
        private System.Windows.Forms.LinkLabel openStikkedLink;
    }
}


namespace stikkPop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PasteClipboardButton = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(173, 100);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Configure";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PasteClipboardButton
            // 
            this.PasteClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasteClipboardButton.Location = new System.Drawing.Point(68, 12);
            this.PasteClipboardButton.Name = "PasteClipboardButton";
            this.PasteClipboardButton.Size = new System.Drawing.Size(96, 23);
            this.PasteClipboardButton.TabIndex = 1;
            this.PasteClipboardButton.Text = "Paste Clipboard";
            this.PasteClipboardButton.UseVisualStyleBackColor = true;
            this.PasteClipboardButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // urlBox
            // 
            this.urlBox.Enabled = false;
            this.urlBox.Location = new System.Drawing.Point(13, 67);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(180, 20);
            this.urlBox.TabIndex = 2;
            this.urlBox.Text = "http://url.com/paste";
            this.urlBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pasted URL";
            // 
            // CopyLinkButton
            // 
            this.CopyLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CopyLinkButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyLinkButton.Image")));
            this.CopyLinkButton.Location = new System.Drawing.Point(200, 65);
            this.CopyLinkButton.Name = "CopyLinkButton";
            this.CopyLinkButton.Size = new System.Drawing.Size(25, 23);
            this.CopyLinkButton.TabIndex = 4;
            this.CopyLinkButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 131);
            this.Controls.Add(this.CopyLinkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.PasteClipboardButton);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "stikkPop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button PasteClipboardButton;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CopyLinkButton;
    }
}


namespace stikkPop
{
    partial class Configure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configure));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.syntaxBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.privateCheckBox = new System.Windows.Forms.CheckBox();
            this.tick = new System.Windows.Forms.PictureBox();
            this.cross = new System.Windows.Forms.PictureBox();
            this.autoCopyCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.autoOpenCheckBox = new System.Windows.Forms.CheckBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.endpointBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stikked Location";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(94, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "eg http://paste.website.com/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(94, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Used to set the author of the paste. If left blank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(96, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "the pastebin may randomly generate this.";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(190, 261);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(79, 261);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Default Syntax";
            // 
            // syntaxBox
            // 
            this.syntaxBox.FormattingEnabled = true;
            this.syntaxBox.Location = new System.Drawing.Point(99, 136);
            this.syntaxBox.Name = "syntaxBox";
            this.syntaxBox.Size = new System.Drawing.Size(218, 21);
            this.syntaxBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(96, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Syntax highlighting used by pastebin";
            // 
            // privateCheckBox
            // 
            this.privateCheckBox.AutoSize = true;
            this.privateCheckBox.Checked = global::stikkPop.Properties.Settings.Default.alwaysPrivate;
            this.privateCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::stikkPop.Properties.Settings.Default, "alwaysPrivate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.privateCheckBox.Location = new System.Drawing.Point(18, 185);
            this.privateCheckBox.Name = "privateCheckBox";
            this.privateCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.privateCheckBox.Size = new System.Drawing.Size(95, 17);
            this.privateCheckBox.TabIndex = 4;
            this.privateCheckBox.Text = "Always Private";
            this.privateCheckBox.UseVisualStyleBackColor = true;
            this.privateCheckBox.CheckedChanged += new System.EventHandler(this.privateCheckBox_CheckedChanged);
            // 
            // tick
            // 
            this.tick.Image = ((System.Drawing.Image)(resources.GetObject("tick.Image")));
            this.tick.Location = new System.Drawing.Point(323, 28);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(25, 20);
            this.tick.TabIndex = 13;
            this.tick.TabStop = false;
            this.tick.Visible = false;
            this.tick.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cross
            // 
            this.cross.Image = ((System.Drawing.Image)(resources.GetObject("cross.Image")));
            this.cross.Location = new System.Drawing.Point(323, 28);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(25, 20);
            this.cross.TabIndex = 14;
            this.cross.TabStop = false;
            this.cross.Visible = false;
            // 
            // autoCopyCheckBox
            // 
            this.autoCopyCheckBox.AutoSize = true;
            this.autoCopyCheckBox.Checked = global::stikkPop.Properties.Settings.Default.autoCopy;
            this.autoCopyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::stikkPop.Properties.Settings.Default, "autoCopy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autoCopyCheckBox.Location = new System.Drawing.Point(39, 208);
            this.autoCopyCheckBox.Name = "autoCopyCheckBox";
            this.autoCopyCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autoCopyCheckBox.Size = new System.Drawing.Size(74, 17);
            this.autoCopyCheckBox.TabIndex = 5;
            this.autoCopyCheckBox.Text = "Auto copy";
            this.autoCopyCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(119, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pastes are always marked as private";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(119, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Replace clipboard contents with paste URL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(119, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Open new pastes in default browser";
            // 
            // autoOpenCheckBox
            // 
            this.autoOpenCheckBox.AutoSize = true;
            this.autoOpenCheckBox.Checked = global::stikkPop.Properties.Settings.Default.autoOpen;
            this.autoOpenCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::stikkPop.Properties.Settings.Default, "autoOpen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autoOpenCheckBox.Location = new System.Drawing.Point(38, 231);
            this.autoOpenCheckBox.Name = "autoOpenCheckBox";
            this.autoOpenCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autoOpenCheckBox.Size = new System.Drawing.Size(75, 17);
            this.autoOpenCheckBox.TabIndex = 6;
            this.autoOpenCheckBox.Text = "Auto open";
            this.autoOpenCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::stikkPop.Properties.Settings.Default, "name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameBox.Location = new System.Drawing.Point(97, 75);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(220, 20);
            this.nameBox.TabIndex = 2;
            this.nameBox.Text = global::stikkPop.Properties.Settings.Default.name;
            // 
            // endpointBox
            // 
            this.endpointBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::stikkPop.Properties.Settings.Default, "endpoint", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.endpointBox.Location = new System.Drawing.Point(97, 28);
            this.endpointBox.Name = "endpointBox";
            this.endpointBox.Size = new System.Drawing.Size(220, 20);
            this.endpointBox.TabIndex = 1;
            this.endpointBox.Text = global::stikkPop.Properties.Settings.Default.endpoint;
            // 
            // Configure
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(349, 301);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.autoOpenCheckBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.autoCopyCheckBox);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.tick);
            this.Controls.Add(this.privateCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.syntaxBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endpointBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Configure";
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.Configure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox endpointBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox syntaxBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox privateCheckBox;
        private System.Windows.Forms.PictureBox tick;
        private System.Windows.Forms.PictureBox cross;
        private System.Windows.Forms.CheckBox autoCopyCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox autoOpenCheckBox;
    }
}
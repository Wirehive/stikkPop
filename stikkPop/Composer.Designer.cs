namespace stikkPop
{
    partial class Composer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Composer));
            this.composedTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.invertCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // composedTextBox
            // 
            this.composedTextBox.AcceptsReturn = true;
            this.composedTextBox.AcceptsTab = true;
            this.composedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.composedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.composedTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.composedTextBox.Location = new System.Drawing.Point(12, 12);
            this.composedTextBox.Multiline = true;
            this.composedTextBox.Name = "composedTextBox";
            this.composedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.composedTextBox.Size = new System.Drawing.Size(566, 399);
            this.composedTextBox.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubmitButton.Location = new System.Drawing.Point(12, 417);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // invertCheckBox
            // 
            this.invertCheckBox.AutoSize = true;
            this.invertCheckBox.Checked = global::stikkPop.Properties.Settings.Default.invertColours;
            this.invertCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::stikkPop.Properties.Settings.Default, "invertColours", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.invertCheckBox.Location = new System.Drawing.Point(487, 421);
            this.invertCheckBox.Name = "invertCheckBox";
            this.invertCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invertCheckBox.Size = new System.Drawing.Size(91, 17);
            this.invertCheckBox.TabIndex = 2;
            this.invertCheckBox.Text = "Invert Colours";
            this.invertCheckBox.UseVisualStyleBackColor = true;
            this.invertCheckBox.CheckedChanged += new System.EventHandler(this.invertCheckBox_CheckedChanged);
            // 
            // Composer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 452);
            this.Controls.Add(this.invertCheckBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.composedTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(484, 326);
            this.Name = "Composer";
            this.Text = "Paste Composer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox composedTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.CheckBox invertCheckBox;
    }
}
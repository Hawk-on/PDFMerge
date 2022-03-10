namespace PDFMerge
{
    partial class PDFMerge
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mergeGroupBox = new System.Windows.Forms.GroupBox();
            this.enableTargetPath = new System.Windows.Forms.CheckBox();
            this.targetBrowseButton = new System.Windows.Forms.Button();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.mergeButton = new System.Windows.Forms.Button();
            this.sourceBrowseButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mergeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mergeGroupBox
            // 
            this.mergeGroupBox.Controls.Add(this.enableTargetPath);
            this.mergeGroupBox.Controls.Add(this.targetBrowseButton);
            this.mergeGroupBox.Controls.Add(this.targetTextBox);
            this.mergeGroupBox.Controls.Add(this.targetLabel);
            this.mergeGroupBox.Controls.Add(this.mergeButton);
            this.mergeGroupBox.Controls.Add(this.sourceBrowseButton);
            this.mergeGroupBox.Controls.Add(this.pathLabel);
            this.mergeGroupBox.Controls.Add(this.sourceTextBox);
            this.mergeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mergeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mergeGroupBox.Name = "mergeGroupBox";
            this.mergeGroupBox.Size = new System.Drawing.Size(362, 147);
            this.mergeGroupBox.TabIndex = 2;
            this.mergeGroupBox.TabStop = false;
            this.mergeGroupBox.Text = "Merge PDFs";
            // 
            // enableTargetPath
            // 
            this.enableTargetPath.AutoSize = true;
            this.enableTargetPath.Location = new System.Drawing.Point(6, 53);
            this.enableTargetPath.Name = "enableTargetPath";
            this.enableTargetPath.Size = new System.Drawing.Size(151, 19);
            this.enableTargetPath.TabIndex = 7;
            this.enableTargetPath.Text = "Set different target path";
            this.enableTargetPath.UseVisualStyleBackColor = true;
            this.enableTargetPath.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // targetBrowseButton
            // 
            this.targetBrowseButton.Enabled = false;
            this.targetBrowseButton.Location = new System.Drawing.Point(274, 81);
            this.targetBrowseButton.Name = "targetBrowseButton";
            this.targetBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.targetBrowseButton.TabIndex = 6;
            this.targetBrowseButton.Text = "Browse";
            this.targetBrowseButton.UseVisualStyleBackColor = true;
            this.targetBrowseButton.Click += new System.EventHandler(this.targetBrowseButton_Click);
            // 
            // targetTextBox
            // 
            this.targetTextBox.Enabled = false;
            this.targetTextBox.Location = new System.Drawing.Point(124, 82);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(144, 23);
            this.targetTextBox.TabIndex = 5;
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(6, 85);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(103, 15);
            this.targetLabel.TabIndex = 4;
            this.targetLabel.Text = "Path to target PDF";
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(6, 113);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(337, 23);
            this.mergeButton.TabIndex = 3;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // sourceBrowseButton
            // 
            this.sourceBrowseButton.Location = new System.Drawing.Point(274, 22);
            this.sourceBrowseButton.Name = "sourceBrowseButton";
            this.sourceBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.sourceBrowseButton.TabIndex = 2;
            this.sourceBrowseButton.Text = "Browse";
            this.sourceBrowseButton.UseVisualStyleBackColor = true;
            this.sourceBrowseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(6, 25);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(112, 15);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Path to source PDFs";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(124, 22);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(144, 23);
            this.sourceTextBox.TabIndex = 0;
            // 
            // PDFMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 147);
            this.Controls.Add(this.mergeGroupBox);
            this.MaximumSize = new System.Drawing.Size(378, 186);
            this.MinimumSize = new System.Drawing.Size(378, 186);
            this.Name = "PDFMerge";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDFMerge";
            this.mergeGroupBox.ResumeLayout(false);
            this.mergeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox mergeGroupBox;
        private Label pathLabel;
        private TextBox sourceTextBox;
        private Button mergeButton;
        private Button sourceBrowseButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox enableTargetPath;
        private Button targetBrowseButton;
        private TextBox targetTextBox;
        private Label targetLabel;
    }
}
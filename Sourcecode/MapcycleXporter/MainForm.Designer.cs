namespace MapcycleXporter
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
            this.fileSelectorButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.mapFilesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fileSelectorButton
            // 
            this.fileSelectorButton.Location = new System.Drawing.Point(12, 12);
            this.fileSelectorButton.Name = "fileSelectorButton";
            this.fileSelectorButton.Size = new System.Drawing.Size(75, 20);
            this.fileSelectorButton.TabIndex = 0;
            this.fileSelectorButton.Text = "Select Maps";
            this.fileSelectorButton.UseVisualStyleBackColor = true;
            this.fileSelectorButton.Click += new System.EventHandler(this.fileSelectorButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.Location = new System.Drawing.Point(137, 11);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export!";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // mapFilesListBox
            // 
            this.mapFilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapFilesListBox.FormattingEnabled = true;
            this.mapFilesListBox.Location = new System.Drawing.Point(12, 38);
            this.mapFilesListBox.Name = "mapFilesListBox";
            this.mapFilesListBox.Size = new System.Drawing.Size(200, 186);
            this.mapFilesListBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 245);
            this.Controls.Add(this.mapFilesListBox);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.fileSelectorButton);
            this.Name = "MainForm";
            this.Text = "Mapcycle Xporter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fileSelectorButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.ListBox mapFilesListBox;
    }
}


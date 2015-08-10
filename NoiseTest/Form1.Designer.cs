namespace NoiseTest
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
            this.mDrawingPanel = new System.Windows.Forms.Panel();
            this.mCbxGeneratorSelector = new System.Windows.Forms.ComboBox();
            this.mBtnGenerateNoise = new System.Windows.Forms.Button();
            this.mGeneratorPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.mInfoLabel = new System.Windows.Forms.Label();
            this.mTaskProgress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toCurrentlyLoadedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mDrawingPanel
            // 
            this.mDrawingPanel.Location = new System.Drawing.Point(12, 27);
            this.mDrawingPanel.Name = "mDrawingPanel";
            this.mDrawingPanel.Size = new System.Drawing.Size(512, 512);
            this.mDrawingPanel.TabIndex = 0;
            // 
            // mCbxGeneratorSelector
            // 
            this.mCbxGeneratorSelector.FormattingEnabled = true;
            this.mCbxGeneratorSelector.Location = new System.Drawing.Point(530, 35);
            this.mCbxGeneratorSelector.Name = "mCbxGeneratorSelector";
            this.mCbxGeneratorSelector.Size = new System.Drawing.Size(170, 21);
            this.mCbxGeneratorSelector.TabIndex = 1;
            this.mCbxGeneratorSelector.SelectedIndexChanged += new System.EventHandler(this.mCbxGeneratorSelector_SelectedIndexChanged);
            // 
            // mBtnGenerateNoise
            // 
            this.mBtnGenerateNoise.Location = new System.Drawing.Point(706, 33);
            this.mBtnGenerateNoise.Name = "mBtnGenerateNoise";
            this.mBtnGenerateNoise.Size = new System.Drawing.Size(104, 23);
            this.mBtnGenerateNoise.TabIndex = 2;
            this.mBtnGenerateNoise.Text = "Generate Noise";
            this.mBtnGenerateNoise.UseVisualStyleBackColor = true;
            this.mBtnGenerateNoise.Click += new System.EventHandler(this.mBtnGenerateNoise_Click);
            // 
            // mGeneratorPropertyGrid
            // 
            this.mGeneratorPropertyGrid.Location = new System.Drawing.Point(531, 63);
            this.mGeneratorPropertyGrid.Name = "mGeneratorPropertyGrid";
            this.mGeneratorPropertyGrid.Size = new System.Drawing.Size(279, 472);
            this.mGeneratorPropertyGrid.TabIndex = 3;
            // 
            // mInfoLabel
            // 
            this.mInfoLabel.AutoSize = true;
            this.mInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mInfoLabel.Location = new System.Drawing.Point(9, 542);
            this.mInfoLabel.Name = "mInfoLabel";
            this.mInfoLabel.Size = new System.Drawing.Size(113, 13);
            this.mInfoLabel.TabIndex = 4;
            this.mInfoLabel.Text = "Waiting for input...";
            // 
            // mTaskProgress
            // 
            this.mTaskProgress.Location = new System.Drawing.Point(8, 558);
            this.mTaskProgress.Name = "mTaskProgress";
            this.mTaskProgress.Size = new System.Drawing.Size(798, 23);
            this.mTaskProgress.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCurrentConfigToolStripMenuItem,
            this.loadConfigFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveCurrentConfigToolStripMenuItem
            // 
            this.saveCurrentConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toNewFileToolStripMenuItem,
            this.toCurrentlyLoadedFileToolStripMenuItem});
            this.saveCurrentConfigToolStripMenuItem.Name = "saveCurrentConfigToolStripMenuItem";
            this.saveCurrentConfigToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveCurrentConfigToolStripMenuItem.Text = "Save Current Config";
            // 
            // loadConfigFileToolStripMenuItem
            // 
            this.loadConfigFileToolStripMenuItem.Name = "loadConfigFileToolStripMenuItem";
            this.loadConfigFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadConfigFileToolStripMenuItem.Text = "Load Config File";
            // 
            // toNewFileToolStripMenuItem
            // 
            this.toNewFileToolStripMenuItem.Name = "toNewFileToolStripMenuItem";
            this.toNewFileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.toNewFileToolStripMenuItem.Text = "To New File";
            // 
            // toCurrentlyLoadedFileToolStripMenuItem
            // 
            this.toCurrentlyLoadedFileToolStripMenuItem.Name = "toCurrentlyLoadedFileToolStripMenuItem";
            this.toCurrentlyLoadedFileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.toCurrentlyLoadedFileToolStripMenuItem.Text = "To Currently Loaded File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 586);
            this.Controls.Add(this.mTaskProgress);
            this.Controls.Add(this.mInfoLabel);
            this.Controls.Add(this.mGeneratorPropertyGrid);
            this.Controls.Add(this.mBtnGenerateNoise);
            this.Controls.Add(this.mCbxGeneratorSelector);
            this.Controls.Add(this.mDrawingPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NoiseTest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mDrawingPanel;
        private System.Windows.Forms.ComboBox mCbxGeneratorSelector;
        private System.Windows.Forms.Button mBtnGenerateNoise;
        private System.Windows.Forms.PropertyGrid mGeneratorPropertyGrid;
        private System.Windows.Forms.Label mInfoLabel;
        private System.Windows.Forms.ProgressBar mTaskProgress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toCurrentlyLoadedFileToolStripMenuItem;
    }
}


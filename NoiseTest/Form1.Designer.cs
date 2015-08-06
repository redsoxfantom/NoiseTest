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
            this.SuspendLayout();
            // 
            // mDrawingPanel
            // 
            this.mDrawingPanel.Location = new System.Drawing.Point(33, 0);
            this.mDrawingPanel.Name = "mDrawingPanel";
            this.mDrawingPanel.Size = new System.Drawing.Size(512, 512);
            this.mDrawingPanel.TabIndex = 0;
            // 
            // mCbxGeneratorSelector
            // 
            this.mCbxGeneratorSelector.FormattingEnabled = true;
            this.mCbxGeneratorSelector.Location = new System.Drawing.Point(33, 519);
            this.mCbxGeneratorSelector.Name = "mCbxGeneratorSelector";
            this.mCbxGeneratorSelector.Size = new System.Drawing.Size(170, 21);
            this.mCbxGeneratorSelector.TabIndex = 1;
            // 
            // mBtnGenerateNoise
            // 
            this.mBtnGenerateNoise.Location = new System.Drawing.Point(440, 519);
            this.mBtnGenerateNoise.Name = "mBtnGenerateNoise";
            this.mBtnGenerateNoise.Size = new System.Drawing.Size(104, 23);
            this.mBtnGenerateNoise.TabIndex = 2;
            this.mBtnGenerateNoise.Text = "Generate Noise";
            this.mBtnGenerateNoise.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 631);
            this.Controls.Add(this.mBtnGenerateNoise);
            this.Controls.Add(this.mCbxGeneratorSelector);
            this.Controls.Add(this.mDrawingPanel);
            this.Name = "Form1";
            this.Text = "NoiseTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mDrawingPanel;
        private System.Windows.Forms.ComboBox mCbxGeneratorSelector;
        private System.Windows.Forms.Button mBtnGenerateNoise;
    }
}


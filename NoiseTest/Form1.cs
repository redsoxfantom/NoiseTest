using NoiseTest.NoiseGenerators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoiseTest
{
    public partial class Form1 : Form
    {
        private NoiseGeneratorManager mManager;
        private Stopwatch mTimer;
        private double mStopwatchTicksPerMs;
        private bool mStopwatchIsHiRes;
        private IProgress<int> progressReporter;

        public Form1()
        {
            InitializeComponent();

            mTimer = new Stopwatch();
            long stopwatchFreq = Stopwatch.Frequency;
            mStopwatchTicksPerMs = (double)stopwatchFreq / 1000.0;
            mStopwatchIsHiRes = Stopwatch.IsHighResolution;

            mManager = new NoiseGeneratorManager();
            mManager.Init();

            progressReporter = new Progress<int>(newProgress =>
            {
                mTaskProgress.Value = newProgress;
            });
            this.mTaskProgress.Minimum = 0;
            this.mTaskProgress.Maximum = mDrawingPanel.Size.Height * mDrawingPanel.Size.Width;
            
            // Add the discovered noise generators to the solution
            mCbxGeneratorSelector.Items.Clear();
            mCbxGeneratorSelector.Items.AddRange(mManager.GetGeneratorNames());
        }

        private async void mBtnGenerateNoise_Click(object sender, EventArgs e)
        {
            mInfoLabel.Text = "Working...";
            mTimer.Start();
            string selectedGenerator = (string)mCbxGeneratorSelector.SelectedItem;
            int width = mDrawingPanel.Size.Width;
            int height = mDrawingPanel.Size.Height;

            Image noiseImage = await Task.Run<Image>(() => { return mManager.GenerateNoiseImage(selectedGenerator, width, height, progressReporter); });

            mDrawingPanel.BackgroundImage = noiseImage;
            mTimer.Stop();
            long ticksTaken = mTimer.ElapsedTicks;
            double msTaken = (double)ticksTaken / mStopwatchTicksPerMs;
            mTimer.Reset();
            mInfoLabel.Text = string.Format("Done in {0:F5} ms. Stopwatch {1} high resolution.", msTaken, mStopwatchIsHiRes ? "is" : "is not");
        }

        private void mCbxGeneratorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenerator = (string)mCbxGeneratorSelector.SelectedItem;
            INoiseGenerator generator = mManager.GetGenerator(selectedGenerator);
            mGeneratorPropertyGrid.SelectedObject = generator;
        }
    }
}

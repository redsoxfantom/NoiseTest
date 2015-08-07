using NoiseTest.NoiseGenerators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Form1()
        {
            InitializeComponent();

            mManager = new NoiseGeneratorManager();
            mManager.Init();
            
            // Add the discovered noise generators to the solution
            mCbxGeneratorSelector.Items.Clear();
            mCbxGeneratorSelector.Items.AddRange(mManager.GetGeneratorNames());
        }

        private async void mBtnGenerateNoise_Click(object sender, EventArgs e)
        {
            string selectedGenerator = (string)mCbxGeneratorSelector.SelectedItem;
            int width = mDrawingPanel.Size.Width;
            int height = mDrawingPanel.Size.Height;
            Image noiseImage = await Task.Run<Image>(() => { return mManager.GenerateNoiseImage(selectedGenerator, width, height); });

            mDrawingPanel.BackgroundImage = noiseImage;
        }

        private void mCbxGeneratorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenerator = (string)mCbxGeneratorSelector.SelectedItem;
            INoiseGenerator generator = mManager.GetGenerator(selectedGenerator);
            mGeneratorPropertyGrid.SelectedObject = generator;
        }
    }
}

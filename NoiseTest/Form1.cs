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

        private void mBtnGenerateNoise_Click(object sender, EventArgs e)
        {
            string selectedGenerator = (string)mCbxGeneratorSelector.SelectedItem;
            Image noiseImage = mManager.GenerateNoiseImage(selectedGenerator,mDrawingPanel.Size.Width, mDrawingPanel.Size.Height);

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

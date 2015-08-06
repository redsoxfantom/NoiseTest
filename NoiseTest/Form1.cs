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
        public Form1()
        {
            InitializeComponent();

            // Get all the INoiseGenerators in this program
            Assembly currAsm = Assembly.GetExecutingAssembly();
            var types = from type in currAsm.GetTypes()
                        where typeof(INoiseGenerator).IsAssignableFrom(type)
                        select type.Name;

            // Add the discovered noise generators to the solution
            mCbxGeneratorSelector.Items.AddRange(types.ToArray<string>());
        }
    }
}

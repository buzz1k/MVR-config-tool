using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVRConfig
{
    public partial class MainForm : Form
    {
        public string[] deviceSettings;

        public MainForm()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog s1 = new SaveFileDialog();
            s1.Filter = "INI File | *.ini";

            if (s1.ShowDialog() == DialogResult.OK)
            { 

            }

        }
    }
}

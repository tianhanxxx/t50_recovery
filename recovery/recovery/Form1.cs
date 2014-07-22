using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using xml;

namespace recovery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            ThintaXMLConfig.DefaultConfig["test", "test"] = "1";
            ThintaXMLConfig.DefaultConfig.Save();
        }
    }
}
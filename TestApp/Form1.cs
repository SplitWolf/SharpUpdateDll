using SharpUpdate;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form, ISharpUpdatable
    {
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = this.ApplicationAssembly.GetName().Version.ToString();
        }

        public string ApplicationName
        {
            get { return "TestApp"; }
        }
        public string ApplicationID
        {
            get { return "TestApp"; }
        }
        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }
        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }
        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://raw.githubusercontent.com/MWolf88/TestApp/master/update.xml"); }
        }
        public Form Context
        {
            get { return this; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}

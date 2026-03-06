using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTM_Client_AIF21
{
    public partial class Form1 : Form
    {
        public event EventHandler ButtonClicked;
        public Form1()
        {
            InitializeComponent();
        }
        public string GetInput()
        {
            return textBox1.Text;
        }
        public void SetOutput(string text)
        {
            label1.Text = text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

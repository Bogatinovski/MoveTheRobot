using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveTheRobot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void robotConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateConfiguratonForm form = new CreateConfiguratonForm();
            DialogResult result = form.ShowDialog();

            if(result == DialogResult.OK)
            {
                Debug.WriteLine("Result OKAY");
                Debug.WriteLine(form.RobotConfiguration.ToString());
            }
            else
            {
                Debug.WriteLine("Result BAD");
            }
        }
    }
}

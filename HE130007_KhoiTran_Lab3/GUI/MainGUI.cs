using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HE130007_KhoiTran_Lab3.GUI
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
         
            InitializeComponent();
        }
        private void embed(Panel panel, Form f)
        {
            panel.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Show();

            panel.Controls.Add(f);

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookGUI f = new BookGUI();
            embed(toolStripContainer1.ContentPanel, f);

        }

        private void borroweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowerGUI f1 = new BorrowerGUI();
            embed(toolStripContainer1.ContentPanel, f1);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutGUI f5 = new AboutGUI();
            embed(toolStripContainer1.ContentPanel, f5);
        }
    }
}

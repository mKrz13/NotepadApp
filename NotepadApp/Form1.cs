/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}*/

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;

using System.IO;



namespace NotepadApp

{

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)

        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)

        {

            txtContent.Text = "";

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)

        {

            openFileDialog1.ShowDialog();

            //Now it show open dialog box.

            //Read the filename selected by the user with in open file dialog box.

            string fName = openFileDialog1.FileName;

            //Read the data by using StreamReader class

            StreamReader sr = new StreamReader(fName);

            txtContent.Text = sr.ReadToEnd();

            sr.Close();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)

        {

            saveFileDialog1.ShowDialog();

            string fName = saveFileDialog1.FileName;

            StreamWriter sw = new StreamWriter(fName);

            sw.Write(txtContent.Text);

            sw.Flush();

            sw.Close();

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)

        {

            printDialog1.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)

        {

            Application.Exit();

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)

        {

            txtContent.Cut();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)

        {

            txtContent.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)

        {

            txtContent.Paste();

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)

        {

            txtContent.SelectAll();

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)

        {

            fontDialog1.ShowDialog();

            txtContent.Font = fontDialog1.Font;

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)

        {

            colorDialog1.ShowDialog();

            txtContent.ForeColor = colorDialog1.Color;

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)

        {

            

            Form f = new Form();

            Label ll = new Label();

            ll.Text = "Łukasz Andrzejewski";

            ll.Font = new Font("Arial", 20);

            ll.Dock = DockStyle.Fill;

            f.Controls.Add(ll);

            f.Show();

        }

    }

}

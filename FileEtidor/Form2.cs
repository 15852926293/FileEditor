using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEtidor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Do you want to save changes ?","FileEditor",MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.No)
            {
                this.Close();
            }
            else if (dr == DialogResult.Yes)
            {
                string fileStream = richTextBox1.Text.ToString();
                FileRW.fileWriter(GlobalConfig.FilePath, fileStream);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileStream = richTextBox1.Text.ToString();
            FileRW.fileWriter(GlobalConfig.FilePath, fileStream);
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileEtidor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool GetFilePath()
        {
            FileStream fs = null;
            string FilePath = textBox1.Text.ToString();
            GlobalConfig.FilePath = FilePath;
            if (!FilePath.Contains(@"\"))
            {
                MessageBox.Show("Illegal file paht !", "FileEditor", MessageBoxButtons.OK);
                return false;
            }
            if (File.Exists(FilePath) == false)
            {
                try
                {
                    fs = File.Create(FilePath);
                    fs.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Illegal file path !", "FileEditor", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetFilePath() == true)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }           
        }
    }
}

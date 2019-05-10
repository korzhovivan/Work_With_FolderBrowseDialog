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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        string fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {
            
            
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                fileName = directchoosedlg.SelectedPath;
                
            }
            string[] filesNames = Directory.GetFiles(fileName);
            List<string> filesNamesWithFilter = new List<string>();
            foreach (string item in filesNames)
            {
                if(new FileInfo(item).Extension == txtBox_Filter.Text)
                {
                    filesNamesWithFilter.Add(item);
                }
            }

            foreach (string item in filesNamesWithFilter)
            {
                listBox1.Items.Add(Path.GetFileName(item));
            }
        }
    }
}

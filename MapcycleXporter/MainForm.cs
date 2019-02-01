using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapcycleXporter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "All files |.";

            if(save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);

                for (int i = 0; i < mapFilesListBox.Items.Count; i++)
                {
                    writer.WriteLine(mapFilesListBox.Items[i]);
                }

                writer.Close();
            }

            MessageBox.Show("Maps are exported!");
        }

        private void fileSelectorButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                string dir = folder.SelectedPath;
                string[] mapFiles = Directory.GetFiles(dir, "*.bsp", SearchOption.AllDirectories).Select(Path.GetFileNameWithoutExtension).ToArray();
                

                for(int i = 0; i < mapFiles.Length; i++)
                {
                    mapFilesListBox.Items.Add(mapFiles[i]);
                }
            }
        }
    }
}

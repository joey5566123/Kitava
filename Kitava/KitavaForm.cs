using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Kitava.GUI
{
    [System.ComponentModel.DesignerCategory("code")]
    public partial class KitavaForm : Form
    {
        public KitavaForm()
        {
            InitializeComponent();
            InitializeHotKey();
        }

        private string FindDirectory(string beginDirectoryPath, string targetDirectoryName)
        {
            try
            {
                var directories = Directory.GetDirectories(beginDirectoryPath).ToList();

                directories.Reverse();
                foreach (var directory in directories)
                {
                    if (directory.Contains(targetDirectoryName))
                    {
                        return directory;
                    }
                    else
                    {
                        var subDirectory = FindDirectory(directory, targetDirectoryName);

                        if (subDirectory != string.Empty)
                        {
                            return subDirectory;
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                return string.Empty;
            }
            catch (FileNotFoundException)
            {
                return string.Empty;
            }
            return string.Empty;
        }

        private void clickFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
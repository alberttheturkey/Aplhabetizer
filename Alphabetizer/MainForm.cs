using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alphabetizer
{
    public partial class Alphabetizer : Form
    {
        public Alphabetizer()
        {
            InitializeComponent();
        }

        private void btnOrganize_Click(object sender, EventArgs e)
        {

            // Specify a name for your top-level folder and sorting folders
            string folderName = tbStartFolder.Text;
            String[] folders = { "!", "#", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            if (folderName == "")
            {
                MessageBox.Show("Please Input a folder name");
                return;
            }
            for (int i = 0; i < folders.Length; i++)
            {
                String letter = folders[i];
                // To create a string that specifies the path to a subfolder under your 
                // top-level folder, add a name for the subfolder to folderName.
                string pathString = Path.Combine(folderName, letter);
                Directory.CreateDirectory(pathString);

                // Terrible terrible way of detecting the number folder
                String[] filePaths;
                if (i == 1)
                    filePaths = Directory.GetFiles(folderName).Where(file => Regex.IsMatch(Path.GetFileName(file), "^[0-9]+")).ToArray();
                else
                    filePaths = Directory.GetFiles(folderName, letter + "*");

                // Lets move some files!
                foreach (String origPath in filePaths)
                {

                    moveFile(origPath, pathString);                    
                }
            }

            // Handle any remaining files, they go in the symbol folder
            foreach (String origPath in Directory.GetFiles(folderName))
                moveFile(origPath, Path.Combine(folderName, folders[0]));

        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
                tbStartFolder.Text = fbd.SelectedPath;
        }

        private void moveFile(String origPath, String folderPath)
        {            
            String newPath = Path.Combine(folderPath, Path.GetFileName(origPath));
            if (!File.Exists(newPath))
                File.Move(origPath, newPath);

            // Allow the user to overwrite an existing file without invoking an exception
            else
            {
                // Generate a dialog to ask the user if they want to overwrite the file
                DialogResult dResult = MessageBox.Show("File already exists at path " + newPath + ". Overwrite?", "Overwrite?", MessageBoxButtons.YesNoCancel);

                // Handle the overwrite without an exception
                if (dResult == DialogResult.Yes)
                {
                    File.Delete(newPath);
                    File.Move(origPath, newPath);
                }

                // Give the user a chance to stop if a lot of files are found
                else if (dResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Operation Aborted");
                    return;
                }
            }
        }
    }
}

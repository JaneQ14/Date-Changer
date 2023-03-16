using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Date_Changer
{
    public partial class DateChanger : Form
    {
        public DateChanger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            target_comboBox.SelectedIndex = 0;
            changeIndex = target_comboBox.SelectedIndex;
            folder_radio.Checked = true;

            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
        }

        private string ChoosePath()
        {
            switch (folderFile)
            {
                case FolderFile.folder:
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            pathBox.Text = fbd.SelectedPath;
                        }
                        return fbd.SelectedPath;
                    }
                case FolderFile.file:
                    using (var ofd = new OpenFileDialog())
                    {
                        DialogResult result = ofd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                        {
                            pathBox.Text = ofd.FileName;
                        }
                        return ofd.FileName;
                    }
            }

            return string.Empty;
        }

        private void ResetValues()
        {
            files = new List<FileInfo>();
            folders = new List<DirectoryInfo>();
            Change_button.Enabled = false;
            info_text.Text = string.Empty;

            string temp = pathBox.Text;
            pathBox.Text = string.Empty;
            pathBox.Text = temp;
        }

        DateTime date = new DateTime();
        List<FileInfo> files = new List<FileInfo>();  // List that will hold the files and subfiles in path
        List<DirectoryInfo> folders = new List<DirectoryInfo>(); // List that hold direcotries that cannot be accessed
        int changeIndex;
        private enum FolderFile{folder,file}
        private FolderFile folderFile;

        void FullDirList(DirectoryInfo dir, string searchPattern)
        {
            // Console.WriteLine("Directory {0}", dir.FullName);
            // list the files
            try
            {
                foreach (FileInfo f in dir.GetFiles(searchPattern))
                {
                    //Console.WriteLine("File {0}", f.FullName);
                    files.Add(f);
                }
            }
            catch
            {
                MessageBox.Show(dir.FullName, "error - no permission");
                //Console.WriteLine("Directory {0}  \n could not be accessed!!!!", dir.FullName);
                return;  // We alredy got an error trying to access dir so dont try to access it again
            }

            // process each directory
            // If I have been able to see the files in the directory I should also be able 
            // to look at its directories so I dont think I should place this in a try catch block
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                folders.Add(d);
                FullDirList(d, searchPattern);
            }
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            try
            {
                SetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error.");
            }
        }
        
        private void SetData()
        {
            var dP = datePicker.Value;
            var tP = timePicker.Value;
            date = new DateTime(dP.Year, dP.Month, dP.Day, tP.Hour, tP.Minute, tP.Second);

            /*
            0 - All Files & Directories & Main Directory
            1 - All Files & Directories
            2 - All Files 
            3 - All Directories
            4 - Main Directory
            */

            //Main Directory
            if (changeIndex == 0 || changeIndex == 4)
            {
                Directory.SetCreationTime(pathBox.Text, date);
                Directory.SetLastAccessTime(pathBox.Text, date);
                Directory.SetLastWriteTime(pathBox.Text, date);
            }
            //Files
            if (changeIndex == 0 || changeIndex == 1 || changeIndex == 2)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    File.SetCreationTime(files[i].FullName, date);
                    File.SetLastAccessTime(files[i].FullName, date);
                    File.SetLastWriteTime(files[i].FullName, date);
                }   
            }
            //Folders
            if (changeIndex == 0 ||  changeIndex == 1 || changeIndex == 3)
            {
                for (int i = 0; i < folders.Count; i++)
                {
                    Directory.SetCreationTime(folders[i].FullName, date);
                    Directory.SetLastAccessTime(folders[i].FullName, date);
                    Directory.SetLastWriteTime(folders[i].FullName, date);
                }
            }

            MessageBox.Show(datePicker.Value.ToShortDateString() + " " + timePicker.Value.ToShortTimeString(), "Date has been set");
        }

        private void target_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeIndex = target_comboBox.SelectedIndex;
        }

        private void browse_Button_Click(object sender, EventArgs e)
        {
            ChoosePath();
        }

        private void pathBox_TextChanged(object sender, EventArgs e)
        {
            bool exist = false;

            switch (folderFile)
            {
                case FolderFile.folder:
                    exist = Directory.Exists(pathBox.Text);
                    break;
                case FolderFile.file:
                    exist = File.Exists(pathBox.Text);
                    break;
            }

            if(exist)
            {
                pathBox.ForeColor = Color.Black;
                ok_button.Enabled = true;
            }
            else
            {
                pathBox.ForeColor = Color.Red;
                ok_button.Enabled = false;

                Change_button.Enabled = false;
            }
        }

        private void RefreshValues()
        {
            ResetValues();

            switch (folderFile)
            {
                case FolderFile.folder:
                    if (Directory.Exists(pathBox.Text))
                    {
                        DirectoryInfo di = new DirectoryInfo(pathBox.Text);
                        FullDirList(di, "*");
                    }
                    else
                    {
                        MessageBox.Show("no directory found.", "error");
                        return;
                    }
                    break;
                case FolderFile.file:
                    if (File.Exists(pathBox.Text))
                    {
                        FileInfo fi = new FileInfo(pathBox.Text);
                        files.Add(fi);
                    }
                    else
                    {
                        MessageBox.Show("no file found.", "error");
                        return;
                    }
                    break;
            }

            pathBox.ForeColor = Color.Green;
            ok_button.Enabled = false;
            Change_button.Enabled = true;
            info_text.Text = "Folders found: " + folders.Count + "\nFiles found: " + files.Count;
        }

        private void ok_button_Click_1(object sender, EventArgs e)
        {
            RefreshValues();
        }

        private void textbox_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
        }

        private void textBox_DragDrop(object sender, DragEventArgs e)
        {
            var textBox = (TextBox)sender;
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; 
            if (files != null && files.Any())
                textBox.Text = files.First(); 
        }

        private void FolderFile_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (folder_radio.Checked)
            {
                folderFile = FolderFile.folder;
                target_comboBox.Visible = true;
            }
            else if (file_radio.Checked)
            {
                folderFile = FolderFile.file;
                target_comboBox.SelectedIndex = 1;
                target_comboBox.Visible = false;
            }

            switch(folderFile)
            {
                case FolderFile.file:
                    selectedPathString.Text = "Select file path:";
                break;
                case FolderFile.folder:
                    selectedPathString.Text = "Select folder path:";
                    break;
            }

            ResetValues();
        }
    }
}

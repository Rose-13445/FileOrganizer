using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileOrganizer;

public partial class FileOrganizerForm : Form
{
    public FileOrganizerForm()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
        using var folderDialog = new FolderBrowserDialog();
        if (folderDialog.ShowDialog() == DialogResult.OK)
        {
            lblFolderPath.Text = folderDialog.SelectedPath;
        }
    }

    List<(string oldPath, string newPath)> movedFiles = new();
    private void btnOrganize_Click(object sender, EventArgs e)
    {
        string folderPath = lblFolderPath.Text;

        if (!Directory.Exists(folderPath))
        {
            MessageBox.Show("Please select a valid folder first.");
            return;
        }

        string[] files = Directory.GetFiles(folderPath);

        foreach (string file in files)
        {
            string extension = Path.GetExtension(file).TrimStart('.').ToLower();
            if (string.IsNullOrWhiteSpace(extension))
                extension = "no_extension";

            string newFolder = Path.Combine(folderPath, extension);
            if (!Directory.Exists(newFolder))
                Directory.CreateDirectory(newFolder);

            string fileName = Path.GetFileName(file);
            string newPath = Path.Combine(newFolder, fileName);

            try
            {
                File.Move(file, newPath);
                lstLog.Items.Add($"Moved {fileName} -> {extension} folder");
                movedFiles.Add((file, newPath));
            }
            catch (Exception ex)
            {
                lstLog.Items.Add($"Error moving {fileName}: {ex.Message}");
            }
        }

        MessageBox.Show("Organization Complete!");
    }

    private void btnUndo_Click(object sender, EventArgs e)
    {
        //Move files back to original path from their new path
        if (movedFiles.Count > 0)
        {
            foreach (var file in movedFiles)
            {
                string fileName = Path.GetFileName(file.newPath);

                try
                {
                    File.Move(file.newPath, file.oldPath);
                    movedFiles.Remove(file);
                    lstLog.Items.Add($"Moved {fileName} back to original path");
                }
                catch (Exception ex)
                {
                    lstLog.Items.Add($"Error moving {fileName}: {ex.Message}");
                }
            }

            MessageBox.Show("Undo complete!");
        }
        else
        {
            MessageBox.Show("There is nothing to undo.");
        }
    }
}

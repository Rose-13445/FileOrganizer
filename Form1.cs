using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileOrganizer;

public partial class Form1 : Form
{
    public Form1()
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

    private List<(string Source, string Destination)> moveHistory = new();
    private List<string> createdFolders = new();

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
            {
                Directory.CreateDirectory(newFolder);
                createdFolders.Add(newFolder);
            }

            string fileName = Path.GetFileName(file);
            string newPath = Path.Combine(newFolder, fileName);

            try
            {
                File.Move(file, newPath);
                lstLog.Items.Add($"Moved {fileName} -> {extension} folder");

                moveHistory.Add((file, newPath));
            }
            catch (Exception ex)
            {
                lstLog.Items.Add($"Error moving {fileName}: {ex.Message}");
            }


        }

        MessageBox.Show("Organization Complete!");
    }

    private void lblFolderPath_Click(object sender, EventArgs e)
    {

    }

    private void btnUndo_Click(object sender, EventArgs e)
    {
        foreach (var move in moveHistory)
        {
            if (File.Exists(move.Destination))
            {
                File.Move(move.Destination, move.Source);
            }
        }

        moveHistory.Clear();
        MessageBox.Show("Undo complete!");

        foreach (string folder in createdFolders)
        {

            string folderName = Path.GetFileName(folder);

            if (Directory.Exists(folder) && Directory.GetFiles(folder).Length == 0)
            {
                Directory.Delete(folder);
                lstLog.Items.Add($"Moved files back and deleted {folderName} folder");
            }
        }
    }
}

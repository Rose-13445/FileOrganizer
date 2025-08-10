using System.Drawing;
using System.Windows.Forms;

namespace FileOrganizer;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnSelectFolder = new Button();
        lblFolderPath = new Label();
        btnOrganize = new Button();
        lstLog = new ListBox();
        SuspendLayout();
        // 
        // btnSelectFolder
        // 
        btnSelectFolder.Anchor = AnchorStyles.Bottom;
        btnSelectFolder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSelectFolder.Location = new Point(12, 27);
        btnSelectFolder.Name = "btnSelectFolder";
        btnSelectFolder.Size = new Size(97, 23);
        btnSelectFolder.TabIndex = 0;
        btnSelectFolder.Text = "Select Folder";
        btnSelectFolder.UseVisualStyleBackColor = true;
        btnSelectFolder.Click += btnSelectFolder_Click;
        // 
        // lblFolderPath
        // 
        lblFolderPath.AutoSize = true;
        lblFolderPath.Location = new Point(12, 9);
        lblFolderPath.Name = "lblFolderPath";
        lblFolderPath.Size = new Size(103, 15);
        lblFolderPath.TabIndex = 1;
        lblFolderPath.Text = "No folder selected";
        // 
        // btnOrganize
        // 
        btnOrganize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnOrganize.Location = new Point(115, 27);
        btnOrganize.Name = "btnOrganize";
        btnOrganize.Size = new Size(95, 23);
        btnOrganize.TabIndex = 2;
        btnOrganize.Text = "Organize Files";
        btnOrganize.UseVisualStyleBackColor = true;
        btnOrganize.Click += btnOrganize_Click;
        // 
        // lstLog
        // 
        lstLog.FormattingEnabled = true;
        lstLog.ItemHeight = 15;
        lstLog.Location = new Point(12, 56);
        lstLog.Name = "lstLog";
        lstLog.Size = new Size(120, 94);
        lstLog.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lstLog);
        Controls.Add(btnOrganize);
        Controls.Add(lblFolderPath);
        Controls.Add(btnSelectFolder);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnSelectFolder;
    private Label lblFolderPath;
    private Button btnOrganize;
    private ListBox lstLog;
}

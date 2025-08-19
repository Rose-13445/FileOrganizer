using System.Drawing;
using System.Windows.Forms;

namespace FileOrganizer;

partial class FileOrganizerForm
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
        btnUndo = new Button();
        SuspendLayout();
        // 
        // btnSelectFolder
        // 
        btnSelectFolder.Anchor = AnchorStyles.Bottom;
        btnSelectFolder.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSelectFolder.Location = new Point(12, 27);
        btnSelectFolder.Name = "btnSelectFolder";
        btnSelectFolder.Size = new Size(97, 22);
        btnSelectFolder.TabIndex = 0;
        btnSelectFolder.Text = "Select Folder";
        btnSelectFolder.UseVisualStyleBackColor = true;
        btnSelectFolder.Click += btnSelectFolder_Click;
        // 
        // lblFolderPath
        // 
        lblFolderPath.AutoSize = true;
        lblFolderPath.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblFolderPath.Location = new Point(12, 8);
        lblFolderPath.Name = "lblFolderPath";
        lblFolderPath.Size = new Size(111, 16);
        lblFolderPath.TabIndex = 1;
        lblFolderPath.Text = "No folder selected";
        // 
        // btnOrganize
        // 
        btnOrganize.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnOrganize.Location = new Point(115, 27);
        btnOrganize.Name = "btnOrganize";
        btnOrganize.Size = new Size(95, 22);
        btnOrganize.TabIndex = 2;
        btnOrganize.Text = "Organize Files";
        btnOrganize.UseVisualStyleBackColor = true;
        btnOrganize.Click += btnOrganize_Click;
        // 
        // lstLog
        // 
        lstLog.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lstLog.FormattingEnabled = true;
        lstLog.Location = new Point(12, 66);
        lstLog.Name = "lstLog";
        lstLog.Size = new Size(776, 372);
        lstLog.TabIndex = 3;
        // 
        // btnUndo
        // 
        btnUndo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnUndo.Location = new Point(713, 27);
        btnUndo.Name = "btnUndo";
        btnUndo.Size = new Size(75, 22);
        btnUndo.TabIndex = 4;
        btnUndo.Text = "Undo";
        btnUndo.UseVisualStyleBackColor = true;
        btnUndo.Click += btnUndo_Click;
        // 
        // FileOrganizer
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnUndo);
        Controls.Add(lstLog);
        Controls.Add(btnOrganize);
        Controls.Add(lblFolderPath);
        Controls.Add(btnSelectFolder);
        Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Name = "FileOrganizer";
        Text = "File Organizer";
        Load += FileOrganizerForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnSelectFolder;
    private Label lblFolderPath;
    private Button btnOrganize;
    private ListBox lstLog;
    private Button btnUndo;
}

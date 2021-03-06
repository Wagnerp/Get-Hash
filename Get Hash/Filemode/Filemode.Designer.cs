﻿/*
This file is part of the Get Hash Source Code.  

Get Hash is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Get Hash is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Get Hash. If not, see <http://www.gnu.org/licenses/gpl.html>.

The complete source code can be found at <https://github.com/Nepochal/Get-Hash>.

The implementation of the CRC32-algorithm was taken
from <http://dotnet-snippets.de/dns/crc32---checksumme-einer-datei-berechnen-SID1306.aspx>
and is copyrighted by Qchen

*/

namespace Nepochal.GetHash
{
  partial class Filemode
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filemode));
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.buttonChooseFile = new System.Windows.Forms.Button();
      this.comboBoxHashtype = new System.Windows.Forms.ComboBox();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.textBoxCompare = new System.Windows.Forms.TextBox();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.überGetHashToolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.labelFilename = new System.Windows.Forms.Label();
      this.labelInfo = new System.Windows.Forms.Label();
      this.openFileDialogChooseFile = new System.Windows.Forms.OpenFileDialog();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemSelectLanguage = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemMode = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemTextMode = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemFileMode = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonChooseFile
      // 
      this.buttonChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonChooseFile.BackColor = System.Drawing.Color.Transparent;
      this.buttonChooseFile.BackgroundImage = global::Nepochal.GetHash.Properties.Resources.openfile;
      this.buttonChooseFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.buttonChooseFile.Location = new System.Drawing.Point(262, 31);
      this.buttonChooseFile.Name = "buttonChooseFile";
      this.buttonChooseFile.Size = new System.Drawing.Size(25, 25);
      this.buttonChooseFile.TabIndex = 3;
      this.buttonChooseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.toolTip.SetToolTip(this.buttonChooseFile, "Select file");
      this.buttonChooseFile.UseVisualStyleBackColor = false;
      this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
      // 
      // comboBoxHashtype
      // 
      this.comboBoxHashtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxHashtype.FormattingEnabled = true;
      this.comboBoxHashtype.Location = new System.Drawing.Point(9, 33);
      this.comboBoxHashtype.Name = "comboBoxHashtype";
      this.comboBoxHashtype.Size = new System.Drawing.Size(86, 21);
      this.comboBoxHashtype.Sorted = true;
      this.comboBoxHashtype.TabIndex = 4;
      this.toolTip.SetToolTip(this.comboBoxHashtype, "Hashverfahren");
      this.comboBoxHashtype.SelectedValueChanged += new System.EventHandler(this.comboBoxHashtype_SelectedValueChanged);
      // 
      // textBoxResult
      // 
      this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxResult.BackColor = System.Drawing.SystemColors.Window;
      this.textBoxResult.Location = new System.Drawing.Point(9, 62);
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ReadOnly = true;
      this.textBoxResult.Size = new System.Drawing.Size(278, 20);
      this.textBoxResult.TabIndex = 5;
      this.textBoxResult.Tag = "Hash value";
      this.textBoxResult.Text = "Hash value";
      this.toolTip.SetToolTip(this.textBoxResult, "Hash value");
      // 
      // textBoxCompare
      // 
      this.textBoxCompare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxCompare.BackColor = System.Drawing.SystemColors.Window;
      this.textBoxCompare.Location = new System.Drawing.Point(9, 88);
      this.textBoxCompare.Name = "textBoxCompare";
      this.textBoxCompare.Size = new System.Drawing.Size(278, 20);
      this.textBoxCompare.TabIndex = 6;
      this.textBoxCompare.Tag = "Reference value";
      this.textBoxCompare.Text = "Reference value";
      this.toolTip.SetToolTip(this.textBoxCompare, "Reference value");
      this.textBoxCompare.Enter += new System.EventHandler(this.textBoxCompare_Enter);
      // 
      // buttonCancel
      // 
      this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCancel.Enabled = false;
      this.buttonCancel.Location = new System.Drawing.Point(212, 113);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 8;
      this.buttonCancel.Tag = "Cancel";
      this.buttonCancel.Text = "Cancel";
      this.toolTip.SetToolTip(this.buttonCancel, "Cancel calculation");
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
      // 
      // überGetHashToolStripMenuAbout
      // 
      this.überGetHashToolStripMenuAbout.Name = "überGetHashToolStripMenuAbout";
      this.überGetHashToolStripMenuAbout.Size = new System.Drawing.Size(144, 22);
      this.überGetHashToolStripMenuAbout.Text = "Über Get Hash";
      this.überGetHashToolStripMenuAbout.Click += new System.EventHandler(this.überGetHashToolStripMenuAbout_Click);
      // 
      // labelFilename
      // 
      this.labelFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelFilename.AutoEllipsis = true;
      this.labelFilename.Location = new System.Drawing.Point(101, 37);
      this.labelFilename.Name = "labelFilename";
      this.labelFilename.Size = new System.Drawing.Size(155, 15);
      this.labelFilename.TabIndex = 2;
      this.labelFilename.Tag = "Select file";
      this.labelFilename.Text = "Select a file...";
      // 
      // labelInfo
      // 
      this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelInfo.Location = new System.Drawing.Point(9, 118);
      this.labelInfo.Name = "labelInfo";
      this.labelInfo.Size = new System.Drawing.Size(202, 15);
      this.labelInfo.TabIndex = 7;
      this.labelInfo.Tag = "Ready";
      this.labelInfo.Text = "Ready";
      // 
      // openFileDialogChooseFile
      // 
      this.openFileDialogChooseFile.Filter = "Alle Dateien|*.*";
      this.openFileDialogChooseFile.Title = "Datei wählen";
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemMode,
            this.toolStripMenuItemHelp});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(293, 24);
      this.menuStrip.TabIndex = 9;
      this.menuStrip.Text = "menuStrip1";
      // 
      // toolStripMenuItemFile
      // 
      this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSelectLanguage,
            this.toolStripMenuItem2,
            this.toolStripMenuItemExit});
      this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
      this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
      this.toolStripMenuItemFile.Tag = "File";
      this.toolStripMenuItemFile.Text = "&File";
      // 
      // ToolStripMenuItemSelectLanguage
      // 
      this.ToolStripMenuItemSelectLanguage.Name = "ToolStripMenuItemSelectLanguage";
      this.ToolStripMenuItemSelectLanguage.Size = new System.Drawing.Size(157, 22);
      this.ToolStripMenuItemSelectLanguage.Tag = "Select language";
      this.ToolStripMenuItemSelectLanguage.Text = "Select language";
      this.ToolStripMenuItemSelectLanguage.Click += new System.EventHandler(this.ToolStripMenuItemSelectLanguage_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 6);
      // 
      // toolStripMenuItemExit
      // 
      this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
      this.toolStripMenuItemExit.Size = new System.Drawing.Size(157, 22);
      this.toolStripMenuItemExit.Tag = "Exit";
      this.toolStripMenuItemExit.Text = "Exit";
      this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
      // 
      // toolStripMenuItemMode
      // 
      this.toolStripMenuItemMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTextMode,
            this.toolStripMenuItemFileMode});
      this.toolStripMenuItemMode.Name = "toolStripMenuItemMode";
      this.toolStripMenuItemMode.Size = new System.Drawing.Size(50, 20);
      this.toolStripMenuItemMode.Tag = "Mode";
      this.toolStripMenuItemMode.Text = "&Mode";
      // 
      // toolStripMenuItemTextMode
      // 
      this.toolStripMenuItemTextMode.Name = "toolStripMenuItemTextMode";
      this.toolStripMenuItemTextMode.ShortcutKeys = System.Windows.Forms.Keys.F2;
      this.toolStripMenuItemTextMode.Size = new System.Drawing.Size(152, 22);
      this.toolStripMenuItemTextMode.Tag = "Textmode";
      this.toolStripMenuItemTextMode.Text = "Textmode";
      this.toolStripMenuItemTextMode.Click += new System.EventHandler(this.toolStripMenuItemTextMode_Click);
      // 
      // toolStripMenuItemFileMode
      // 
      this.toolStripMenuItemFileMode.Checked = true;
      this.toolStripMenuItemFileMode.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripMenuItemFileMode.Name = "toolStripMenuItemFileMode";
      this.toolStripMenuItemFileMode.ShortcutKeys = System.Windows.Forms.Keys.F3;
      this.toolStripMenuItemFileMode.Size = new System.Drawing.Size(152, 22);
      this.toolStripMenuItemFileMode.Tag = "Filemode";
      this.toolStripMenuItemFileMode.Text = "Filemode";
      // 
      // toolStripMenuItemHelp
      // 
      this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout});
      this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
      this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
      this.toolStripMenuItemHelp.Tag = "Help";
      this.toolStripMenuItemHelp.Text = "&Help";
      // 
      // toolStripMenuItemAbout
      // 
      this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
      this.toolStripMenuItemAbout.Size = new System.Drawing.Size(158, 22);
      this.toolStripMenuItemAbout.Tag = "About";
      this.toolStripMenuItemAbout.Text = "About Get Hash";
      this.toolStripMenuItemAbout.Click += new System.EventHandler(this.überGetHashToolStripMenuAbout_Click);
      // 
      // Filemode
      // 
      this.AllowDrop = true;
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(293, 142);
      this.Controls.Add(this.menuStrip);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.labelInfo);
      this.Controls.Add(this.textBoxCompare);
      this.Controls.Add(this.textBoxResult);
      this.Controls.Add(this.comboBoxHashtype);
      this.Controls.Add(this.buttonChooseFile);
      this.Controls.Add(this.labelFilename);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(10000, 180);
      this.MinimumSize = new System.Drawing.Size(302, 180);
      this.Name = "Filemode";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Get Hash";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Filemode_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Filemode_FormClosed);
      this.Load += new System.EventHandler(this.Filemode_Load);
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Filemode_DragDrop);
      this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Filemode_DragEnter);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem überGetHashToolStripMenuAbout;
    private System.Windows.Forms.Label labelFilename;
    private System.Windows.Forms.Button buttonChooseFile;
    private System.Windows.Forms.ComboBox comboBoxHashtype;
    private System.Windows.Forms.TextBox textBoxResult;
    private System.Windows.Forms.TextBox textBoxCompare;
    private System.Windows.Forms.Label labelInfo;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.OpenFileDialog openFileDialogChooseFile;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMode;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTextMode;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileMode;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSelectLanguage;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
  }
}
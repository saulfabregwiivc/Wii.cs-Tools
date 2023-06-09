﻿/* This file is part of Wii.cs Tools
 * Copyright (C) 2009 Leathl
 * 
 * Wii.cs Tools is free software: you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as published
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Wii.cs Tools is distributed in the hope that it will be
 * useful, but WITHOUT ANY WARRANTY; without even the implied warranty
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Wii.cs_Tools
{
    partial class U8Mii_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCompress = new System.Windows.Forms.CheckBox();
            this.cbHeader = new System.Windows.Forms.CheckBox();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.rbPack = new System.Windows.Forms.RadioButton();
            this.rbUnpack = new System.Windows.Forms.RadioButton();
            this.lbFolder = new System.Windows.Forms.Label();
            this.lbFile = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnUnPack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHeader = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbCompress
            // 
            this.cbCompress.AutoSize = true;
            this.cbCompress.Location = new System.Drawing.Point(12, 146);
            this.cbCompress.Name = "cbCompress";
            this.cbCompress.Size = new System.Drawing.Size(98, 17);
            this.cbCompress.TabIndex = 9;
            this.cbCompress.Text = "Lz77 Compress";
            this.cbCompress.UseVisualStyleBackColor = true;
            // 
            // cbHeader
            // 
            this.cbHeader.AutoSize = true;
            this.cbHeader.Location = new System.Drawing.Point(12, 123);
            this.cbHeader.Name = "cbHeader";
            this.cbHeader.Size = new System.Drawing.Size(86, 17);
            this.cbHeader.TabIndex = 7;
            this.cbHeader.Text = "Add Header:";
            this.cbHeader.UseVisualStyleBackColor = true;
            this.cbHeader.CheckedChanged += new System.EventHandler(this.cbChangeID_CheckedChanged);
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(58, 56);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(150, 20);
            this.tbFolder.TabIndex = 3;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(214, 56);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(23, 20);
            this.btnBrowseFolder.TabIndex = 4;
            this.btnBrowseFolder.Text = "..";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // rbPack
            // 
            this.rbPack.AutoSize = true;
            this.rbPack.Checked = true;
            this.rbPack.Location = new System.Drawing.Point(58, 22);
            this.rbPack.Name = "rbPack";
            this.rbPack.Size = new System.Drawing.Size(50, 17);
            this.rbPack.TabIndex = 1;
            this.rbPack.TabStop = true;
            this.rbPack.Text = "Pack";
            this.rbPack.UseVisualStyleBackColor = true;
            this.rbPack.CheckedChanged += new System.EventHandler(this.rbPack_CheckedChanged);
            // 
            // rbUnpack
            // 
            this.rbUnpack.AutoSize = true;
            this.rbUnpack.Location = new System.Drawing.Point(126, 22);
            this.rbUnpack.Name = "rbUnpack";
            this.rbUnpack.Size = new System.Drawing.Size(63, 17);
            this.rbUnpack.TabIndex = 2;
            this.rbUnpack.Text = "Unpack";
            this.rbUnpack.UseVisualStyleBackColor = true;
            // 
            // lbFolder
            // 
            this.lbFolder.AutoSize = true;
            this.lbFolder.Location = new System.Drawing.Point(9, 60);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.Size = new System.Drawing.Size(39, 13);
            this.lbFolder.TabIndex = 7;
            this.lbFolder.Text = "Folder:";
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Location = new System.Drawing.Point(9, 82);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(26, 13);
            this.lbFile.TabIndex = 8;
            this.lbFile.Text = "File:";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(58, 79);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(150, 20);
            this.tbFile.TabIndex = 5;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(214, 79);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(23, 20);
            this.btnBrowseFile.TabIndex = 6;
            this.btnBrowseFile.Text = "..";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnUnPack
            // 
            this.btnUnPack.Location = new System.Drawing.Point(12, 178);
            this.btnUnPack.Name = "btnUnPack";
            this.btnUnPack.Size = new System.Drawing.Size(225, 31);
            this.btnUnPack.TabIndex = 10;
            this.btnUnPack.Text = "Pack";
            this.btnUnPack.UseVisualStyleBackColor = true;
            this.btnUnPack.Click += new System.EventHandler(this.btnUnPack_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "U8Mii is part of the Wii.cs Tools by Leathl";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Version 0.3";
            // 
            // cmbHeader
            // 
            this.cmbHeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeader.Enabled = false;
            this.cmbHeader.FormattingEnabled = true;
            this.cmbHeader.Items.AddRange(new object[] {
            "IMD5 (Banner/Icon.bin)",
            "IMET (00000000.app)"});
            this.cmbHeader.Location = new System.Drawing.Point(98, 119);
            this.cmbHeader.Name = "cmbHeader";
            this.cmbHeader.Size = new System.Drawing.Size(139, 21);
            this.cmbHeader.TabIndex = 14;
            this.cmbHeader.EnabledChanged += new System.EventHandler(this.cmbHeader_EnabledChanged);
            this.cmbHeader.SelectedIndexChanged += new System.EventHandler(this.cmbHeader_SelectedIndexChanged);
            // 
            // U8Mii_Main
            // 
            this.AcceptButton = this.btnUnPack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 221);
            this.Controls.Add(this.cmbHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnPack);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.lbFolder);
            this.Controls.Add(this.rbUnpack);
            this.Controls.Add(this.rbPack);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.cbHeader);
            this.Controls.Add(this.cbCompress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "U8Mii_Main";
            this.Text = "U8Mii - Wii.cs Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCompress;
        private System.Windows.Forms.CheckBox cbHeader;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.RadioButton rbPack;
        private System.Windows.Forms.RadioButton rbUnpack;
        private System.Windows.Forms.Label lbFolder;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnUnPack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHeader;
    }
}


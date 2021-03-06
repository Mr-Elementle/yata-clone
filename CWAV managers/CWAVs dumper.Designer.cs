﻿namespace YATA
{
    partial class CWAVs_dumper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CWAVs_dumper));
            this.btn_dump = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_exportCWAV = new System.Windows.Forms.Button();
            this.btn_exportWAV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dump
            // 
            this.btn_dump.Location = new System.Drawing.Point(12, 230);
            this.btn_dump.Name = "btn_dump";
            this.btn_dump.Size = new System.Drawing.Size(164, 42);
            this.btn_dump.TabIndex = 0;
            this.btn_dump.Text = "Dump from the theme";
            this.btn_dump.UseVisualStyleBackColor = true;
            this.btn_dump.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_play
            // 
            this.btn_play.Enabled = false;
            this.btn_play.Location = new System.Drawing.Point(307, 12);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_exportCWAV
            // 
            this.btn_exportCWAV.Enabled = false;
            this.btn_exportCWAV.Location = new System.Drawing.Point(307, 134);
            this.btn_exportCWAV.Name = "btn_exportCWAV";
            this.btn_exportCWAV.Size = new System.Drawing.Size(75, 42);
            this.btn_exportCWAV.TabIndex = 3;
            this.btn_exportCWAV.Text = "Export all CWAVs\r\n";
            this.btn_exportCWAV.UseVisualStyleBackColor = true;
            this.btn_exportCWAV.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_exportWAV
            // 
            this.btn_exportWAV.Enabled = false;
            this.btn_exportWAV.Location = new System.Drawing.Point(307, 182);
            this.btn_exportWAV.Name = "btn_exportWAV";
            this.btn_exportWAV.Size = new System.Drawing.Size(75, 42);
            this.btn_exportWAV.TabIndex = 4;
            this.btn_exportWAV.Text = "Export all WAVs\r\n";
            this.btn_exportWAV.UseVisualStyleBackColor = true;
            this.btn_exportWAV.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "No files found";
            this.label1.Visible = false;
            // 
            // Player
            // 
            this.Player.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(-2, 288);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(394, 44);
            this.Player.TabIndex = 6;
            // 
            // CWAVs_dumper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 330);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exportWAV);
            this.Controls.Add(this.btn_exportCWAV);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_dump);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(406, 321);
            this.Name = "CWAVs_dumper";
            this.Text = "CWAVs dumper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_closing);
            this.Load += new System.EventHandler(this.CWAVs_dumper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dump;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_exportCWAV;
        private System.Windows.Forms.Button btn_exportWAV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
    }
}
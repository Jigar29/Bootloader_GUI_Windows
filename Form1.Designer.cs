﻿using System;
using System.IO.Ports;

namespace Bootloader_GUI_Windows
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.status_groupbox = new System.Windows.Forms.GroupBox();
            this.statusbar = new System.Windows.Forms.ProgressBar();
            this.image_selection_groupbox = new System.Windows.Forms.GroupBox();
            this.image_file_browse_button = new System.Windows.Forms.Button();
            this.image_filepath_textbox = new System.Windows.Forms.RichTextBox();
            this.port_setting_groupbox = new System.Windows.Forms.GroupBox();
            this.download_button = new System.Windows.Forms.Button();
            this.close_com_port_after_prog = new System.Windows.Forms.CheckBox();
            this.two_stop_bits_chekcbox = new System.Windows.Forms.CheckBox();
            this.rts_checkbox = new System.Windows.Forms.CheckBox();
            this.parity_checkbox = new System.Windows.Forms.CheckBox();
            this.dtr_checkbox = new System.Windows.Forms.CheckBox();
            this.port_open_close_button = new System.Windows.Forms.Button();
            this.baudrate_combobox = new System.Windows.Forms.ComboBox();
            this.port_selection_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.verbose_groupbox = new System.Windows.Forms.GroupBox();
            this.verbose = new System.Windows.Forms.RichTextBox();
            this.image_file_opener_object = new System.Windows.Forms.OpenFileDialog();
            this.status_groupbox.SuspendLayout();
            this.image_selection_groupbox.SuspendLayout();
            this.port_setting_groupbox.SuspendLayout();
            this.verbose_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_groupbox
            // 
            this.status_groupbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.status_groupbox.Controls.Add(this.statusbar);
            this.status_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_groupbox.Location = new System.Drawing.Point(12, 12);
            this.status_groupbox.Name = "status_groupbox";
            this.status_groupbox.Size = new System.Drawing.Size(340, 52);
            this.status_groupbox.TabIndex = 0;
            this.status_groupbox.TabStop = false;
            this.status_groupbox.Text = "Status";
            // 
            // statusbar
            // 
            this.statusbar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.statusbar.Location = new System.Drawing.Point(3, 18);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(331, 23);
            this.statusbar.TabIndex = 0;
            // 
            // image_selection_groupbox
            // 
            this.image_selection_groupbox.Controls.Add(this.image_file_browse_button);
            this.image_selection_groupbox.Controls.Add(this.image_filepath_textbox);
            this.image_selection_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_selection_groupbox.Location = new System.Drawing.Point(12, 80);
            this.image_selection_groupbox.Name = "image_selection_groupbox";
            this.image_selection_groupbox.Size = new System.Drawing.Size(340, 55);
            this.image_selection_groupbox.TabIndex = 1;
            this.image_selection_groupbox.TabStop = false;
            this.image_selection_groupbox.Text = "Image File Selection (.HEX)";
            // 
            // image_file_browse_button
            // 
            this.image_file_browse_button.Location = new System.Drawing.Point(251, 21);
            this.image_file_browse_button.Name = "image_file_browse_button";
            this.image_file_browse_button.Size = new System.Drawing.Size(75, 23);
            this.image_file_browse_button.TabIndex = 1;
            this.image_file_browse_button.Text = "Browse";
            this.image_file_browse_button.UseVisualStyleBackColor = true;
            this.image_file_browse_button.Click += new System.EventHandler(this.Image_file_browse_button_Click);
            // 
            // image_filepath_textbox
            // 
            this.image_filepath_textbox.Location = new System.Drawing.Point(3, 21);
            this.image_filepath_textbox.Multiline = false;
            this.image_filepath_textbox.Name = "image_filepath_textbox";
            this.image_filepath_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.image_filepath_textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.image_filepath_textbox.Size = new System.Drawing.Size(242, 24);
            this.image_filepath_textbox.TabIndex = 0;
            this.image_filepath_textbox.Text = "Please Select an Image File";
            // 
            // port_setting_groupbox
            // 
            this.port_setting_groupbox.BackColor = System.Drawing.SystemColors.Control;
            this.port_setting_groupbox.Controls.Add(this.download_button);
            this.port_setting_groupbox.Controls.Add(this.close_com_port_after_prog);
            this.port_setting_groupbox.Controls.Add(this.two_stop_bits_chekcbox);
            this.port_setting_groupbox.Controls.Add(this.rts_checkbox);
            this.port_setting_groupbox.Controls.Add(this.parity_checkbox);
            this.port_setting_groupbox.Controls.Add(this.dtr_checkbox);
            this.port_setting_groupbox.Controls.Add(this.port_open_close_button);
            this.port_setting_groupbox.Controls.Add(this.baudrate_combobox);
            this.port_setting_groupbox.Controls.Add(this.port_selection_combobox);
            this.port_setting_groupbox.Controls.Add(this.label2);
            this.port_setting_groupbox.Controls.Add(this.label1);
            this.port_setting_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_setting_groupbox.Location = new System.Drawing.Point(12, 152);
            this.port_setting_groupbox.Name = "port_setting_groupbox";
            this.port_setting_groupbox.Size = new System.Drawing.Size(340, 199);
            this.port_setting_groupbox.TabIndex = 0;
            this.port_setting_groupbox.TabStop = false;
            this.port_setting_groupbox.Text = "Port Settings and Control";
            // 
            // download_button
            // 
            this.download_button.Enabled = false;
            this.download_button.Location = new System.Drawing.Point(206, 140);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(103, 46);
            this.download_button.TabIndex = 10;
            this.download_button.Text = "Download";
            this.download_button.UseVisualStyleBackColor = true;
            // 
            // close_com_port_after_prog
            // 
            this.close_com_port_after_prog.AutoSize = true;
            this.close_com_port_after_prog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_com_port_after_prog.Location = new System.Drawing.Point(22, 77);
            this.close_com_port_after_prog.Name = "close_com_port_after_prog";
            this.close_com_port_after_prog.Size = new System.Drawing.Size(219, 19);
            this.close_com_port_after_prog.TabIndex = 9;
            this.close_com_port_after_prog.Text = "Close COM Port After Programming";
            this.close_com_port_after_prog.UseVisualStyleBackColor = true;
            this.close_com_port_after_prog.CheckedChanged += new System.EventHandler(this.Close_com_port_after_prog_CheckedChanged);
            // 
            // two_stop_bits_chekcbox
            // 
            this.two_stop_bits_chekcbox.AutoSize = true;
            this.two_stop_bits_chekcbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_stop_bits_chekcbox.Location = new System.Drawing.Point(247, 77);
            this.two_stop_bits_chekcbox.Name = "two_stop_bits_chekcbox";
            this.two_stop_bits_chekcbox.Size = new System.Drawing.Size(84, 19);
            this.two_stop_bits_chekcbox.TabIndex = 8;
            this.two_stop_bits_chekcbox.Text = "2 Stop Bits";
            this.two_stop_bits_chekcbox.UseVisualStyleBackColor = true;
            this.two_stop_bits_chekcbox.CheckedChanged += new System.EventHandler(this.Two_stop_bits_chekcbox_CheckedChanged);
            // 
            // rts_checkbox
            // 
            this.rts_checkbox.AutoSize = true;
            this.rts_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rts_checkbox.Location = new System.Drawing.Point(124, 98);
            this.rts_checkbox.Name = "rts_checkbox";
            this.rts_checkbox.Size = new System.Drawing.Size(50, 19);
            this.rts_checkbox.TabIndex = 7;
            this.rts_checkbox.Text = "RTS";
            this.rts_checkbox.UseVisualStyleBackColor = true;
            this.rts_checkbox.CheckedChanged += new System.EventHandler(this.Rts_checkbox_CheckedChanged);
            // 
            // parity_checkbox
            // 
            this.parity_checkbox.AutoSize = true;
            this.parity_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parity_checkbox.Location = new System.Drawing.Point(247, 98);
            this.parity_checkbox.Name = "parity_checkbox";
            this.parity_checkbox.Size = new System.Drawing.Size(56, 19);
            this.parity_checkbox.TabIndex = 6;
            this.parity_checkbox.Text = "Parity";
            this.parity_checkbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.parity_checkbox.UseVisualStyleBackColor = true;
            this.parity_checkbox.CheckedChanged += new System.EventHandler(this.Parity_checkbox_CheckedChanged);
            // 
            // dtr_checkbox
            // 
            this.dtr_checkbox.AutoSize = true;
            this.dtr_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtr_checkbox.Location = new System.Drawing.Point(21, 98);
            this.dtr_checkbox.Name = "dtr_checkbox";
            this.dtr_checkbox.Size = new System.Drawing.Size(51, 19);
            this.dtr_checkbox.TabIndex = 5;
            this.dtr_checkbox.Text = "DTR";
            this.dtr_checkbox.UseVisualStyleBackColor = true;
            this.dtr_checkbox.CheckedChanged += new System.EventHandler(this.Dtr_checkbox_CheckedChanged);
            // 
            // port_open_close_button
            // 
            this.port_open_close_button.Enabled = false;
            this.port_open_close_button.Location = new System.Drawing.Point(35, 142);
            this.port_open_close_button.Name = "port_open_close_button";
            this.port_open_close_button.Size = new System.Drawing.Size(107, 44);
            this.port_open_close_button.TabIndex = 4;
            this.port_open_close_button.Text = "Open";
            this.port_open_close_button.UseVisualStyleBackColor = true;
            this.port_open_close_button.Click += new System.EventHandler(this.Port_open_close_button_Click);
            // 
            // baudrate_combobox
            // 
            this.baudrate_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrate_combobox.Enabled = false;
            this.baudrate_combobox.FormattingEnabled = true;
            this.baudrate_combobox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "72000",
            "100000",
            "115200",
            "125000",
            "144000",
            "230400",
            "250000",
            "500000",
            "1000000"});
            this.baudrate_combobox.Location = new System.Drawing.Point(190, 47);
            this.baudrate_combobox.Name = "baudrate_combobox";
            this.baudrate_combobox.Size = new System.Drawing.Size(129, 24);
            this.baudrate_combobox.TabIndex = 3;
            this.baudrate_combobox.SelectedIndexChanged += new System.EventHandler(this.Baudrate_combobox_SelectedIndexChanged);
            // 
            // port_selection_combobox
            // 
            this.port_selection_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port_selection_combobox.FormattingEnabled = true;
            this.port_selection_combobox.Location = new System.Drawing.Point(21, 47);
            this.port_selection_combobox.Name = "port_selection_combobox";
            this.port_selection_combobox.Size = new System.Drawing.Size(121, 24);
            this.port_selection_combobox.TabIndex = 2;
            this.port_selection_combobox.SelectedIndexChanged += new System.EventHandler(this.Port_selection_combobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate ( bps )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // verbose_groupbox
            // 
            this.verbose_groupbox.Controls.Add(this.verbose);
            this.verbose_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verbose_groupbox.Location = new System.Drawing.Point(358, 12);
            this.verbose_groupbox.Name = "verbose_groupbox";
            this.verbose_groupbox.Size = new System.Drawing.Size(286, 339);
            this.verbose_groupbox.TabIndex = 2;
            this.verbose_groupbox.TabStop = false;
            this.verbose_groupbox.Text = "Verbose";
            // 
            // verbose
            // 
            this.verbose.Location = new System.Drawing.Point(6, 18);
            this.verbose.Name = "verbose";
            this.verbose.ReadOnly = true;
            this.verbose.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.verbose.Size = new System.Drawing.Size(274, 315);
            this.verbose.TabIndex = 0;
            this.verbose.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(656, 363);
            this.Controls.Add(this.verbose_groupbox);
            this.Controls.Add(this.port_setting_groupbox);
            this.Controls.Add(this.image_selection_groupbox);
            this.Controls.Add(this.status_groupbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MicroLoader";
            this.status_groupbox.ResumeLayout(false);
            this.image_selection_groupbox.ResumeLayout(false);
            this.port_setting_groupbox.ResumeLayout(false);
            this.port_setting_groupbox.PerformLayout();
            this.verbose_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox status_groupbox;
        private System.Windows.Forms.GroupBox image_selection_groupbox;
        private System.Windows.Forms.GroupBox port_setting_groupbox;
        private System.Windows.Forms.CheckBox two_stop_bits_chekcbox;
        private System.Windows.Forms.CheckBox rts_checkbox;
        private System.Windows.Forms.CheckBox dtr_checkbox;
        private System.Windows.Forms.Button port_open_close_button;
        private System.Windows.Forms.ComboBox baudrate_combobox;
        private System.Windows.Forms.ComboBox port_selection_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox verbose_groupbox;
        private System.Windows.Forms.ProgressBar statusbar;
        private System.Windows.Forms.Button image_file_browse_button;
        private System.Windows.Forms.RichTextBox image_filepath_textbox;
        private System.Windows.Forms.RichTextBox verbose;
        private System.Windows.Forms.OpenFileDialog image_file_opener_object;
        private System.Windows.Forms.CheckBox close_com_port_after_prog;
        private System.Windows.Forms.CheckBox parity_checkbox;
        private System.Windows.Forms.Button download_button;
    }
}


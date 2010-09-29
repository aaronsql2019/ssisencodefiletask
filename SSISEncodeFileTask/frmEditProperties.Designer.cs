﻿namespace SSISEncodeFileTask100
{
    partial class frmEditProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditProperties));
            this.cmbFile = new System.Windows.Forms.ComboBox();
            this.lbHTTPConnection = new System.Windows.Forms.Label();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.txSourceFile = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btExpressionSource = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.opFileConnector = new System.Windows.Forms.RadioButton();
            this.opFilePath = new System.Windows.Forms.RadioButton();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFile
            // 
            this.cmbFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFile.FormattingEnabled = true;
            this.cmbFile.Location = new System.Drawing.Point(159, 49);
            this.cmbFile.Name = "cmbFile";
            this.cmbFile.Size = new System.Drawing.Size(335, 21);
            this.cmbFile.TabIndex = 0;
            // 
            // lbHTTPConnection
            // 
            this.lbHTTPConnection.AutoSize = true;
            this.lbHTTPConnection.Location = new System.Drawing.Point(15, 52);
            this.lbHTTPConnection.Name = "lbHTTPConnection";
            this.lbHTTPConnection.Size = new System.Drawing.Size(125, 13);
            this.lbHTTPConnection.TabIndex = 1;
            this.lbHTTPConnection.Text = "File Connection Manager";
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Location = new System.Drawing.Point(15, 84);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(47, 13);
            this.lbFilePath.TabIndex = 2;
            this.lbFilePath.Text = "File path";
            // 
            // txSourceFile
            // 
            this.txSourceFile.Location = new System.Drawing.Point(159, 78);
            this.txSourceFile.Name = "txSourceFile";
            this.txSourceFile.Size = new System.Drawing.Size(300, 20);
            this.txSourceFile.TabIndex = 3;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(171, 145);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 36);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(252, 145);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 36);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btExpressionSource
            // 
            this.btExpressionSource.Location = new System.Drawing.Point(465, 79);
            this.btExpressionSource.Name = "btExpressionSource";
            this.btExpressionSource.Size = new System.Drawing.Size(29, 23);
            this.btExpressionSource.TabIndex = 8;
            this.btExpressionSource.Text = "...";
            this.btExpressionSource.UseVisualStyleBackColor = true;
            this.btExpressionSource.Click += new System.EventHandler(this.btExpressionSource_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(23, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(217, 13);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "http//SSISEncodeFileTask.codeplex.com";
            // 
            // opFileConnector
            // 
            this.opFileConnector.AutoSize = true;
            this.opFileConnector.Location = new System.Drawing.Point(18, 13);
            this.opFileConnector.Name = "opFileConnector";
            this.opFileConnector.Size = new System.Drawing.Size(187, 17);
            this.opFileConnector.TabIndex = 13;
            this.opFileConnector.TabStop = true;
            this.opFileConnector.Text = "Set encoding from a file connector";
            this.opFileConnector.UseVisualStyleBackColor = true;
            // 
            // opFilePath
            // 
            this.opFilePath.AutoSize = true;
            this.opFilePath.Location = new System.Drawing.Point(299, 13);
            this.opFilePath.Name = "opFilePath";
            this.opFilePath.Size = new System.Drawing.Size(160, 17);
            this.opFilePath.TabIndex = 14;
            this.opFilePath.TabStop = true;
            this.opFilePath.Text = "Set encoding from a file path";
            this.opFilePath.UseVisualStyleBackColor = true;
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(159, 106);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(335, 21);
            this.cmbEncoding.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Apply Encoding";
            // 
            // frmEditProperties
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(522, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEncoding);
            this.Controls.Add(this.opFilePath);
            this.Controls.Add(this.opFileConnector);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btExpressionSource);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txSourceFile);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.lbHTTPConnection);
            this.Controls.Add(this.cmbFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit task properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFile;
        private System.Windows.Forms.Label lbHTTPConnection;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.TextBox txSourceFile;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btExpressionSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton opFileConnector;
        private System.Windows.Forms.RadioButton opFilePath;
        private System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.Label label1;
    }
}
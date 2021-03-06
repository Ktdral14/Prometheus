﻿namespace Prometheus
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
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvLexer = new System.Windows.Forms.DataGridView();
            this.token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSintaxResult = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexer)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCode
            // 
            this.tbCode.AcceptsTab = true;
            this.tbCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.Location = new System.Drawing.Point(12, 48);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(807, 267);
            this.tbCode.TabIndex = 0;
            this.tbCode.TextChanged += new System.EventHandler(this.Analize_Text);
            // 
            // btnNewFile
            // 
            this.btnNewFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewFile.BackgroundImage")));
            this.btnNewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewFile.FlatAppearance.BorderSize = 0;
            this.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFile.Location = new System.Drawing.Point(22, 12);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(30, 30);
            this.btnNewFile.TabIndex = 2;
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.BackgroundImage")));
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Location = new System.Drawing.Point(68, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(30, 30);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnParse
            // 
            this.btnParse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnParse.BackgroundImage")));
            this.btnParse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParse.FlatAppearance.BorderSize = 0;
            this.btnParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParse.Location = new System.Drawing.Point(116, 12);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(30, 30);
            this.btnParse.TabIndex = 4;
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 321);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 178);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvLexer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Léxico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbSintaxResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 152);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sintáctico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvLexer
            // 
            this.dgvLexer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLexer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.token,
            this.Lexema,
            this.Linea,
            this.Columna});
            this.dgvLexer.Location = new System.Drawing.Point(-2, 1);
            this.dgvLexer.MultiSelect = false;
            this.dgvLexer.Name = "dgvLexer";
            this.dgvLexer.ReadOnly = true;
            this.dgvLexer.Size = new System.Drawing.Size(807, 150);
            this.dgvLexer.TabIndex = 2;
            // 
            // token
            // 
            this.token.HeaderText = "Token";
            this.token.Name = "token";
            this.token.ReadOnly = true;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Línea";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            // 
            // Columna
            // 
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            this.Columna.ReadOnly = true;
            // 
            // tbSintaxResult
            // 
            this.tbSintaxResult.BackColor = System.Drawing.Color.Black;
            this.tbSintaxResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSintaxResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSintaxResult.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSintaxResult.Location = new System.Drawing.Point(-2, 0);
            this.tbSintaxResult.Multiline = true;
            this.tbSintaxResult.Name = "tbSintaxResult";
            this.tbSintaxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSintaxResult.Size = new System.Drawing.Size(807, 152);
            this.tbSintaxResult.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 511);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.tbCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prometheus Compiler";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLexer;
        private System.Windows.Forms.DataGridViewTextBoxColumn token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbSintaxResult;
    }
}
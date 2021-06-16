
namespace Analizador_Sintactico
{
    partial class Analizador
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Sintactico = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSintactico = new System.Windows.Forms.Button();
            this.BLexico = new System.Windows.Forms.Button();
            this.dgv_Lexico = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sintactico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lexico)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sintactico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lexico";
            // 
            // DGV_Sintactico
            // 
            this.DGV_Sintactico.AllowUserToAddRows = false;
            this.DGV_Sintactico.AllowUserToDeleteRows = false;
            this.DGV_Sintactico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sintactico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_Sintactico.Location = new System.Drawing.Point(353, 193);
            this.DGV_Sintactico.Name = "DGV_Sintactico";
            this.DGV_Sintactico.ReadOnly = true;
            this.DGV_Sintactico.Size = new System.Drawing.Size(402, 245);
            this.DGV_Sintactico.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ESTRUCTURA";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DETALLE";
            this.Column2.MinimumWidth = 460;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 460;
            // 
            // BSintactico
            // 
            this.BSintactico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BSintactico.Enabled = false;
            this.BSintactico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BSintactico.Location = new System.Drawing.Point(761, 290);
            this.BSintactico.Name = "BSintactico";
            this.BSintactico.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BSintactico.Size = new System.Drawing.Size(72, 30);
            this.BSintactico.TabIndex = 13;
            this.BSintactico.Text = ">>";
            this.BSintactico.UseVisualStyleBackColor = false;
            this.BSintactico.Click += new System.EventHandler(this.BSintactico_Click);
            // 
            // BLexico
            // 
            this.BLexico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BLexico.Location = new System.Drawing.Point(324, 54);
            this.BLexico.Name = "BLexico";
            this.BLexico.Size = new System.Drawing.Size(66, 32);
            this.BLexico.TabIndex = 12;
            this.BLexico.Text = ">>";
            this.BLexico.UseVisualStyleBackColor = false;
            this.BLexico.Click += new System.EventHandler(this.BLexico_Click);
            // 
            // dgv_Lexico
            // 
            this.dgv_Lexico.AllowUserToAddRows = false;
            this.dgv_Lexico.AllowUserToDeleteRows = false;
            this.dgv_Lexico.ColumnHeadersHeight = 20;
            this.dgv_Lexico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4});
            this.dgv_Lexico.Location = new System.Drawing.Point(396, 33);
            this.dgv_Lexico.Name = "dgv_Lexico";
            this.dgv_Lexico.ReadOnly = true;
            this.dgv_Lexico.RowHeadersWidth = 15;
            this.dgv_Lexico.Size = new System.Drawing.Size(402, 124);
            this.dgv_Lexico.TabIndex = 11;
            // 
            // c1
            // 
            this.c1.HeaderText = "LEXEMA";
            this.c1.MinimumWidth = 50;
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Width = 150;
            // 
            // c2
            // 
            this.c2.HeaderText = "TOKEN";
            this.c2.MinimumWidth = 50;
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // c3
            // 
            this.c3.HeaderText = "LINEA";
            this.c3.MinimumWidth = 50;
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Width = 50;
            // 
            // c4
            // 
            this.c4.HeaderText = "COLUMNA";
            this.c4.MinimumWidth = 65;
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            this.c4.Width = 65;
            // 
            // TCodigo
            // 
            this.TCodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TCodigo.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCodigo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TCodigo.Location = new System.Drawing.Point(12, 12);
            this.TCodigo.Multiline = true;
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TCodigo.Size = new System.Drawing.Size(306, 426);
            this.TCodigo.TabIndex = 10;
            this.TCodigo.TextChanged += new System.EventHandler(this.TCodigo_TextChanged);
            // 
            // Analizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Sintactico);
            this.Controls.Add(this.BSintactico);
            this.Controls.Add(this.BLexico);
            this.Controls.Add(this.dgv_Lexico);
            this.Controls.Add(this.TCodigo);
            this.Name = "Analizador";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sintactico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lexico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Sintactico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button BSintactico;
        private System.Windows.Forms.Button BLexico;
        private System.Windows.Forms.DataGridView dgv_Lexico;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.TextBox TCodigo;
    }
}


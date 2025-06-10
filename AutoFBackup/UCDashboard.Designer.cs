namespace FBackup
{
    partial class UCDashboard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBtnEmail = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdBtnTelegram = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBtnMegaNz = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtnFTP = new System.Windows.Forms.RadioButton();
            this.guna2GroupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2GroupBox2 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.dtGridViewRotinas = new System.Windows.Forms.DataGridView();
            this.column_Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Execucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_DiretorioBackups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_NomeRotinaJSON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewRotinas)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            //
            this.bunifuSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.bunifuSeparator1.Location = new System.Drawing.Point(-2, 57);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(665, 1);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.rdBtnEmail);
            this.panel2.Location = new System.Drawing.Point(150, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 25);
            this.panel2.TabIndex = 4;
            // 
            // rdBtnEmail
            //
            this.rdBtnEmail.AutoCheck = false;
            this.rdBtnEmail.Checked = true;
            this.rdBtnEmail.Enabled = false;
            this.rdBtnEmail.Location = new System.Drawing.Point(5, 3);
            this.rdBtnEmail.Name = "rdBtnEmail";
            this.rdBtnEmail.Size = new System.Drawing.Size(14, 13);
            this.rdBtnEmail.TabIndex = 1;
            this.rdBtnEmail.TabStop = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.rdBtnTelegram);
            this.panel4.Location = new System.Drawing.Point(302, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 25);
            this.panel4.TabIndex = 5;
            // 
            // rdBtnTelegram
            //
            this.rdBtnTelegram.AutoCheck = false;
            this.rdBtnTelegram.Checked = true;
            this.rdBtnTelegram.Enabled = false;
            this.rdBtnTelegram.Location = new System.Drawing.Point(5, 3);
            this.rdBtnTelegram.Name = "rdBtnTelegram";
            this.rdBtnTelegram.Size = new System.Drawing.Size(14, 13);
            this.rdBtnTelegram.TabIndex = 1;
            this.rdBtnTelegram.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(291, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Telegram";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(146, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(214, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mega.nz";
            // 
            // rdBtnMegaNz
            //
            this.rdBtnMegaNz.AutoCheck = false;
            this.rdBtnMegaNz.Checked = true;
            this.rdBtnMegaNz.Enabled = false;
            this.rdBtnMegaNz.Location = new System.Drawing.Point(5, 3);
            this.rdBtnMegaNz.Name = "rdBtnMegaNz";
            this.rdBtnMegaNz.Size = new System.Drawing.Size(14, 13);
            this.rdBtnMegaNz.TabIndex = 1;
            this.rdBtnMegaNz.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.rdBtnMegaNz);
            this.panel3.Location = new System.Drawing.Point(224, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 25);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dashboard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(373, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "FTP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rdBtnFTP);
            this.panel1.Location = new System.Drawing.Point(370, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 25);
            this.panel1.TabIndex = 13;
            // 
            // rdBtnFTP
            //
            this.rdBtnFTP.AutoCheck = false;
            this.rdBtnFTP.Checked = true;
            this.rdBtnFTP.Enabled = false;
            this.rdBtnFTP.Location = new System.Drawing.Point(5, 3);
            this.rdBtnFTP.Name = "rdBtnFTP";
            this.rdBtnFTP.Size = new System.Drawing.Size(14, 13);
            this.rdBtnFTP.TabIndex = 1;
            this.rdBtnFTP.TabStop = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.panel2);
            this.guna2GroupBox1.Controls.Add(this.panel3);
            this.guna2GroupBox1.Controls.Add(this.panel4);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.bunifuSeparator1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2GroupBox1.Location = new System.Drawing.Point(26, 43);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(517, 98);
            this.guna2GroupBox1.TabIndex = 18;
            this.guna2GroupBox1.Text = "Integrado Com:";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.label35);
            this.guna2GroupBox2.Controls.Add(this.dtGridViewRotinas);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.guna2GroupBox2.Location = new System.Drawing.Point(24, 180);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(519, 377);
            this.guna2GroupBox2.TabIndex = 19;
            this.guna2GroupBox2.Text = "Rotinas de Backup:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.label35.Location = new System.Drawing.Point(216, 357);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(299, 13);
            this.label35.TabIndex = 53;
            this.label35.Text = "(Dê um duplo clique em qualquer rotina acima para exclui-lá)";
            // 
            // dtGridViewRotinas
            // 
            this.dtGridViewRotinas.AllowUserToAddRows = false;
            this.dtGridViewRotinas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGridViewRotinas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewRotinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridViewRotinas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtGridViewRotinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewRotinas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewRotinas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewRotinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewRotinas.ColumnHeadersHeight = 17;
            this.dtGridViewRotinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_Identificador,
            this.column_Tipo,
            this.column_Execucao,
            this.column_DiretorioBackups,
            this.column_NomeRotinaJSON});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewRotinas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewRotinas.EnableHeadersVisualStyles = false;
            this.dtGridViewRotinas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtGridViewRotinas.Location = new System.Drawing.Point(0, 46);
            this.dtGridViewRotinas.Name = "dtGridViewRotinas";
            this.dtGridViewRotinas.ReadOnly = true;
            this.dtGridViewRotinas.RowHeadersVisible = false;
            this.dtGridViewRotinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewRotinas.Size = new System.Drawing.Size(516, 308);
            this.dtGridViewRotinas.TabIndex = 0;
            this.dtGridViewRotinas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewRotinas_CellDoubleClick);
            this.dtGridViewRotinas.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewRotinas_CellMouseEnter);
            this.dtGridViewRotinas.MouseEnter += new System.EventHandler(this.dtGridViewRotinas_MouseEnter);
            // 
            // column_Identificador
            // 
            this.column_Identificador.FillWeight = 150F;
            this.column_Identificador.HeaderText = "Identificador";
            this.column_Identificador.Name = "column_Identificador";
            this.column_Identificador.ReadOnly = true;
            this.column_Identificador.Width = 97;
            // 
            // column_Tipo
            // 
            this.column_Tipo.FillWeight = 150F;
            this.column_Tipo.HeaderText = "Tipo";
            this.column_Tipo.Name = "column_Tipo";
            this.column_Tipo.ReadOnly = true;
            this.column_Tipo.Width = 53;
            // 
            // column_Execucao
            // 
            this.column_Execucao.FillWeight = 110F;
            this.column_Execucao.HeaderText = "Execução";
            this.column_Execucao.Name = "column_Execucao";
            this.column_Execucao.ReadOnly = true;
            this.column_Execucao.Width = 80;
            // 
            // column_DiretorioBackups
            // 
            this.column_DiretorioBackups.HeaderText = "Diretório de Backups";
            this.column_DiretorioBackups.Name = "column_DiretorioBackups";
            this.column_DiretorioBackups.ReadOnly = true;
            this.column_DiretorioBackups.Width = 139;
            // 
            // column_NomeRotinaJSON
            // 
            this.column_NomeRotinaJSON.FillWeight = 200F;
            this.column_NomeRotinaJSON.HeaderText = "JSON Rotina Backup";
            this.column_NomeRotinaJSON.Name = "column_NomeRotinaJSON";
            this.column_NomeRotinaJSON.ReadOnly = true;
            this.column_NomeRotinaJSON.Width = 137;
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label4);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(571, 560);
            this.Load += new System.EventHandler(this.UCDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewRotinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel bunifuSeparator1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdBtnEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdBtnTelegram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBtnMegaNz;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnFTP;
        private System.Windows.Forms.GroupBox guna2GroupBox1;
        private System.Windows.Forms.GroupBox guna2GroupBox2;
        private System.Windows.Forms.DataGridView dtGridViewRotinas;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Execucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_DiretorioBackups;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_NomeRotinaJSON;
    }
}

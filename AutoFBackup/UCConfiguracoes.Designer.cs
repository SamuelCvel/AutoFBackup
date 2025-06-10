namespace FBackup
{
    partial class UCConfiguracoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCConfiguracoes));
            this.label4 = new System.Windows.Forms.Label();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.metroTabPage1 = new System.Windows.Forms.TabPage();
            this.chbxIniciarComOWindows = new System.Windows.Forms.CheckBox();
            this.chbxBuscaAtualizacoesIni = new System.Windows.Forms.CheckBox();
            this.metroTabPage2 = new System.Windows.Forms.TabPage();
            this.chbxAguardarConclusaoAplicativoPreBackup = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chbxExecutaGFIX = new System.Windows.Forms.CheckBox();
            this.lblAvisoGfix = new System.Windows.Forms.LinkLabel();
            this.gpbxGFIX = new System.Windows.Forms.GroupBox();
            this.lblAvisoArgumentosGfix = new System.Windows.Forms.LinkLabel();
            this.tbArgumentosGFIX = new System.Windows.Forms.TextBox();
            this.tbDiretorioGFIX = new System.Windows.Forms.TextBox();
            this.btnDiretorioGFIX = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExplicacaoFlags = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.nmUpDownDiasExcluirBackupsAntigos = new System.Windows.Forms.NumericUpDown();
            this.chbxExcluirBackupsAntigos = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbArgumentosPosBackup = new System.Windows.Forms.TextBox();
            this.btnDiretorioAppPosBackup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAplicativoPosBackup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbArgumentosPreBackup = new System.Windows.Forms.TextBox();
            this.btnDiretorioAppPreBackup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAplicativoPreBackup = new System.Windows.Forms.TextBox();
            this.lstBoxFlagsBackup = new System.Windows.Forms.CheckedListBox();
            this.btnDiretorioBackups = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiretorioBackups = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bunifuElipseBtnSalvar = new System.ComponentModel.Component(this.components);
            this.bunifuElipseBtnFechar = new System.ComponentModel.Component(this.components);
            this.bunifuElipseBtnDiretorioBackups = new System.ComponentModel.Component(this.components);
            this.bunifuElipseBtnAppPreBackup = new System.ComponentModel.Component(this.components);
            this.bunifuElipseBtnAppPosBackup = new System.ComponentModel.Component(this.components);
            this.bunifuElipseBtnDiretorioGFIX = new System.ComponentModel.Component(this.components);
            this.tbControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.gpbxGFIX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDownDiasExcluirBackupsAntigos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Configurações Globais";
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.metroTabPage1);
            this.tbControl.Controls.Add(this.metroTabPage2);
            this.tbControl.ItemSize = new System.Drawing.Size(100, 34);
            this.tbControl.Location = new System.Drawing.Point(8, 43);
            this.tbControl.Multiline = true;
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.ShowToolTips = true;
            this.tbControl.Size = new System.Drawing.Size(560, 464);
            this.tbControl.TabIndex = 14;
            this.tbControl.UseCustomForeColor = true;
            this.tbControl.UseSelectable = true;
            this.tbControl.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.chbxIniciarComOWindows);
            this.metroTabPage1.Controls.Add(this.chbxBuscaAtualizacoesIni);
            this.metroTabPage1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(552, 422);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Configurações Gerais  ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // chbxIniciarComOWindows
            // 
            this.chbxIniciarComOWindows.AutoSize = true;
            this.chbxIniciarComOWindows.BackColor = System.Drawing.Color.Transparent;
            this.chbxIniciarComOWindows.Location = new System.Drawing.Point(9, 54);
            this.chbxIniciarComOWindows.Name = "chbxIniciarComOWindows";
            this.chbxIniciarComOWindows.Size = new System.Drawing.Size(143, 17);
            this.chbxIniciarComOWindows.TabIndex = 3;
            this.chbxIniciarComOWindows.Text = "Iniciar com o Windows";
            this.chbxIniciarComOWindows.UseVisualStyleBackColor = false;
            // 
            // chbxBuscaAtualizacoesIni
            // 
            this.chbxBuscaAtualizacoesIni.AutoSize = true;
            this.chbxBuscaAtualizacoesIni.BackColor = System.Drawing.Color.Transparent;
            this.chbxBuscaAtualizacoesIni.Location = new System.Drawing.Point(9, 31);
            this.chbxBuscaAtualizacoesIni.Name = "chbxBuscaAtualizacoesIni";
            this.chbxBuscaAtualizacoesIni.Size = new System.Drawing.Size(289, 17);
            this.chbxBuscaAtualizacoesIni.TabIndex = 2;
            this.chbxBuscaAtualizacoesIni.Text = "Buscar novas atualizações ao iniciar o AutoFBackup";
            this.chbxBuscaAtualizacoesIni.UseVisualStyleBackColor = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.chbxAguardarConclusaoAplicativoPreBackup);
            this.metroTabPage2.Controls.Add(this.panel8);
            this.metroTabPage2.Controls.Add(this.gpbxGFIX);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.lblExplicacaoFlags);
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.Controls.Add(this.nmUpDownDiasExcluirBackupsAntigos);
            this.metroTabPage2.Controls.Add(this.chbxExcluirBackupsAntigos);
            this.metroTabPage2.Controls.Add(this.label6);
            this.metroTabPage2.Controls.Add(this.tbArgumentosPosBackup);
            this.metroTabPage2.Controls.Add(this.btnDiretorioAppPosBackup);
            this.metroTabPage2.Controls.Add(this.label7);
            this.metroTabPage2.Controls.Add(this.tbAplicativoPosBackup);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.Controls.Add(this.tbArgumentosPreBackup);
            this.metroTabPage2.Controls.Add(this.btnDiretorioAppPreBackup);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.tbAplicativoPreBackup);
            this.metroTabPage2.Controls.Add(this.lstBoxFlagsBackup);
            this.metroTabPage2.Controls.Add(this.btnDiretorioBackups);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.tbDiretorioBackups);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(552, 422);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Configurações de Backups";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // chbxAguardarConclusaoAplicativoPreBackup
            // 
            this.chbxAguardarConclusaoAplicativoPreBackup.AutoSize = true;
            this.chbxAguardarConclusaoAplicativoPreBackup.BackColor = System.Drawing.Color.Transparent;
            this.chbxAguardarConclusaoAplicativoPreBackup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxAguardarConclusaoAplicativoPreBackup.Location = new System.Drawing.Point(422, 280);
            this.chbxAguardarConclusaoAplicativoPreBackup.Name = "chbxAguardarConclusaoAplicativoPreBackup";
            this.chbxAguardarConclusaoAplicativoPreBackup.Size = new System.Drawing.Size(131, 17);
            this.chbxAguardarConclusaoAplicativoPreBackup.TabIndex = 64;
            this.chbxAguardarConclusaoAplicativoPreBackup.Text = "Aguardar Conclusão";
            this.chbxAguardarConclusaoAplicativoPreBackup.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.panel8.Controls.Add(this.chbxExecutaGFIX);
            this.panel8.Controls.Add(this.lblAvisoGfix);
            this.panel8.Location = new System.Drawing.Point(104, 176);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(386, 31);
            this.panel8.TabIndex = 63;
            // 
            // chbxExecutaGFIX
            // 
            this.chbxExecutaGFIX.AutoSize = true;
            this.chbxExecutaGFIX.BackColor = System.Drawing.Color.Transparent;
            this.chbxExecutaGFIX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxExecutaGFIX.ForeColor = System.Drawing.Color.Black;
            this.chbxExecutaGFIX.Location = new System.Drawing.Point(3, 7);
            this.chbxExecutaGFIX.Name = "chbxExecutaGFIX";
            this.chbxExecutaGFIX.Size = new System.Drawing.Size(300, 17);
            this.chbxExecutaGFIX.TabIndex = 0;
            this.chbxExecutaGFIX.Text = "Executar GFIX Antes da Criação do Arquivo de Backup";
            this.chbxExecutaGFIX.UseVisualStyleBackColor = false;
            this.chbxExecutaGFIX.CheckedChanged += new System.EventHandler(this.chbxExecutaGFIX_CheckedChanged);
            // 
            // lblAvisoGfix
            // 
            this.lblAvisoGfix.AutoSize = true;
            this.lblAvisoGfix.BackColor = System.Drawing.Color.Transparent;
            this.lblAvisoGfix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvisoGfix.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAvisoGfix.LinkColor = System.Drawing.Color.Red;
            this.lblAvisoGfix.Location = new System.Drawing.Point(309, 5);
            this.lblAvisoGfix.Name = "lblAvisoGfix";
            this.lblAvisoGfix.Size = new System.Drawing.Size(28, 19);
            this.lblAvisoGfix.TabIndex = 58;
            this.lblAvisoGfix.TabStop = true;
            this.lblAvisoGfix.Text = "⚠";
            this.lblAvisoGfix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvisoGfix.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAvisoGfix_LinkClicked);
            // 
            // gpbxGFIX
            // 
            this.gpbxGFIX.BackColor = System.Drawing.Color.Transparent;
            this.gpbxGFIX.Controls.Add(this.lblAvisoArgumentosGfix);
            this.gpbxGFIX.Controls.Add(this.tbArgumentosGFIX);
            this.gpbxGFIX.Controls.Add(this.tbDiretorioGFIX);
            this.gpbxGFIX.Controls.Add(this.btnDiretorioGFIX);
            this.gpbxGFIX.Controls.Add(this.label37);
            this.gpbxGFIX.Controls.Add(this.label36);
            this.gpbxGFIX.Enabled = false;
            this.gpbxGFIX.Location = new System.Drawing.Point(104, 169);
            this.gpbxGFIX.Name = "gpbxGFIX";
            this.gpbxGFIX.Size = new System.Drawing.Size(386, 102);
            this.gpbxGFIX.TabIndex = 58;
            this.gpbxGFIX.TabStop = false;
            // 
            // lblAvisoArgumentosGfix
            // 
            this.lblAvisoArgumentosGfix.AutoSize = true;
            this.lblAvisoArgumentosGfix.BackColor = System.Drawing.Color.Transparent;
            this.lblAvisoArgumentosGfix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvisoArgumentosGfix.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAvisoArgumentosGfix.LinkColor = System.Drawing.Color.Red;
            this.lblAvisoArgumentosGfix.Location = new System.Drawing.Point(334, 74);
            this.lblAvisoArgumentosGfix.Name = "lblAvisoArgumentosGfix";
            this.lblAvisoArgumentosGfix.Size = new System.Drawing.Size(28, 19);
            this.lblAvisoArgumentosGfix.TabIndex = 62;
            this.lblAvisoArgumentosGfix.TabStop = true;
            this.lblAvisoArgumentosGfix.Text = "⚠";
            this.lblAvisoArgumentosGfix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvisoArgumentosGfix.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAvisoArgumentosGfix_LinkClicked);
            // 
            // tbArgumentosGFIX
            // 
            this.tbArgumentosGFIX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbArgumentosGFIX.DefaultText = "-mend -full -ignore";
            this.tbArgumentosGFIX.ForeColor = System.Drawing.Color.Black;
            this.tbArgumentosGFIX.Location = new System.Drawing.Point(84, 72);
            this.tbArgumentosGFIX.Name = "tbArgumentosGFIX";
            this.tbArgumentosGFIX.PasswordChar = '\0';
            this.tbArgumentosGFIX.SelectedText = "";
            this.tbArgumentosGFIX.SelectionStart = 19;
            this.tbArgumentosGFIX.Size = new System.Drawing.Size(244, 24);
            this.tbArgumentosGFIX.TabIndex = 61;
            // 
            // tbDiretorioGFIX
            // 
            this.tbDiretorioGFIX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiretorioGFIX.DefaultText = "";
            this.tbDiretorioGFIX.ForeColor = System.Drawing.Color.Black;
            this.tbDiretorioGFIX.Location = new System.Drawing.Point(84, 44);
            this.tbDiretorioGFIX.Name = "tbDiretorioGFIX";
            this.tbDiretorioGFIX.PasswordChar = '\0';
            this.tbDiretorioGFIX.ReadOnly = true;
            this.tbDiretorioGFIX.SelectedText = "";
            this.tbDiretorioGFIX.Size = new System.Drawing.Size(244, 24);
            this.tbDiretorioGFIX.TabIndex = 58;
            // 
            // btnDiretorioGFIX
            // 
            this.btnDiretorioGFIX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiretorioGFIX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDiretorioGFIX.ForeColor = System.Drawing.Color.White;
            this.btnDiretorioGFIX.Image = ((System.Drawing.Image)(resources.GetObject("btnDiretorioGFIX.Image")));
            this.btnDiretorioGFIX.Location = new System.Drawing.Point(334, 44);
            this.btnDiretorioGFIX.Name = "btnDiretorioGFIX";
            this.btnDiretorioGFIX.Size = new System.Drawing.Size(46, 24);
            this.btnDiretorioGFIX.TabIndex = 60;
            this.btnDiretorioGFIX.Click += new System.EventHandler(this.btnDiretorioGFIX_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label37.Location = new System.Drawing.Point(25, 44);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(53, 26);
            this.label37.TabIndex = 59;
            this.label37.Text = "Diretório\n do GFIX:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label36.Location = new System.Drawing.Point(8, 72);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(70, 26);
            this.label36.TabIndex = 58;
            this.label36.Text = "Argumentos\r\n    do GFIX:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(-3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Opções do Backup:\r\n           (flags)";
            // 
            // lblExplicacaoFlags
            // 
            this.lblExplicacaoFlags.AutoSize = true;
            this.lblExplicacaoFlags.BackColor = System.Drawing.Color.Transparent;
            this.lblExplicacaoFlags.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacaoFlags.Location = new System.Drawing.Point(491, 89);
            this.lblExplicacaoFlags.Name = "lblExplicacaoFlags";
            this.lblExplicacaoFlags.Size = new System.Drawing.Size(62, 26);
            this.lblExplicacaoFlags.TabIndex = 35;
            this.lblExplicacaoFlags.TabStop = true;
            this.lblExplicacaoFlags.Text = "O que isso\r\nsignifica?";
            this.lblExplicacaoFlags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExplicacaoFlags.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExplicacaoFlags_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.Location = new System.Drawing.Point(365, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "dia(s) do Diretório de Backups local";
            // 
            // nmUpDownDiasExcluirBackupsAntigos
            // 
            this.nmUpDownDiasExcluirBackupsAntigos.BackColor = System.Drawing.Color.Transparent;
            this.nmUpDownDiasExcluirBackupsAntigos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmUpDownDiasExcluirBackupsAntigos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmUpDownDiasExcluirBackupsAntigos.ForeColor = System.Drawing.Color.Black;
            this.nmUpDownDiasExcluirBackupsAntigos.Location = new System.Drawing.Point(291, 394);
            this.nmUpDownDiasExcluirBackupsAntigos.Name = "nmUpDownDiasExcluirBackupsAntigos";
            this.nmUpDownDiasExcluirBackupsAntigos.Size = new System.Drawing.Size(68, 26);
            this.nmUpDownDiasExcluirBackupsAntigos.TabIndex = 33;
            // 
            // chbxExcluirBackupsAntigos
            // 
            this.chbxExcluirBackupsAntigos.AutoSize = true;
            this.chbxExcluirBackupsAntigos.BackColor = System.Drawing.Color.Transparent;
            this.chbxExcluirBackupsAntigos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxExcluirBackupsAntigos.Location = new System.Drawing.Point(28, 400);
            this.chbxExcluirBackupsAntigos.Name = "chbxExcluirBackupsAntigos";
            this.chbxExcluirBackupsAntigos.Size = new System.Drawing.Size(257, 17);
            this.chbxExcluirBackupsAntigos.TabIndex = 32;
            this.chbxExcluirBackupsAntigos.Text = "Excluir Arquivos de Backup mais antigos que:";
            this.chbxExcluirBackupsAntigos.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(25, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Argumentos²:";
            // 
            // tbArgumentosPosBackup
            // 
            this.tbArgumentosPosBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbArgumentosPosBackup.DefaultText = "";
            this.tbArgumentosPosBackup.ForeColor = System.Drawing.Color.Black;
            this.tbArgumentosPosBackup.Location = new System.Drawing.Point(104, 367);
            this.tbArgumentosPosBackup.Name = "tbArgumentosPosBackup";
            this.tbArgumentosPosBackup.PasswordChar = '\0';
            this.tbArgumentosPosBackup.SelectedText = "";
            this.tbArgumentosPosBackup.Size = new System.Drawing.Size(448, 24);
            this.tbArgumentosPosBackup.TabIndex = 30;
            // 
            // btnDiretorioAppPosBackup
            // 
            this.btnDiretorioAppPosBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiretorioAppPosBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDiretorioAppPosBackup.ForeColor = System.Drawing.Color.White;
            this.btnDiretorioAppPosBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnDiretorioAppPosBackup.Image")));
            this.btnDiretorioAppPosBackup.Location = new System.Drawing.Point(496, 337);
            this.btnDiretorioAppPosBackup.Name = "btnDiretorioAppPosBackup";
            this.btnDiretorioAppPosBackup.Size = new System.Drawing.Size(46, 24);
            this.btnDiretorioAppPosBackup.TabIndex = 29;
            this.btnDiretorioAppPosBackup.Click += new System.EventHandler(this.btnDiretorioAppPosBackup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label7.Location = new System.Drawing.Point(-4, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "Executar Aplicativo\r\nDepois do Backup²:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAplicativoPosBackup
            // 
            this.tbAplicativoPosBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAplicativoPosBackup.DefaultText = "";
            this.tbAplicativoPosBackup.ForeColor = System.Drawing.Color.Black;
            this.tbAplicativoPosBackup.Location = new System.Drawing.Point(104, 337);
            this.tbAplicativoPosBackup.Name = "tbAplicativoPosBackup";
            this.tbAplicativoPosBackup.PasswordChar = '\0';
            this.tbAplicativoPosBackup.SelectedText = "";
            this.tbAplicativoPosBackup.Size = new System.Drawing.Size(386, 24);
            this.tbAplicativoPosBackup.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(25, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Argumentos¹:";
            // 
            // tbArgumentosPreBackup
            // 
            this.tbArgumentosPreBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbArgumentosPreBackup.DefaultText = "";
            this.tbArgumentosPreBackup.ForeColor = System.Drawing.Color.Black;
            this.tbArgumentosPreBackup.Location = new System.Drawing.Point(104, 306);
            this.tbArgumentosPreBackup.Name = "tbArgumentosPreBackup";
            this.tbArgumentosPreBackup.PasswordChar = '\0';
            this.tbArgumentosPreBackup.SelectedText = "";
            this.tbArgumentosPreBackup.Size = new System.Drawing.Size(448, 24);
            this.tbArgumentosPreBackup.TabIndex = 25;
            // 
            // btnDiretorioAppPreBackup
            // 
            this.btnDiretorioAppPreBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiretorioAppPreBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDiretorioAppPreBackup.ForeColor = System.Drawing.Color.White;
            this.btnDiretorioAppPreBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnDiretorioAppPreBackup.Image")));
            this.btnDiretorioAppPreBackup.Location = new System.Drawing.Point(368, 276);
            this.btnDiretorioAppPreBackup.Name = "btnDiretorioAppPreBackup";
            this.btnDiretorioAppPreBackup.Size = new System.Drawing.Size(46, 24);
            this.btnDiretorioAppPreBackup.TabIndex = 24;
            this.btnDiretorioAppPreBackup.Click += new System.EventHandler(this.btnDiretorioAppPreBackup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(-1, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Executar Aplicativo\r\nAntes do Backup¹:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAplicativoPreBackup
            // 
            this.tbAplicativoPreBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAplicativoPreBackup.DefaultText = "";
            this.tbAplicativoPreBackup.ForeColor = System.Drawing.Color.Black;
            this.tbAplicativoPreBackup.Location = new System.Drawing.Point(104, 276);
            this.tbAplicativoPreBackup.Name = "tbAplicativoPreBackup";
            this.tbAplicativoPreBackup.PasswordChar = '\0';
            this.tbAplicativoPreBackup.SelectedText = "";
            this.tbAplicativoPreBackup.Size = new System.Drawing.Size(255, 24);
            this.tbAplicativoPreBackup.TabIndex = 22;
            // 
            // lstBoxFlagsBackup
            // 
            this.lstBoxFlagsBackup.CheckOnClick = true;
            this.lstBoxFlagsBackup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxFlagsBackup.FormattingEnabled = true;
            this.lstBoxFlagsBackup.Items.AddRange(new object[] {
            "IgnoreLimbo",
            "IgnoreChecksums",
            "MetaDataOnly",
            "NoDatabaseTriggers",
            "NoGarbageCollect",
            "NonTransportable",
            "OldDescriptions",
            "Compactar"});
            this.lstBoxFlagsBackup.Location = new System.Drawing.Point(104, 43);
            this.lstBoxFlagsBackup.Name = "lstBoxFlagsBackup";
            this.lstBoxFlagsBackup.Size = new System.Drawing.Size(386, 123);
            this.lstBoxFlagsBackup.TabIndex = 20;
            // 
            // btnDiretorioBackups
            // 
            this.btnDiretorioBackups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiretorioBackups.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDiretorioBackups.ForeColor = System.Drawing.Color.White;
            this.btnDiretorioBackups.Image = ((System.Drawing.Image)(resources.GetObject("btnDiretorioBackups.Image")));
            this.btnDiretorioBackups.Location = new System.Drawing.Point(496, 10);
            this.btnDiretorioBackups.Name = "btnDiretorioBackups";
            this.btnDiretorioBackups.Size = new System.Drawing.Size(46, 24);
            this.btnDiretorioBackups.TabIndex = 19;
            this.btnDiretorioBackups.Click += new System.EventHandler(this.btnDiretorioBackups_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Salvar Backups em:";
            // 
            // tbDiretorioBackups
            // 
            this.tbDiretorioBackups.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiretorioBackups.DefaultText = "";
            this.tbDiretorioBackups.ForeColor = System.Drawing.Color.Black;
            this.tbDiretorioBackups.Location = new System.Drawing.Point(104, 10);
            this.tbDiretorioBackups.Name = "tbDiretorioBackups";
            this.tbDiretorioBackups.PasswordChar = '\0';
            this.tbDiretorioBackups.ReadOnly = true;
            this.tbDiretorioBackups.SelectedText = "";
            this.tbDiretorioBackups.Size = new System.Drawing.Size(386, 24);
            this.tbDiretorioBackups.TabIndex = 17;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(506, 513);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(58, 39);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // bunifuElipseBtnSalvar
            // 
            this.bunifuElipseBtnSalvar.ElipseRadius = 10;
            this.bunifuElipseBtnSalvar.TargetControl = this.btnSalvar;
            // 
            // bunifuElipseBtnFechar
            // 
            this.bunifuElipseBtnFechar.ElipseRadius = 10;
            this.bunifuElipseBtnFechar.TargetControl = this;
            // 
            // bunifuElipseBtnDiretorioBackups
            // 
            this.bunifuElipseBtnDiretorioBackups.ElipseRadius = 10;
            this.bunifuElipseBtnDiretorioBackups.TargetControl = this.btnDiretorioBackups;
            // 
            // bunifuElipseBtnAppPreBackup
            // 
            this.bunifuElipseBtnAppPreBackup.ElipseRadius = 10;
            this.bunifuElipseBtnAppPreBackup.TargetControl = this.btnDiretorioAppPreBackup;
            // 
            // bunifuElipseBtnAppPosBackup
            // 
            this.bunifuElipseBtnAppPosBackup.ElipseRadius = 10;
            this.bunifuElipseBtnAppPosBackup.TargetControl = this.btnDiretorioAppPosBackup;
            // 
            // bunifuElipseBtnDiretorioGFIX
            // 
            this.bunifuElipseBtnDiretorioGFIX.ElipseRadius = 10;
            this.bunifuElipseBtnDiretorioGFIX.TargetControl = this.btnDiretorioGFIX;
            // 
            // UCConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.label4);
            this.Name = "UCConfiguracoes";
            this.Size = new System.Drawing.Size(571, 560);
            this.Load += new System.EventHandler(this.UCConfiguracoes_Load);
            this.tbControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.gpbxGFIX.ResumeLayout(false);
            this.gpbxGFIX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDownDiasExcluirBackupsAntigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage metroTabPage1;
        private System.Windows.Forms.Button btnSalvar;
        private System.ComponentModel.Component bunifuElipseBtnSalvar;
        private System.Windows.Forms.CheckBox chbxBuscaAtualizacoesIni;
        private System.Windows.Forms.TabPage metroTabPage2;
        private System.Windows.Forms.Button btnDiretorioBackups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDiretorioBackups;
        private System.Windows.Forms.CheckedListBox lstBoxFlagsBackup;
        private System.Windows.Forms.Button btnDiretorioAppPreBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAplicativoPreBackup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbArgumentosPosBackup;
        private System.Windows.Forms.Button btnDiretorioAppPosBackup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAplicativoPosBackup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbArgumentosPreBackup;
        private System.Windows.Forms.NumericUpDown nmUpDownDiasExcluirBackupsAntigos;
        private System.Windows.Forms.CheckBox chbxExcluirBackupsAntigos;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.Component bunifuElipseBtnFechar;
        private System.ComponentModel.Component bunifuElipseBtnDiretorioBackups;
        private System.ComponentModel.Component bunifuElipseBtnAppPreBackup;
        private System.ComponentModel.Component bunifuElipseBtnAppPosBackup;
        private System.Windows.Forms.LinkLabel lblExplicacaoFlags;
        private System.Windows.Forms.CheckBox chbxIniciarComOWindows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbxGFIX;
        private System.Windows.Forms.LinkLabel lblAvisoArgumentosGfix;
        private System.Windows.Forms.TextBox tbArgumentosGFIX;
        private System.Windows.Forms.TextBox tbDiretorioGFIX;
        private System.Windows.Forms.Button btnDiretorioGFIX;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox chbxExecutaGFIX;
        private System.Windows.Forms.LinkLabel lblAvisoGfix;
        private System.ComponentModel.Component bunifuElipseBtnDiretorioGFIX;
        private System.Windows.Forms.CheckBox chbxAguardarConclusaoAplicativoPreBackup;
    }
}

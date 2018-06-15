namespace ControleProg
{
    partial class FrmControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NIGerenciador = new System.Windows.Forms.NotifyIcon(this.components);
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGControle = new System.Windows.Forms.DataGridView();
            this.IDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTINICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTFIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMPOGASTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCalculaTempo = new System.Windows.Forms.Button();
            this.geraexcel = new System.Windows.Forms.Button();
            this.TBDataInicial = new System.Windows.Forms.DateTimePicker();
            this.TBDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncarregar = new System.Windows.Forms.Button();
            this.btnproxmes = new System.Windows.Forms.Button();
            this.btnmesanterior = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnreplica = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBXLS = new System.Windows.Forms.RadioButton();
            this.RBSVC = new System.Windows.Forms.RadioButton();
            this.TBArquivo = new System.Windows.Forms.TextBox();
            this.dtpPonto = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarPonto = new System.Windows.Forms.Button();
            this.lblTotHoras = new System.Windows.Forms.Label();
            this.btnRegistrosPonto = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGControle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NIGerenciador
            // 
            this.NIGerenciador.ContextMenuStrip = this.Menu;
            this.NIGerenciador.Icon = ((System.Drawing.Icon)(resources.GetObject("NIGerenciador.Icon")));
            this.NIGerenciador.Text = "Gerenciador OS";
            this.NIGerenciador.Visible = true;
            this.NIGerenciador.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.Size = new System.Drawing.Size(101, 54);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // DGControle
            // 
            this.DGControle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGControle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDOS,
            this.OS1,
            this.DESCRICAO,
            this.DTINICIO,
            this.DTFIM,
            this.TEMPOGASTO});
            this.DGControle.Location = new System.Drawing.Point(14, 43);
            this.DGControle.Name = "DGControle";
            this.DGControle.RowHeadersVisible = false;
            this.DGControle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGControle.Size = new System.Drawing.Size(867, 215);
            this.DGControle.TabIndex = 1;
            this.DGControle.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGControle_CellContentDoubleClick);
            // 
            // IDOS
            // 
            this.IDOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDOS.DataPropertyName = "IDOS";
            this.IDOS.HeaderText = "IDOS";
            this.IDOS.Name = "IDOS";
            this.IDOS.Visible = false;
            // 
            // OS1
            // 
            this.OS1.DataPropertyName = "OS1";
            this.OS1.HeaderText = "OS";
            this.OS1.Name = "OS1";
            this.OS1.Width = 50;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "Descrição";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Width = 440;
            // 
            // DTINICIO
            // 
            this.DTINICIO.DataPropertyName = "DTINICIO";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.DTINICIO.DefaultCellStyle = dataGridViewCellStyle1;
            this.DTINICIO.HeaderText = "Data Início";
            this.DTINICIO.Name = "DTINICIO";
            this.DTINICIO.Width = 130;
            // 
            // DTFIM
            // 
            this.DTFIM.DataPropertyName = "DTFIM";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.DTFIM.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTFIM.HeaderText = "Data Fim";
            this.DTFIM.Name = "DTFIM";
            this.DTFIM.Width = 130;
            // 
            // TEMPOGASTO
            // 
            this.TEMPOGASTO.DataPropertyName = "TEMPOGASTO";
            this.TEMPOGASTO.HeaderText = "Tempo Gasto";
            this.TEMPOGASTO.Name = "TEMPOGASTO";
            this.TEMPOGASTO.Width = 90;
            // 
            // BtnCalculaTempo
            // 
            this.BtnCalculaTempo.Location = new System.Drawing.Point(325, 11);
            this.BtnCalculaTempo.Name = "BtnCalculaTempo";
            this.BtnCalculaTempo.Size = new System.Drawing.Size(90, 23);
            this.BtnCalculaTempo.TabIndex = 5;
            this.BtnCalculaTempo.Text = "Calcula Tempo";
            this.BtnCalculaTempo.UseVisualStyleBackColor = true;
            this.BtnCalculaTempo.Click += new System.EventHandler(this.btncalculatempo_Click);
            // 
            // geraexcel
            // 
            this.geraexcel.Location = new System.Drawing.Point(689, 14);
            this.geraexcel.Name = "geraexcel";
            this.geraexcel.Size = new System.Drawing.Size(75, 23);
            this.geraexcel.TabIndex = 8;
            this.geraexcel.Text = "Gerar Arq";
            this.geraexcel.UseVisualStyleBackColor = true;
            this.geraexcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBDataInicial
            // 
            this.TBDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TBDataInicial.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.TBDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TBDataInicial.Location = new System.Drawing.Point(80, 269);
            this.TBDataInicial.Name = "TBDataInicial";
            this.TBDataInicial.Size = new System.Drawing.Size(141, 20);
            this.TBDataInicial.TabIndex = 11;
            // 
            // TBDataFinal
            // 
            this.TBDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TBDataFinal.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.TBDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TBDataFinal.Location = new System.Drawing.Point(296, 270);
            this.TBDataFinal.Name = "TBDataFinal";
            this.TBDataFinal.Size = new System.Drawing.Size(141, 20);
            this.TBDataFinal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data Final";
            // 
            // btncarregar
            // 
            this.btncarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncarregar.Location = new System.Drawing.Point(443, 268);
            this.btncarregar.Name = "btncarregar";
            this.btncarregar.Size = new System.Drawing.Size(75, 23);
            this.btncarregar.TabIndex = 15;
            this.btncarregar.Text = "Carregar";
            this.btncarregar.UseVisualStyleBackColor = true;
            this.btncarregar.Click += new System.EventHandler(this.btncarregar_Click);
            // 
            // btnproxmes
            // 
            this.btnproxmes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnproxmes.Location = new System.Drawing.Point(552, 268);
            this.btnproxmes.Name = "btnproxmes";
            this.btnproxmes.Size = new System.Drawing.Size(22, 23);
            this.btnproxmes.TabIndex = 17;
            this.btnproxmes.Text = ">";
            this.btnproxmes.UseVisualStyleBackColor = true;
            this.btnproxmes.Click += new System.EventHandler(this.btnproxmes_Click);
            // 
            // btnmesanterior
            // 
            this.btnmesanterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnmesanterior.Location = new System.Drawing.Point(524, 268);
            this.btnmesanterior.Name = "btnmesanterior";
            this.btnmesanterior.Size = new System.Drawing.Size(22, 23);
            this.btnmesanterior.TabIndex = 18;
            this.btnmesanterior.Text = "<";
            this.btnmesanterior.UseVisualStyleBackColor = true;
            this.btnmesanterior.Click += new System.EventHandler(this.btnmesanterior_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(14, 11);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(60, 23);
            this.btnInserir.TabIndex = 19;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(150, 11);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 23);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnreplica
            // 
            this.btnreplica.Location = new System.Drawing.Point(80, 11);
            this.btnreplica.Name = "btnreplica";
            this.btnreplica.Size = new System.Drawing.Size(64, 23);
            this.btnreplica.TabIndex = 21;
            this.btnreplica.Text = "Replica";
            this.btnreplica.UseVisualStyleBackColor = true;
            this.btnreplica.Click += new System.EventHandler(this.btnreplica_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBXLS);
            this.groupBox1.Controls.Add(this.RBSVC);
            this.groupBox1.Location = new System.Drawing.Point(582, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 36);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerar";
            // 
            // RBXLS
            // 
            this.RBXLS.AutoSize = true;
            this.RBXLS.Checked = true;
            this.RBXLS.Location = new System.Drawing.Point(60, 16);
            this.RBXLS.Name = "RBXLS";
            this.RBXLS.Size = new System.Drawing.Size(37, 17);
            this.RBXLS.TabIndex = 1;
            this.RBXLS.TabStop = true;
            this.RBXLS.Text = "xls";
            this.RBXLS.UseVisualStyleBackColor = true;
            // 
            // RBSVC
            // 
            this.RBSVC.AutoSize = true;
            this.RBSVC.Location = new System.Drawing.Point(6, 16);
            this.RBSVC.Name = "RBSVC";
            this.RBSVC.Size = new System.Drawing.Size(42, 17);
            this.RBSVC.TabIndex = 0;
            this.RBSVC.Text = "csv";
            this.RBSVC.UseVisualStyleBackColor = true;
            // 
            // TBArquivo
            // 
            this.TBArquivo.Location = new System.Drawing.Point(443, 15);
            this.TBArquivo.Name = "TBArquivo";
            this.TBArquivo.Size = new System.Drawing.Size(131, 20);
            this.TBArquivo.TabIndex = 23;
            this.TBArquivo.Text = "c:\\temp\\teste";
            // 
            // dtpPonto
            // 
            this.dtpPonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpPonto.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpPonto.CustomFormat = "HH:mm";
            this.dtpPonto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPonto.Location = new System.Drawing.Point(696, 270);
            this.dtpPonto.Name = "dtpPonto";
            this.dtpPonto.ShowUpDown = true;
            this.dtpPonto.Size = new System.Drawing.Size(64, 20);
            this.dtpPonto.TabIndex = 25;
            this.dtpPonto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtpPonto_MouseUp);
            // 
            // btnRegistrarPonto
            // 
            this.btnRegistrarPonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistrarPonto.Location = new System.Drawing.Point(766, 268);
            this.btnRegistrarPonto.Name = "btnRegistrarPonto";
            this.btnRegistrarPonto.Size = new System.Drawing.Size(115, 23);
            this.btnRegistrarPonto.TabIndex = 26;
            this.btnRegistrarPonto.Text = "Registrar: Entrada";
            this.btnRegistrarPonto.UseVisualStyleBackColor = true;
            this.btnRegistrarPonto.Click += new System.EventHandler(this.btnRegistrarPonto_Click);
            // 
            // lblTotHoras
            // 
            this.lblTotHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotHoras.AutoSize = true;
            this.lblTotHoras.Location = new System.Drawing.Point(580, 273);
            this.lblTotHoras.Name = "lblTotHoras";
            this.lblTotHoras.Size = new System.Drawing.Size(60, 13);
            this.lblTotHoras.TabIndex = 27;
            this.lblTotHoras.Text = "Tot. Horas:";
            // 
            // btnRegistrosPonto
            // 
            this.btnRegistrosPonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistrosPonto.Location = new System.Drawing.Point(770, 14);
            this.btnRegistrosPonto.Name = "btnRegistrosPonto";
            this.btnRegistrosPonto.Size = new System.Drawing.Size(111, 23);
            this.btnRegistrosPonto.TabIndex = 28;
            this.btnRegistrosPonto.Text = "Registros de Ponto";
            this.btnRegistrosPonto.UseVisualStyleBackColor = true;
            this.btnRegistrosPonto.Click += new System.EventHandler(this.btnRegistrosPonto_Click);
            // 
            // FrmControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 297);
            this.Controls.Add(this.btnRegistrosPonto);
            this.Controls.Add(this.lblTotHoras);
            this.Controls.Add(this.btnRegistrarPonto);
            this.Controls.Add(this.dtpPonto);
            this.Controls.Add(this.TBArquivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnreplica);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnmesanterior);
            this.Controls.Add(this.btnproxmes);
            this.Controls.Add(this.btncarregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDataFinal);
            this.Controls.Add(this.TBDataInicial);
            this.Controls.Add(this.geraexcel);
            this.Controls.Add(this.BtnCalculaTempo);
            this.Controls.Add(this.DGControle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmControle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador OS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controle_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FrmControle_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGControle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NIGerenciador;
        private new System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGControle;
        private System.Windows.Forms.Button BtnCalculaTempo;
        private System.Windows.Forms.Button geraexcel;
        private System.Windows.Forms.DateTimePicker TBDataInicial;
        private System.Windows.Forms.DateTimePicker TBDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncarregar;
        private System.Windows.Forms.Button btnproxmes;
        private System.Windows.Forms.Button btnmesanterior;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnreplica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBXLS;
        private System.Windows.Forms.RadioButton RBSVC;
        private System.Windows.Forms.TextBox TBArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTINICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTFIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMPOGASTO;
        private System.Windows.Forms.DateTimePicker dtpPonto;
        private System.Windows.Forms.Button btnRegistrarPonto;
        private System.Windows.Forms.Label lblTotHoras;
        private System.Windows.Forms.Button btnRegistrosPonto;
    }
}


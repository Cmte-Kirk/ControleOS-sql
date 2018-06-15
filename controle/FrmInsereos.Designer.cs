namespace ControleProg
{
    partial class FrmInsereos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsereos));
            this.tbos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbdescricao = new System.Windows.Forms.TextBox();
            this.dpDtInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDtFim = new System.Windows.Forms.Label();
            this.dpDtFim = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Lidos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbos
            // 
            this.tbos.Location = new System.Drawing.Point(316, 21);
            this.tbos.Name = "tbos";
            this.tbos.Size = new System.Drawing.Size(100, 20);
            this.tbos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbdescricao
            // 
            this.tbdescricao.Location = new System.Drawing.Point(12, 56);
            this.tbdescricao.Multiline = true;
            this.tbdescricao.Name = "tbdescricao";
            this.tbdescricao.Size = new System.Drawing.Size(404, 46);
            this.tbdescricao.TabIndex = 2;
            this.tbdescricao.TextChanged += new System.EventHandler(this.tbdescricao_TextChanged);
            // 
            // dpDtInicio
            // 
            this.dpDtInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dpDtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDtInicio.Location = new System.Drawing.Point(12, 123);
            this.dpDtInicio.Name = "dpDtInicio";
            this.dpDtInicio.Size = new System.Drawing.Size(132, 20);
            this.dpDtInicio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Início";
            // 
            // tbDtFim
            // 
            this.tbDtFim.AutoSize = true;
            this.tbDtFim.Location = new System.Drawing.Point(284, 107);
            this.tbDtFim.Name = "tbDtFim";
            this.tbDtFim.Size = new System.Drawing.Size(49, 13);
            this.tbDtFim.TabIndex = 7;
            this.tbDtFim.Text = "Data Fim";
            // 
            // dpDtFim
            // 
            this.dpDtFim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dpDtFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDtFim.Location = new System.Drawing.Point(284, 123);
            this.dpDtFim.Name = "dpDtFim";
            this.dpDtFim.Size = new System.Drawing.Size(132, 20);
            this.dpDtFim.TabIndex = 6;
            this.dpDtFim.ValueChanged += new System.EventHandler(this.dpDtFim_ValueChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImageIndex = 0;
            this.btnSalvar.ImageList = this.imageList1;
            this.btnSalvar.Location = new System.Drawing.Point(177, 155);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "salvar.ico");
            // 
            // Lidos
            // 
            this.Lidos.AutoSize = true;
            this.Lidos.Location = new System.Drawing.Point(81, 21);
            this.Lidos.Name = "Lidos";
            this.Lidos.Size = new System.Drawing.Size(0, 13);
            this.Lidos.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "IdOs: ";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.ImageIndex = 0;
            this.btnAtualizar.ImageList = this.imageList1;
            this.btnAtualizar.Location = new System.Drawing.Point(339, 149);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(77, 23);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmInsereos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 191);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lidos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbDtFim);
            this.Controls.Add(this.dpDtFim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpDtInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbdescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInsereos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefa";
            this.Load += new System.EventHandler(this.FrmInsereos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbDtFim;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Label Lidos;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbos;
        public System.Windows.Forms.TextBox tbdescricao;
        public System.Windows.Forms.DateTimePicker dpDtInicio;
        public System.Windows.Forms.DateTimePicker dpDtFim;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
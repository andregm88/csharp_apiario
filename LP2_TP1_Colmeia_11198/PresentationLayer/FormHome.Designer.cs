namespace LP2_Final_Colmeia_11198
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.GroupBox();
            this.labelNColmeias = new System.Windows.Forms.Label();
            this.labelNApiarios = new System.Windows.Forms.Label();
            this.labelNApicultores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabCriaApiario = new System.Windows.Forms.TabPage();
            this.tabCriaApicultor = new System.Windows.Forms.TabPage();
            this.buttonGravaApicultor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textContactoApicultor = new System.Windows.Forms.TextBox();
            this.FotoApitultor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDataInicioAtividade = new System.Windows.Forms.DateTimePicker();
            this.labelNomeApicultor = new System.Windows.Forms.Label();
            this.textNomeApicultor = new System.Windows.Forms.TextBox();
            this.labelCodApicultor = new System.Windows.Forms.Label();
            this.textCodApicultor = new System.Windows.Forms.TextBox();
            this.tabGeral = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.textAssociacao = new System.Windows.Forms.TextBox();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabCriaApicultor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoApitultor)).BeginInit();
            this.tabGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(157, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestor de Apiarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Status.Controls.Add(this.labelNColmeias);
            this.Status.Controls.Add(this.labelNApiarios);
            this.Status.Controls.Add(this.labelNApicultores);
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Status.Location = new System.Drawing.Point(23, 149);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(288, 187);
            this.Status.TabIndex = 1;
            this.Status.TabStop = false;
            this.Status.Text = "Status";
            this.Status.Enter += new System.EventHandler(this.Status_Enter);
            // 
            // labelNColmeias
            // 
            this.labelNColmeias.AutoSize = true;
            this.labelNColmeias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNColmeias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNColmeias.Location = new System.Drawing.Point(16, 136);
            this.labelNColmeias.Name = "labelNColmeias";
            this.labelNColmeias.Size = new System.Drawing.Size(194, 24);
            this.labelNColmeias.TabIndex = 2;
            this.labelNColmeias.Text = "Numero de Colmeias:";
            // 
            // labelNApiarios
            // 
            this.labelNApiarios.AutoSize = true;
            this.labelNApiarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNApiarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNApiarios.Location = new System.Drawing.Point(16, 88);
            this.labelNApiarios.Name = "labelNApiarios";
            this.labelNApiarios.Size = new System.Drawing.Size(184, 24);
            this.labelNApiarios.TabIndex = 1;
            this.labelNApiarios.Text = "Numero de Apiarios:";
            this.labelNApiarios.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelNApicultores
            // 
            this.labelNApicultores.AutoSize = true;
            this.labelNApicultores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNApicultores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNApicultores.Location = new System.Drawing.Point(16, 40);
            this.labelNApicultores.Name = "labelNApicultores";
            this.labelNApicultores.Size = new System.Drawing.Size(210, 24);
            this.labelNApicultores.TabIndex = 0;
            this.labelNApicultores.Text = "Numero de Apicultores:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabCriaApiario
            // 
            this.tabCriaApiario.Location = new System.Drawing.Point(4, 29);
            this.tabCriaApiario.Name = "tabCriaApiario";
            this.tabCriaApiario.Padding = new System.Windows.Forms.Padding(3);
            this.tabCriaApiario.Size = new System.Drawing.Size(664, 343);
            this.tabCriaApiario.TabIndex = 1;
            this.tabCriaApiario.Text = "CriaApiario";
            this.tabCriaApiario.UseVisualStyleBackColor = true;
            // 
            // tabCriaApicultor
            // 
            this.tabCriaApicultor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabCriaApicultor.Controls.Add(this.label5);
            this.tabCriaApicultor.Controls.Add(this.textAssociacao);
            this.tabCriaApicultor.Controls.Add(this.buttonGravaApicultor);
            this.tabCriaApicultor.Controls.Add(this.label4);
            this.tabCriaApicultor.Controls.Add(this.label3);
            this.tabCriaApicultor.Controls.Add(this.textContactoApicultor);
            this.tabCriaApicultor.Controls.Add(this.FotoApitultor);
            this.tabCriaApicultor.Controls.Add(this.label2);
            this.tabCriaApicultor.Controls.Add(this.dateDataInicioAtividade);
            this.tabCriaApicultor.Controls.Add(this.labelNomeApicultor);
            this.tabCriaApicultor.Controls.Add(this.textNomeApicultor);
            this.tabCriaApicultor.Controls.Add(this.labelCodApicultor);
            this.tabCriaApicultor.Controls.Add(this.textCodApicultor);
            this.tabCriaApicultor.Location = new System.Drawing.Point(4, 29);
            this.tabCriaApicultor.Name = "tabCriaApicultor";
            this.tabCriaApicultor.Padding = new System.Windows.Forms.Padding(3);
            this.tabCriaApicultor.Size = new System.Drawing.Size(664, 431);
            this.tabCriaApicultor.TabIndex = 0;
            this.tabCriaApicultor.Text = "Cria Apicultor";
            this.tabCriaApicultor.Click += new System.EventHandler(this.tabCriaApicultor_Click);
            // 
            // buttonGravaApicultor
            // 
            this.buttonGravaApicultor.Location = new System.Drawing.Point(440, 280);
            this.buttonGravaApicultor.Name = "buttonGravaApicultor";
            this.buttonGravaApicultor.Size = new System.Drawing.Size(184, 32);
            this.buttonGravaApicultor.TabIndex = 16;
            this.buttonGravaApicultor.Text = "Gravar";
            this.buttonGravaApicultor.UseVisualStyleBackColor = true;
            this.buttonGravaApicultor.Click += new System.EventHandler(this.buttonGravaApicultor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Foto Apicultor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contacto Apicultor";
            // 
            // textContactoApicultor
            // 
            this.textContactoApicultor.Location = new System.Drawing.Point(192, 224);
            this.textContactoApicultor.Name = "textContactoApicultor";
            this.textContactoApicultor.Size = new System.Drawing.Size(200, 26);
            this.textContactoApicultor.TabIndex = 13;
            // 
            // FotoApitultor
            // 
            this.FotoApitultor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FotoApitultor.InitialImage = null;
            this.FotoApitultor.Location = new System.Drawing.Point(440, 88);
            this.FotoApitultor.Name = "FotoApitultor";
            this.FotoApitultor.Size = new System.Drawing.Size(184, 168);
            this.FotoApitultor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoApitultor.TabIndex = 12;
            this.FotoApitultor.TabStop = false;
            this.FotoApitultor.Click += new System.EventHandler(this.FotoPictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Inicio Atividade";
            // 
            // dateDataInicioAtividade
            // 
            this.dateDataInicioAtividade.Location = new System.Drawing.Point(192, 160);
            this.dateDataInicioAtividade.Name = "dateDataInicioAtividade";
            this.dateDataInicioAtividade.Size = new System.Drawing.Size(200, 26);
            this.dateDataInicioAtividade.TabIndex = 4;
            // 
            // labelNomeApicultor
            // 
            this.labelNomeApicultor.AutoSize = true;
            this.labelNomeApicultor.Location = new System.Drawing.Point(24, 112);
            this.labelNomeApicultor.Name = "labelNomeApicultor";
            this.labelNomeApicultor.Size = new System.Drawing.Size(117, 20);
            this.labelNomeApicultor.TabIndex = 3;
            this.labelNomeApicultor.Text = "Nome Apicultor";
            // 
            // textNomeApicultor
            // 
            this.textNomeApicultor.Location = new System.Drawing.Point(192, 104);
            this.textNomeApicultor.Name = "textNomeApicultor";
            this.textNomeApicultor.Size = new System.Drawing.Size(200, 26);
            this.textNomeApicultor.TabIndex = 2;
            // 
            // labelCodApicultor
            // 
            this.labelCodApicultor.AutoSize = true;
            this.labelCodApicultor.Location = new System.Drawing.Point(24, 48);
            this.labelCodApicultor.Name = "labelCodApicultor";
            this.labelCodApicultor.Size = new System.Drawing.Size(125, 20);
            this.labelCodApicultor.TabIndex = 1;
            this.labelCodApicultor.Text = "Codigo Apicultor";
            // 
            // textCodApicultor
            // 
            this.textCodApicultor.Location = new System.Drawing.Point(192, 40);
            this.textCodApicultor.Name = "textCodApicultor";
            this.textCodApicultor.Size = new System.Drawing.Size(200, 26);
            this.textCodApicultor.TabIndex = 0;
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.tabCriaApicultor);
            this.tabGeral.Controls.Add(this.tabCriaApiario);
            this.tabGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGeral.Location = new System.Drawing.Point(344, 152);
            this.tabGeral.Multiline = true;
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.SelectedIndex = 0;
            this.tabGeral.Size = new System.Drawing.Size(672, 464);
            this.tabGeral.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Associação";
            // 
            // textAssociacao
            // 
            this.textAssociacao.Location = new System.Drawing.Point(192, 288);
            this.textAssociacao.Name = "textAssociacao";
            this.textAssociacao.Size = new System.Drawing.Size(200, 26);
            this.textAssociacao.TabIndex = 17;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 686);
            this.Controls.Add(this.tabGeral);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gestor de Apiarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabCriaApicultor.ResumeLayout(false);
            this.tabCriaApicultor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoApitultor)).EndInit();
            this.tabGeral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNApicultores;
        private System.Windows.Forms.Label labelNApiarios;
        private System.Windows.Forms.Label labelNColmeias;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabCriaApiario;
        private System.Windows.Forms.TabPage tabCriaApicultor;
        private System.Windows.Forms.TabControl tabGeral;
        private System.Windows.Forms.TextBox textCodApicultor;
        private System.Windows.Forms.Label labelCodApicultor;
        private System.Windows.Forms.Label labelNomeApicultor;
        private System.Windows.Forms.TextBox textNomeApicultor;
        private System.Windows.Forms.DateTimePicker dateDataInicioAtividade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox FotoApitultor;
        private System.Windows.Forms.Button buttonGravaApicultor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textContactoApicultor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAssociacao;

    }
}
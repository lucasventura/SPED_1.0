﻿namespace Hlp.Sped.UI
{
    partial class FormSpedPisCofins
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpTipoRemessa = new System.Windows.Forms.GroupBox();
            this.txtNumeroReciboAnterior = new System.Windows.Forms.TextBox();
            this.lblDescNumeroReciboAnterior = new System.Windows.Forms.Label();
            this.rdbRemesssaSubstituta = new System.Windows.Forms.RadioButton();
            this.rdbRemessaOriginal = new System.Windows.Forms.RadioButton();
            this.cbxEmpresas = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.titleStrip1 = new Hlp.Sped.UI.TitleStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            this.grpTipoRemessa.SuspendLayout();
            this.panel3.SuspendLayout();
            this.titleStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.grpTipoRemessa);
            this.panel1.Controls.Add(this.cbxEmpresas);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Controls.Add(this.lblProgresso);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.dtpFim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 316);
            this.panel1.TabIndex = 4;
            // 
            // grpTipoRemessa
            // 
            this.grpTipoRemessa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTipoRemessa.Controls.Add(this.txtNumeroReciboAnterior);
            this.grpTipoRemessa.Controls.Add(this.lblDescNumeroReciboAnterior);
            this.grpTipoRemessa.Controls.Add(this.rdbRemesssaSubstituta);
            this.grpTipoRemessa.Controls.Add(this.rdbRemessaOriginal);
            this.grpTipoRemessa.Location = new System.Drawing.Point(18, 120);
            this.grpTipoRemessa.Name = "grpTipoRemessa";
            this.grpTipoRemessa.Size = new System.Drawing.Size(368, 105);
            this.grpTipoRemessa.TabIndex = 7;
            this.grpTipoRemessa.TabStop = false;
            this.grpTipoRemessa.Text = "Tipo de Remessa";
            // 
            // txtNumeroReciboAnterior
            // 
            this.txtNumeroReciboAnterior.Location = new System.Drawing.Point(17, 66);
            this.txtNumeroReciboAnterior.MaxLength = 41;
            this.txtNumeroReciboAnterior.Name = "txtNumeroReciboAnterior";
            this.txtNumeroReciboAnterior.Size = new System.Drawing.Size(336, 20);
            this.txtNumeroReciboAnterior.TabIndex = 10;
            // 
            // lblDescNumeroReciboAnterior
            // 
            this.lblDescNumeroReciboAnterior.AutoSize = true;
            this.lblDescNumeroReciboAnterior.Location = new System.Drawing.Point(14, 50);
            this.lblDescNumeroReciboAnterior.Name = "lblDescNumeroReciboAnterior";
            this.lblDescNumeroReciboAnterior.Size = new System.Drawing.Size(212, 13);
            this.lblDescNumeroReciboAnterior.TabIndex = 9;
            this.lblDescNumeroReciboAnterior.Text = "Número do Recibo da Escrituração Anterior";
            // 
            // rdbRemesssaSubstituta
            // 
            this.rdbRemesssaSubstituta.AutoSize = true;
            this.rdbRemesssaSubstituta.Location = new System.Drawing.Point(154, 19);
            this.rdbRemesssaSubstituta.Name = "rdbRemesssaSubstituta";
            this.rdbRemesssaSubstituta.Size = new System.Drawing.Size(72, 17);
            this.rdbRemesssaSubstituta.TabIndex = 8;
            this.rdbRemesssaSubstituta.Text = "Substituta";
            this.rdbRemesssaSubstituta.UseVisualStyleBackColor = true;
            this.rdbRemesssaSubstituta.CheckedChanged += new System.EventHandler(this.rdbTipoRemessa_CheckedChanged);
            // 
            // rdbRemessaOriginal
            // 
            this.rdbRemessaOriginal.AutoSize = true;
            this.rdbRemessaOriginal.Checked = true;
            this.rdbRemessaOriginal.Location = new System.Drawing.Point(44, 19);
            this.rdbRemessaOriginal.Name = "rdbRemessaOriginal";
            this.rdbRemessaOriginal.Size = new System.Drawing.Size(60, 17);
            this.rdbRemessaOriginal.TabIndex = 7;
            this.rdbRemessaOriginal.TabStop = true;
            this.rdbRemessaOriginal.Text = "Original";
            this.rdbRemessaOriginal.UseVisualStyleBackColor = true;
            this.rdbRemessaOriginal.CheckedChanged += new System.EventHandler(this.rdbTipoRemessa_CheckedChanged);
            // 
            // cbxEmpresas
            // 
            this.cbxEmpresas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEmpresas.FormattingEnabled = true;
            this.cbxEmpresas.Items.AddRange(new object[] {
            "001 - Empresa 001",
            "002 - Teste 002",
            "111 - Empresa 111",
            "999 - Teste 999"});
            this.cbxEmpresas.Location = new System.Drawing.Point(18, 90);
            this.cbxEmpresas.Name = "cbxEmpresas";
            this.cbxEmpresas.Size = new System.Drawing.Size(368, 21);
            this.cbxEmpresas.TabIndex = 5;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(15, 74);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblProgresso
            // 
            this.lblProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProgresso.Location = new System.Drawing.Point(15, 239);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(144, 13);
            this.lblProgresso.TabIndex = 8;
            this.lblProgresso.Text = "Processando Notas Fiscais...";
            this.lblProgresso.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(18, 255);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(368, 11);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // dtpFim
            // 
            this.dtpFim.CustomFormat = "MMMM yyyy";
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(172, 47);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(124, 20);
            this.dtpFim.TabIndex = 3;
            this.dtpFim.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mês Final:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "MMMM yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(18, 47);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(124, 20);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.Value = new System.DateTime(2010, 12, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mês Inicial:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Arquivo de texto|*.txt";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Hlp.Sped.UI.Properties.Resources.blueheader;
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Controls.Add(this.btnProcessar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 33);
            this.panel3.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(324, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.Location = new System.Drawing.Point(243, 5);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 0;
            this.btnProcessar.Text = "&Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // titleStrip1
            // 
            this.titleStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.titleStrip1.DrawEndLine = false;
            this.titleStrip1.GradientEndColor = System.Drawing.Color.White;
            this.titleStrip1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(186)))), ((int)(((byte)(214)))));
            this.titleStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titleStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.titleStrip1.Lines = 10;
            this.titleStrip1.Location = new System.Drawing.Point(0, 0);
            this.titleStrip1.Name = "titleStrip1";
            this.titleStrip1.Size = new System.Drawing.Size(409, 25);
            this.titleStrip1.TabIndex = 7;
            this.titleStrip1.Text = "titleStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(323, 22);
            this.toolStripLabel1.Text = "Selecione o período e a empresa para geração do arquivo";
            // 
            // FormSpedPisCofins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 316);
            this.Controls.Add(this.titleStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSpedPisCofins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sped - Pis / Cofins";
            this.Load += new System.EventHandler(this.FormSpedPisCofins_Load);
            this.Shown += new System.EventHandler(this.FormSpedPisCofins_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSpedPisCofins_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpTipoRemessa.ResumeLayout(false);
            this.grpTipoRemessa.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.titleStrip1.ResumeLayout(false);
            this.titleStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProcessar;
        private TitleStrip titleStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cbxEmpresas;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox grpTipoRemessa;
        private System.Windows.Forms.RadioButton rdbRemesssaSubstituta;
        private System.Windows.Forms.RadioButton rdbRemessaOriginal;
        private System.Windows.Forms.TextBox txtNumeroReciboAnterior;
        private System.Windows.Forms.Label lblDescNumeroReciboAnterior;
    }
}